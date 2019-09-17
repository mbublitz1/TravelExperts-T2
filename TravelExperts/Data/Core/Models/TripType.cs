using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data.Core.Models
{
    public partial class TripType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TripType()
        {
            Bookings = new HashSet<Booking>();
        }

        [StringLength(1)]
        public string TripTypeId { get; set; }

        [StringLength(25)]
        public string TTName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
