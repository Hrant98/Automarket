using System.ComponentModel.DataAnnotations;

namespace Automarket.Domain.ViewModels.Profile
{
    public class ProfileViewModel
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "Enter age")]
        [Range(0, 150, ErrorMessage = "Age range must be between 0 and 150")]
        public byte Age { get; set; }

        [Required(ErrorMessage = "Enter your address")]
        [MinLength(5, ErrorMessage = "The minimum length must be greater than 5 characters")]
        [MaxLength(200, ErrorMessage = "The maximum length must be less than 200 characters")]
        public string Address { get; set; }

        public string UserName { get; set; }

        public string NewPassword { get; set; }
    }
}