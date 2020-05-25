using System.ComponentModel.DataAnnotations;

namespace ViewingInsights.App.Data
{
    public class ExampleModel
    {
        [Required]
        [StringLength(10, ErrorMessage = "Name is too long.")]
        public string Name { get; set; }
    }
}
