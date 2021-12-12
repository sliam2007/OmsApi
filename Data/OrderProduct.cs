using System.ComponentModel.DataAnnotations;

namespace OmsApi.Data
{
    public class OrderProduct
    {

        public string gtin { get; set; }

        public int quantity { get; set; }

        public string serialNumberType { get; set; }

        public string[] serialNumbers { get; set; }

        public string templateId { get; set; }

    }
}
