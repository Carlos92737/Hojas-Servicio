namespace SistemaDeServicios.Modelos
{
    public class TipoServicio
    {
        public int Id { get; set; }
        public string Texto { get; set; }
        public bool Recurrente { get; set; }

        public List<HojaServicio> Hojas { get; set; } = new();

        public TipoServicio()
        {
            Texto = "";
            Recurrente = false;
        }
    }
}
