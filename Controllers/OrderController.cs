using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OmsApi.Data;
using OmsApi.Models;
using System;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace OmsApi.Controllers
{

    [Route("api/v2/orders")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        private readonly IMapper _mapper;

        public OrderController(IMapper mapper)
        {
            _mapper = mapper;
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

            Request.Headers.TryGetValue("clientToken", out var clientTokenValue);
            if (clientTokenValue != "1cecc8fb-fb47-4c8a-af3d-d34c1ead8c4f")
            {
                return BadRequest("Invalid client token.");
            }

            var createOrder = _mapper.Map<CreateOrder>(orderDTO);

            CreateOrderResponse result = new();
            result.omsId = orderDTO.omsId;

            result.orderId = Guid.NewGuid().ToString();         // for example
            Random rnd = new();                                 // for example 
            result.expectedCompletionTime = Convert.ToInt16(Math.Round(10000 * rnd.NextDouble()));    // for example 

            return Ok(result);

        }

    }
}
