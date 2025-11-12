using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesRecuperatorio.Models;
using Microsoft.EntityFrameworkCore;

namespace ClasesRecuperatorio.Data
{
    public class AplicationDbContext : DbContext
    {
        public DbSet<Libro> Libro { get; set; }
        public DbSet<Socio> Socio { get; set; }
        public DbSet<Prestamo> Prestamo { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=LAPTOP-B9HDS386;Database=ParcialDB;Trusted_Connection=True;TrustServerCertificate=True;"

            );
        }
    }
}
