using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Context
{
    public class DataContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             
            string connection = @"Data Source=sql.bsite.net\MSSQL2016;Initial Catalog=oyatullo_db; User ID = oyatullo_db; Password = 1357986420; "; //Integrated Security = True
            optionsBuilder.UseSqlServer(connection);
        }
        public DbSet<Students> _Students { get; set; }
    }
}
