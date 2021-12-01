using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCodeFirstApproachApplication.Models
{
    public class ApplicationDBContext : DbContext
    {
        private const string ConnectionString = "Server=(LocalDB)\\MSSQLLocalDB;Database=DemoDB;Integrated Security=true";

        public DbSet<User> Users { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
            //optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Database=DemoDB;login=;password=");
        }
    }
}
