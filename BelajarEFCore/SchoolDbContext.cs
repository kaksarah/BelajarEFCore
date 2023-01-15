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

        // menciptakan properti bernama Students(kata ke 4) dengan tipe DbSet
        // yang mewaliki keleksi object Students(kata ke 3) didalam database
        // modifier public agar bisa di akses dari mana saja dalam aplikasi
        // digunakan untuk membuat table Students dalam database dan melakukan operasi CRUD
        public DbSet<Students> Students { get; set; }

        // kode untuk mengkonfigurasi koneksi data SQL Server menggunakan entity framework core
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=LENOVO-PC\\SQLEXPRESS; Database=SchoolDB3; Trusted_Connection = True; TrustServerCertificate = True;";
            optionsBuilder.UseSqlServer(connectionString);
        }


    }
}
