using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code_360.Models
{
    public class StudentDbContext : IdentityDbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext>options) 
            : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}
