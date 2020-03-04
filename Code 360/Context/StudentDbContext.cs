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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Many to many relationship for Student and Batch
            modelBuilder.Entity<StudentBatch>()
                .HasKey(sb => new { sb.StudentId, sb.BatchId });

            modelBuilder.Entity<StudentBatch>()
                .HasOne(sb => sb.Student)
                .WithMany(s => s.StudentBatches)
                .HasForeignKey(sb => sb.StudentId);

            modelBuilder.Entity<StudentBatch>()
                .HasOne(sb => sb.Batch)
                .WithMany(b => b.StudentBatches)
                .HasForeignKey(sb => sb.BatchId);

            //Many to many relationship for Student and Guarantor
            modelBuilder.Entity<StudentGuarantor>()
                .HasKey(sg => new { sg.StudentId, sg.GuarantorId });

            modelBuilder.Entity<StudentGuarantor>()
                .HasOne(ss => ss.Student)
                .WithMany(s => s.StudentGuarantors)
                .HasForeignKey(ss => ss.StudentId);

            modelBuilder.Entity<StudentGuarantor>()
                .HasOne(gg => gg.Guarantor)
                .WithMany(g => g.StudentGuarantors)
                .HasForeignKey(gg => gg.GuarantorId);

            //Many to many relationship for Program and Course
            modelBuilder.Entity<ProgrammeCourse>()
                .HasKey(pc => new { pc.CourseId, pc.ProgrammeId });

            modelBuilder.Entity<ProgrammeCourse>()
                .HasOne(pc => pc.Programme)
                .WithMany(p => p.ProgrammeCourses)
                .HasForeignKey(pc => pc.ProgrammeId);

            modelBuilder.Entity<ProgrammeCourse>()
                .HasOne(pc => pc.Course)
                .WithMany(c => c.ProgrammeCourses)
                .HasForeignKey(pc => pc.CourseId);

            //Many to many relationship for Student and Company
            modelBuilder.Entity<EmploymentDetails>()
                .HasKey(ed => new { ed.StudentId, ed.CompanyId });

            modelBuilder.Entity<EmploymentDetails>()
                .HasOne(ss => ss.Student)
                .WithMany(s => s.EmploymentDetails)
                .HasForeignKey(ss => ss.StudentId);

            modelBuilder.Entity<EmploymentDetails>()
                .HasOne(cc => cc.Student)
                .WithMany(c => c.EmploymentDetails)
                .HasForeignKey(cc => cc.CompanyId);

            //Many to many relationship for Student and Course
            modelBuilder.Entity<StudentCourse>()
                .HasKey(sc => new { sc.CourseId, sc.StudentId });

            modelBuilder.Entity<StudentCourse>()
                .HasOne(ss => ss.Student)
                .WithMany(s => s.StudentCourses)
                .HasForeignKey(ss => ss.StudentId);

            modelBuilder.Entity<StudentCourse>()
                .HasOne(cc => cc.Course)
                .WithMany(c => c.StudentCourses)
                .HasForeignKey(cc => cc.CourseId);
        }
    }
}
