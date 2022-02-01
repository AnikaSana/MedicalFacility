namespace MedicalFacility.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Feedback")]
    public partial class Feedback
    {
        [Key]
        public int Feedback_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Feedback_Description { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Rating { get; set; }

        public int Patient_FID { get; set; }

        [Column(TypeName = "date")]
        public DateTime Feedback_date { get; set; }

        public virtual Patient Patient { get; set; }
    }
}
