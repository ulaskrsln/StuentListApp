using EF_Test.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_Test.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<StudentModel> Students { get; set; }
    }
}
