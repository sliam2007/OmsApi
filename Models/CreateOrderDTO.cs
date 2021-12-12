using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OmsApi.Models
{
    public class CreateOrderDTO
    {
        [Required]
        public string omsId { get; set; }

        [Required]
        public IList<OrderProductDTO> products { get; set; }

        public OrderDetailsDTO orderDetails { get; set; }

    }
}
