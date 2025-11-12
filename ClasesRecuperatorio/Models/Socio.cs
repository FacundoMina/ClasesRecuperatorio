using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesRecuperatorio.Models
{
    public class Socio
    {
       public int Id { get; set; }
        public string Nombre { get; set; }
       public string Apellido { get; set; }
       public string Dni { get; set; }
        
        public Socio(int id, string nombre, string apellido, string dni)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
        }
    }
}
