using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace MedicalFacility.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Medicine> Medicines { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderMedicine> OrderMedicines { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Admin)
                .HasForeignKey(e => e.Admin_FID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.Doctors)
                .WithRequired(e => e.Department)
                .HasForeignKey(e => e.DEP_ID)
                .WillCascadeOnDelete(false);


            modelBuilder.Entity<Doctor>()
                .HasMany(e => e.Schedules)
                .WithRequired(e => e.Doctor)
                .HasForeignKey(e => e.Doctor_FID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Feedback>()
                .Property(e => e.Rating)
                .HasPrecision(18, 1);

            modelBuilder.Entity<Medicine>()
                .HasMany(e => e.OrderMedicines)
                .WithRequired(e => e.Medicine)
                .HasForeignKey(e => e.Medicine_FID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderMedicines)
                .WithRequired(e => e.Order)
                .HasForeignKey(e => e.Order_FID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Patient>()
                .HasMany(e => e.Appointments)
                .WithRequired(e => e.Patient)
                .HasForeignKey(e => e.Patient_FID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Patient>()
                .HasMany(e => e.Feedbacks)
                .WithRequired(e => e.Patient)
                .HasForeignKey(e => e.Patient_FID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Patient>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Patient)
                .HasForeignKey(e => e.Patient_FID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Schedule>()
                .HasMany(e => e.Appointments)
                .WithRequired(e => e.Schedule)
                .HasForeignKey(e => e.Schedule_FID)
                .WillCascadeOnDelete(false);
        }
    }
}
