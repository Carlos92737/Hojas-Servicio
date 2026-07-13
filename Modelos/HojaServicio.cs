namespace SistemaDeServicios.Modelos
{
    public class HojaServicio
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Departamento { get; set; }
        public string Usuario { get; set; }
        public string Caracteristicas { get; set; }
        public string Descripcion { get; set; }
        public string Sugerencias { get; set; }

        public List<TipoServicio> Servicios { get; set; } = new();

        public List<Etiqueta> Etiquetas { get; set; } = new();

        public HojaServicio()
        {
            Nombre = "";
            Direccion = "";
            Departamento = "";
            Usuario = "";
            Caracteristicas = "";
            Descripcion = "";
            Sugerencias = "";
        }
    }

    public class Etiqueta
    {
        public int Id { get; set; }
        public string Texto { get; set; }

        public List<HojaServicio> HojasDeServicio { get; set; } = new();


        public Etiqueta()
        {
        }
        public Etiqueta(string texto)
        {
            Texto = texto;
        }
    }
}
