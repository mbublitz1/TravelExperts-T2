using System.ComponentModel.DataAnnotations;

namespace Data.Core.ViewModel
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public int CustomerId { get; set; }

        [Required]
        [StringLength(25)]
        public string CustFirstName { get; set; }

        [Required]
        [StringLength(25)]
        public string CustLastName { get; set; }

        [Required]
        [StringLength(75)]
        public string CustAddress { get; set; }

        [Required]
        [StringLength(50)]
        public string CustCity { get; set; }

        [Required]
        [StringLength(2)]
        public string CustProv { get; set; }

        [Required]
        [StringLength(7)]
        public string CustPostal { get; set; }

        [StringLength(25)]
        public string CustCountry { get; set; }

        [StringLength(20)]
        public string CustHomePhone { get; set; }

        [Required]
        [StringLength(20)]
        public string CustBusPhone { get; set; }

        [Required]
        [StringLength(50)]
        public string CustEmail { get; set; }

        [StringLength(128)]
        public string UserId { get; set; }
    }
}