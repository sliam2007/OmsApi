using System.Collections.Generic;

namespace OmsApi.Data
{
    public class CreateOrder
    {

        public string omsId { get; set; }

        public IList<OrderProduct> products { get; set; }

        public OrderDetails orderDetails { get; set; }

    }
}
