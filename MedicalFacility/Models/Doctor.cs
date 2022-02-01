namespace MedicalFacility.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Doctor")]
    public partial class Doctor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Doctor()
        {
            Schedules = new HashSet<Schedule>();
        }

        [Key]
        public int Doctor_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Doctor_Name { get; set; }

        public int DEP_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Doctor_contact { get; set; }

        [Column(TypeName = "image")]
        [Required]
        public byte[] Doctor_img { get; set; }

        [Required]
        [StringLength(50)]
        public string Doctor_fee { get; set; }

        public virtual Department Department { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
