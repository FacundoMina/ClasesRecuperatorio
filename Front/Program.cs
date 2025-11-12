using ClasesRecuperatorio.Models;
using ClasesRecuperatorio.Repositories;

do
{
    Console.WriteLine("================================================");
    Console.WriteLine("\tMenu Principal");
    Console.WriteLine("================================================");
    Console.WriteLine();
    Console.WriteLine("1.Registrar Nuevo Libro");
    Console.WriteLine("2.Registrar Nuevo Socio");
    Console.WriteLine("3.Registrar Prestamo");
    Console.WriteLine("4.Mostrar Reporte de Prestamo por Socio");
    Console.WriteLine("5.Salir");
    Console.WriteLine();
    Console.Write("Seleccione una opcion: ");
    string opcion = Console.ReadLine();
    Console.Clear();

    if (opcion == "1")
    {
        Console.WriteLine("===============================================");
        Console.WriteLine("\tRegistro de Nuevo Libro");
        Console.WriteLine("===============================================");
        Console.WriteLine();
        Console.Write("Ingrese el Titulo del Libro: ");
        string titulo = Console.ReadLine();
        Console.Write("Ingrese el Autor del Libro: ");
        string autor = Console.ReadLine();
        Console.Write("Ingrese la Cantidad Disponible: ");
        int cantidadDisponible = int.Parse(Console.ReadLine());
        var nuevoLibro = new Libro(0, titulo, autor, cantidadDisponible);
        LibroRepository.RegistrarLibro(nuevoLibro);
        Console.WriteLine("Libro registrado exitosamente.");
    }
    if (opcion == "2")
    {
        Console.WriteLine("===============================================");
        Console.WriteLine("\tRegistro de Nuevo Socio");
        Console.WriteLine("===============================================");
        Console.WriteLine();
        Console.Write("Ingrese el Nombre del Socio: ");
        string nombre = Console.ReadLine();
        Console.Write("Ingrese el Apellido del Socio: ");
        string apellido = Console.ReadLine();
        Console.Write("Ingrese el DNI del Socio: ");
        string dni = Console.ReadLine();
        var nuevoSocio = new Socio(0, nombre, apellido, dni);
        SocioRepository.RegistrarSocio(nuevoSocio);
        Console.WriteLine("Socio registrado exitosamente.");
    }
    if (opcion == "3")
    {
        Console.WriteLine("===============================================");
        Console.WriteLine("\tRegistro de Nuevo Prestamo");
        Console.WriteLine("===============================================");
        Console.WriteLine();
        Console.Write("Ingrese el ID del Socio: ");
        int socioId = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el ID del Libro: ");
        int libroId = int.Parse(Console.ReadLine());
        var socio = SocioRepository.ObtenerSocios().FirstOrDefault(s => s.Id == socioId);
        var libro = LibroRepository.ObtenerLibrosDisponibles().FirstOrDefault(l => l.Id == libroId);
        if (socio == null || libro == null)
        {
            Console.WriteLine("Socio o Libro no encontrado.");
        }
        else
        {
            var nuevoPrestamo = new Prestamo(0, libro.Id, socio.Id, DateTime.Today);
            PrestamoRepository.RegistrarPrestamo(nuevoPrestamo);
            Console.WriteLine("Prestamo registrado exitosamente.");
        }
    }
    if (opcion == "4") 
    {
        Console.WriteLine("===============================================");
        Console.WriteLine("\tReporte de Prestamos por Socio");
        Console.WriteLine("===============================================");
        Console.WriteLine();
        Console.Write("Ingrese el ID del Socio: ");
        int socioId = int.Parse(Console.ReadLine());
        foreach (var socio in SocioRepository.ObtenerSocios())
        {
            if (socio.Id == socioId) 
            {
                Console.WriteLine($"Prestamos del Socio: {socio.Nombre} {socio.Apellido}");
                
            }
        }
        PrestamoRepository.MostrarPrestamosPorSocio(socioId);

    }
   
    if (opcion == "5") 
    {
        break;
    }
    if (opcion != "1" && opcion != "2" && opcion != "3" && opcion != "4" && opcion != "5") 
    {
        Console.WriteLine("Opcion no valida. Intente nuevamente.");
    }


} while (true);
