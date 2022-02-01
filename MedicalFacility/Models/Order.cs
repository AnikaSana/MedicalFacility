namespace MedicalFacility.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            OrderMedicines = new HashSet<OrderMedicine>();
        }

        [Key]
        public int Order_ID { get; set; }

        public DateTime Order_Date { get; set; }

        public int Patient_FID { get; set; }

        public int Admin_FID { get; set; }

        [Required]
        [StringLength(50)]
        public string Order_Status { get; set; }

        [Required]
        [StringLength(50)]
        public string Payment_Mode { get; set; }

        [Required]
        [StringLength(50)]
        public string Order_Quantity { get; set; }

        public int Medicine_FID { get; set; }

        public virtual Admin Admin { get; set; }

        public virtual Patient Patient { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderMedicine> OrderMedicines { get; set; }
    }
}
