using System.ComponentModel.DataAnnotations;

namespace OmsApi.Models
{
    public class OrderProductDTO
    {

        [Required]
        [StringLength(14, ErrorMessage = "{0} must be {1} characters.", MinimumLength = 14)]
        public string gtin { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "quantity must be greater than 0.")]
        public int quantity { get; set; }

        [Required]
        public string serialNumberType { get; set; }

        [Required]
        public string serialNumbers { get; set; }

        [Required]
        public string templateId { get; set; }

    }
}
