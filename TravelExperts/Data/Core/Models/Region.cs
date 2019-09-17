using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data.Core.Models
{
    public partial class Region
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Region()
        {
            BookingDetails = new HashSet<BookingDetail>();
        }

        [StringLength(5)]
        public string RegionId { get; set; }

        [StringLength(25)]
        public string RegionName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookingDetail> BookingDetails { get; set; }
    }
}
