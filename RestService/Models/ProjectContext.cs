using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace RestService.Models
{
    public class ProjectContext : DbContext
    {

        public ProjectContext() : base("ProjectContext")
        {
        }
        public DbSet<MainRequest> mainRequests { get; set; }
        public DbSet<Request> requests { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}