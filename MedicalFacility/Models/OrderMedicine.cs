namespace MedicalFacility.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderMedicine")]
    public partial class OrderMedicine
    {
        [Key]
        public int OrderMedicine_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string OrderQuantity { get; set; }

        public int Medicine_FID { get; set; }

        public int Order_FID { get; set; }

        public virtual Medicine Medicine { get; set; }

        public virtual Order Order { get; set; }
    }
}
