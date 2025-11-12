using ClasesRecuperatorio.Data;
using ClasesRecuperatorio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesRecuperatorio.Repositories
{
    public class LibroRepository
    {
        public static void RegistrarLibro(Libro libro)
        {
            using (var context = new AplicationDbContext())
            {
                context.Libro.Add(libro);
                context.SaveChanges();
            }
        }

        public static List<Libro> ObtenerLibrosDisponibles()
        {
            using (var context = new AplicationDbContext())
            {
                return context.Libro
                    .Where(l => l.CantidadDisponible > 0)
                    .ToList();
            }
        }


    }
}


    
