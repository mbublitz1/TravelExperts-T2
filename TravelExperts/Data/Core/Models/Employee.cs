using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Core.Models
{
    public partial class Employee
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string EmpFirstName { get; set; }

        [StringLength(5)]
        public string EmpMiddleInitial { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string EmpLastName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string EmpBusPhone { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string EmpEmail { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(20)]
        public string EmpPosition { get; set; }
    }
}
