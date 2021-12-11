using System.ComponentModel.DataAnnotations;

namespace OmsApi.Models
{
    public class OrderDetailsDTO
    {
        [Required]
        public string factoryId { get; set; }

        public string factoryName { get; set; }

        public string factoryAddress { get; set; }

        [Required]
        public string factoryCountry { get; set; }

        [Required]
        public string productionLineId { get; set; }

        [Required]
        public string productCode { get; set; }

        [Required]
        public string productDescription { get; set; }

        public string poNumber { get; set; }

        public string expectedStartDate { get; set; }

    }
}
