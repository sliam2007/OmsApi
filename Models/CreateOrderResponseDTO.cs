namespace OmsApi.Models
{
    public class CreateOrderResponseDTO
    {
        public string omsId { get; set; }

        public string orderId { get; set; }

        public int expectedCompletionTime { get; set; }
    }
}
