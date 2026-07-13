using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SistemaDeServicios.Modelos
{
    public class Direcciones
    {
        public int Id { get; set; }
        public string NombreDir { get; set; }

        public List<Departamentos> Departamentos { get; set; } = new();
        public List<Usuarios> Usuarios { get; set; } = new();
        public List<Equipos> Equipos { get; set; } = new();


    }

    public class Departamentos
    {
        public int Id { get; set; }
        public string NombreDep { get; set; }
        public Direcciones Direccion { get; set; }

        public int DirecionId { get; set; }
    }

    public class  Usuarios
    {
        public int Id { get; set; }
        public string User { get; set; }
        public Direcciones Direccion { get; set; }

        public int DirecionId { get; set; }
    }

    public class  Equipos
    {
        public int Id { get; set; }
        public string Detalles { get; set; }
        public Direcciones Direccion { get; set; }

        public int DirecionId { get; set; }
    }
}
