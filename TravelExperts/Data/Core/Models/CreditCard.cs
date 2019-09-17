using System;
using System.ComponentModel.DataAnnotations;

namespace Data.Core.Models
{
    public partial class CreditCard
    {
        public int CreditCardId { get; set; }

        [Required]
        [StringLength(10)]
        public string CCName { get; set; }

        [Required]
        [StringLength(50)]
        public string CCNumber { get; set; }

        public DateTime CCExpiry { get; set; }

        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
