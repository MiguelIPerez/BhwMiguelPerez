using System.ComponentModel.DataAnnotations;

namespace MiguelPerez2.ViewModel
{
    public class Electrodomestic
    {
        [Required]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public int Quantity { get; set; }
    }
}
