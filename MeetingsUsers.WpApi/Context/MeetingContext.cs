using MeetingsUsers.WpApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MeetingsUsers.WpApi.Context
{
    public class MeetingContext: DbContext
    {
        public DbSet<User> Users { get; set; }

        public MeetingContext(DbContextOptions options)
        : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlite("Data Source=.\\DataBase\\UsersDb.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Seed();
        }
    }
}
