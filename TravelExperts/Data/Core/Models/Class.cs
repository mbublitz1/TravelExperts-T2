using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data.Core.Models
{
    public partial class Class
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Class()
        {
            BookingDetails = new HashSet<BookingDetail>();
        }

        [StringLength(5)]
        public string ClassId { get; set; }

        [Required]
        [StringLength(20)]
        public string ClassName { get; set; }

        [StringLength(50)]
        public string ClassDesc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookingDetail> BookingDetails { get; set; }
    }
}
