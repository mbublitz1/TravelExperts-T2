using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

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
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public int CustomerId { get; set; }

        [Required]
        [StringLength(25)]
        [Display(Name = "First Name")]
        public string CustFirstName { get; set; }

        [Required]
        [StringLength(25)]
        [Display(Name = "Last Name")]
        public string CustLastName { get; set; }

        [Required]
        [StringLength(75)]
        [Display(Name = "Address")]
        public string CustAddress { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "City")]
        public string CustCity { get; set; }

        [Required]
        [StringLength(2)]
        [Display(Name = "Province")]
        public string CustProv { get; set; }

        [Required]
        [StringLength(7)]
        [Display(Name = "Postal Code")]
        public string CustPostal { get; set; }

        [StringLength(25)]
        [Display(Name = "Country")]
        public string CustCountry { get; set; }

        [StringLength(20)]
        [Display(Name = "Home Phone")]
        public string CustHomePhone { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Business Phone")]
        public string CustBusPhone { get; set; }

        [StringLength(128)]
        public string UserId { get; set; }
    }
}