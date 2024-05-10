using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class VersionContext : DbContext
    {
        public DbSet<SoftwareModelDb> SoftwareModel { get; set; }

        public VersionContext(DbContextOptions<VersionContext> options)
        : base(options)
        {
        }
    }

    public class SoftwareModelDb
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
    }
}
