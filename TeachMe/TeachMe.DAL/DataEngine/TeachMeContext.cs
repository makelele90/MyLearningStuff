
using System.Data.Entity;
using TeachMe.DAL.Migrations;
using TeachMe.DataContainer.Data;

namespace TeachMe.DAL.DataEngine
{
  public class TeachMeContext:DbContext
  {
    public DbSet<User> Users { get; set; }
    public DbSet<UserProfile> UserProfiles { get; set; } 
    public TeachMeContext()
      : base("TeachMe")
    {
      Database.SetInitializer<TeachMeContext>(null);
     // Database.SetInitializer(new MigrateDatabaseToLatestVersion<TeachMeContext, Configuration>("TeachMe"));
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      modelBuilder.Entity<User>().Property(e => e.Username).HasMaxLength(250).IsRequired();
      modelBuilder.Entity<User>().Property(e => e.Password).HasMaxLength(250).IsRequired();
      modelBuilder.Entity<User>().Property(e => e.CreatedOn).IsRequired();
      base.OnModelCreating(modelBuilder);
    }
  }
}
