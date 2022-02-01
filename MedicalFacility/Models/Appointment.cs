namespace MedicalFacility.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Appointment")]
    public partial class Appointment
    {
        [Key]
        public int Appointment_ID { get; set; }

        public DateTime Appointment_datetime { get; set; }

        public int Patient_FID { get; set; }

        public int Schedule_FID { get; set; }

        public virtual Patient Patient { get; set; }

        public virtual Schedule Schedule { get; set; }
    }
}
