using AccessControl.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace AccessControl.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<MvTicket> mvTickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<MvTicket>().HasIndex(c => c.Id).IsUnique();
        }
    }
}
