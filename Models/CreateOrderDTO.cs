using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OmsApi.Models
{
    public class CreateOrderDTO
    {
        [Required]
        public string omsId { get; set; }                   // Unique OMS identifier.

        [Required]
        public IList<OrderProductDTO> products { get; set; }   // List of products.

        public OrderDetailsDTO orderDetails { get; set; }      // Additional order information. 

    }
}
