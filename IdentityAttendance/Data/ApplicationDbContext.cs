using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using IdentityAttendance.Models.Entities;

namespace IdentityAttendance.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }
            public DbSet<Attendance> Attendance { get; set; }
            public DbSet<Student> Students { get; set; }
    }
}


