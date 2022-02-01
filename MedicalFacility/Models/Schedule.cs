namespace MedicalFacility.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Schedule")]
    public partial class Schedule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Schedule()
        {
            Appointments = new HashSet<Appointment>();
        }

        [Key]
        public int Schedule_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Schedule_day { get; set; }

        public TimeSpan Schedule_Time { get; set; }

        [Column(TypeName = "date")]
        public DateTime Schedule_date { get; set; }

        [Required]
        [StringLength(50)]
        public string Schedule_Location { get; set; }

        public int Doctor_FID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Appointment> Appointments { get; set; }

        public virtual Doctor Doctor { get; set; }
    }
}
