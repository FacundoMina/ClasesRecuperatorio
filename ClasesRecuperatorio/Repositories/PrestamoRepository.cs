using ClasesRecuperatorio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesRecuperatorio.Repositories
{
    public class PrestamoRepository
    {
        //Un prestamo debe asociar un socio con uno o mas libros.
        //Debe disminuir la cantidad de libros disponibles al momento de realizar el prestamo.
        public static void RegistrarPrestamo(Prestamo prestamo)
        {
            using (var context = new Data.AplicationDbContext())
            {
                context.Prestamo.Add(prestamo);
                // Disminuir la cantidad de libros disponibles
                var libro = context.Libro.FirstOrDefault(l => l.Id == prestamo.LibroId);
                if (libro != null && libro.CantidadDisponible > 0)
                {
                    libro.CantidadDisponible--;
                }
                context.SaveChanges();
            }
        }

        public static void MostrarPrestamosPorSocio(int socioId)
        {
            using (var context = new Data.AplicationDbContext())
            {
                var prestamos = context.Prestamo
                    .Where(p => p.SocioId == socioId)
                    .ToList();
                foreach (var prestamo in prestamos)
                {
                    
                    var libro = context.Libro.Find(prestamo.LibroId);
                    Console.WriteLine($"Prestamo ID: {prestamo.Id}, Libro: {libro?.Titulo},Autor:{libro.Autor},Fecha de Prestamo: {prestamo.FechaPrestamo}");

                }
            }
        }
    }
}




