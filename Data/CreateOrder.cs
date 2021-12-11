using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OmsApi.Data
{
    public class CreateOrder
    {

        public string omsId { get; set; }                   // Unique OMS identifier.

        public IList<OrderProduct> products { get; set; }   // List of products.

        public OrderDetails orderDetails { get; set; }      // Additional order information. 

    }
}
