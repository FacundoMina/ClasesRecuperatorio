using ClasesRecuperatorio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesRecuperatorio.Repositories
{
    public class SocioRepository
    {
        public static void RegistrarSocio(Socio socio)
        {
            using (var context = new Data.AplicationDbContext())
            {

                context.Socio.Add(socio);
                context.SaveChanges();
            }
        }
      
        public static List<Socio> ObtenerSocios()
        {
            using (var context = new Data.AplicationDbContext())
            {
                return context.Socio.ToList();
            }
        }
    }
}

