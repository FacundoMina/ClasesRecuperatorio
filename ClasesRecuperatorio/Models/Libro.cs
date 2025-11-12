namespace ClasesRecuperatorio.Models
{
    public class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int CantidadDisponible { get; set; }

        public Libro(int id, string titulo, string autor, int cantidadDisponible)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
            CantidadDisponible = cantidadDisponible;
        }
    }
}
