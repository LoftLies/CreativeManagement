using CMDataManager.Models;
using Microsoft.EntityFrameworkCore;

namespace CMDataManager.Data
{
    public class CreativeManagerContext : DbContext
    {
        public CreativeManagerContext(DbContextOptions<CreativeManagerContext> opt) : base(opt)
        {

        }

        public DbSet<Project> Projects { get; set; }
    }
}
