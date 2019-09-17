using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data.Core.Models
{
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            Products_Suppliers = new HashSet<Products_Suppliers>();
        }

        public int ProductId { get; set; }

        [Required]
        [StringLength(50)]
        public string ProdName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Products_Suppliers> Products_Suppliers { get; set; }
    }
}
