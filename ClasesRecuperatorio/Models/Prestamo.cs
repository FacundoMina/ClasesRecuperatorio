using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesRecuperatorio.Models
{
    public class Prestamo
    {
        public int Id { get; set; }
        public int LibroId { get; set; }
        public int SocioId { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public Prestamo(int Id, int LibroId ,int SocioId, DateTime FechaPrestamo)
        {
            this.Id = Id;
            this.SocioId = SocioId;
            this.LibroId = LibroId;
            this.FechaPrestamo = DateTime.Today;
        }
    }
}
