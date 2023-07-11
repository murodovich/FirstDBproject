using FirstDBproject.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDBproject.Data
{
    public class AppDBContext:DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            string path = "Server  = (localdb)\\MSSQLLocalDB;" +
                          "Database = StudyCenterDB;" +
                          "Trusted_Connection = True";
            optionsBuilder.UseSqlServer(path);
        }
    }
}
