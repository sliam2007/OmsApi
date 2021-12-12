using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OmsApi.Data;
using OmsApi.Models;
using OmsApi.Services.Interfaces;

namespace OmsApi.Controllers
{

    [Route("api/v2/orders")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly IAuthenticationManager _authenticationManager;
        private readonly IOrderManager _orderManager;

        public OrderController(IMapper mapper,
            IAuthenticationManager authenticationManager,
            IOrderManager orderManager
            )
        {
            _mapper = mapper;
            _authenticationManager = authenticationManager;
            _orderManager = orderManager;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult CreateOrder([FromBody] CreateOrderDTO orderDTO)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // validate omsId
            if (!_authenticationManager.ValidateOmsId(orderDTO.omsId))
            {
                return BadRequest("Invalid omsId.");
            }

            // validate clientToken
            Request.Headers.TryGetValue("clientToken", out var clientToken);
            if (!_authenticationManager.ValidateClientToken(orderDTO.omsId, clientToken))
            {
                return BadRequest("Invalid client token.");
            }

            // create order
            var createOrderData = _mapper.Map<CreateOrder>(orderDTO);
            var result = _orderManager.CreateOrder(createOrderData);

            if (result.error != null)
            {
                return BadRequest(result.error);
            }

            return Ok(_mapper.Map<CreateOrderResponseDTO>(result));

        }

    }
}
