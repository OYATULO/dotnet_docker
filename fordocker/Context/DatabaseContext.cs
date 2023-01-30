using fordocker.Models;
using Microsoft.EntityFrameworkCore;

namespace fordocker.Context
{
    public class DatabaseContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string Connections = @"Data Source=DESKTOP-4959A24;Initial Catalog=SchoolDB;Integrated Security=True";
            optionsBuilder.UseSqlServer(Connections);
        }

        public DbSet<Students> Students { get; set; } 
    }
}
