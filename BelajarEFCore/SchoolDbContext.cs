using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelajarEFCore
{

    public class SchoolDbContext : DbContext
    {
        // orm itu object relational mapping, adalah teknik untuk membuat suatu table menjadi object. 

        public DbSet<Students> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=LENOVO-PC\\SQLEXPRESS; Database=SchoolDB3; Trusted_Connection = True; TrustServerCertificate = True;";
            optionsBuilder.UseSqlServer(connectionString);
        }


    }
}
