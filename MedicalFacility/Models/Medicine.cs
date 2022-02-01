namespace MedicalFacility.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Medicine")]
    public partial class Medicine
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Medicine()
        {
            OrderMedicines = new HashSet<OrderMedicine>();
        }

        [Key]
        public int Medicine_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Medicine_Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Medicine_Brand { get; set; }

        [Required]
        [StringLength(50)]
        public string Medicine_Weight { get; set; }

        [Required]
        public string Medicine_image { get; set; }

        [Required]
        [StringLength(50)]
        public string Medicine_Price { get; set; }

        public int Order_FID { get; set; }

        [Required]
        [StringLength(50)]
        public string Medicine_detail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderMedicine> OrderMedicines { get; set; }
    }
}
