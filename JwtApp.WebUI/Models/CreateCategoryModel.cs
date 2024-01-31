using System.ComponentModel.DataAnnotations;

namespace JWT.APP.WebUI.Models
{
    public class CreateCategoryModel
    {
        [Required]
        public string Definition { get; set; } = null!;
    }
}
