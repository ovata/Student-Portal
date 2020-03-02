using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code_360.Models
{
    public class StudentDbContext : IdentityDbContext<IdentityUser>
    {
        public StudentDbContext(DbContextOptions<StudentDbContext>options) 
            : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Batch.Batch> Batches { get; set; }
        public DbSet<Programs.Programme> Programmes { get; set; }
        public DbSet<Course.Course> Courses { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentDetails> PaymentDetails { get; set; }
        public DbSet<ProgrammeCourse> ProgrammeCourses { get; set; }
        public DbSet<Guarantor.Guarantor> Guarantors { get; set; }
        public DbSet<StudentGuarantor> StudentGuarantors { get; set; }
        public DbSet<StudentBatch> StudentBatches { get; set; }
        public DbSet<EmploymentDetails> EmploymentDetails { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<StudentBatch>()
                .HasKey(sb => new { sb.StudentId, sb.BatchId });

            builder.Entity<StudentBatch>()
                .HasOne(sb => sb.Student)
                .WithMany(s => s.StudentBatches)
                .HasForeignKey(sb => sb.StudentId);

            builder.Entity<StudentBatch>()
                .HasOne(sb => sb.Batch)
                .WithMany(b => b.StudentBatches)
                .HasForeignKey(sb => sb.BatchId);

        }
    }
}
