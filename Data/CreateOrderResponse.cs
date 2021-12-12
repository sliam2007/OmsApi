using System.ComponentModel.DataAnnotations;

namespace OmsApi.Models
{
    public class CreateOrderResponse
    {
        public string omsId { get; set; }

        public string orderId { get; set; }

        public int expectedCompletionTime { get; set; }

        public string error { get; set; }
    }
}
