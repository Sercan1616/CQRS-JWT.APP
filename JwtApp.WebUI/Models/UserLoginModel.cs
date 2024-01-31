using System.ComponentModel.DataAnnotations;

namespace JWT.APP.WebUI.Models
{
    public class UserLoginModel
    {
        [Required(ErrorMessage ="Username gereklidir")]
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
