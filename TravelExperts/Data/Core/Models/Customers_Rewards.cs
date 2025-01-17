using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Core.Models
{
    public partial class Customers_Rewards
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RewardId { get; set; }

        [Required]
        [StringLength(25)]
        public string RwdNumber { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Reward Reward { get; set; }
    }
}
