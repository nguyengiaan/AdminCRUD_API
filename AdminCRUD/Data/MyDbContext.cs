using AdminCRUD.Model;
using Microsoft.EntityFrameworkCore;

namespace AdminCRUD.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        { }
        #region
        public DbSet<Users> users { get; set; }
        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>().ToTable("Users");
            modelBuilder.Entity<Users>().Property(e => e.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Users>().Property(e => e.Name).HasMaxLength(255);
            modelBuilder.Entity<Users>().Property(e => e.Username).HasMaxLength(255);
            modelBuilder.Entity<Users>().Property(e => e.Password).HasMaxLength(255);
        }
    }
}
