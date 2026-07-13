using Microsoft.EntityFrameworkCore;
using SistemaDeServicios.Modelos;
using System.Diagnostics;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace SistemaDeServicios.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<HojaServicio> HojasDeServicio { get; set; }

        public DbSet<Direcciones> Direcciones { get; set; }
        public DbSet<Departamentos> Departamentos { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Equipos> Equipos { get; set; }

        public DbSet<TipoServicio> TiposDeServicios { get; set; }

        public DbSet<Etiqueta> Etiquetas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<HojaServicio>()
                .HasMany(h => h.Etiquetas)
                .WithMany(e => e.HojasDeServicio)
                .UsingEntity(j => j.ToTable("HojaServicioEtiqueta"));

            modelBuilder.Entity<Direcciones>().HasData(
                new Direcciones { Id = 1, NombreDir = "Despacho del Alcalde" },
                new Direcciones { Id = 2, NombreDir = "Dirección General" },
                new Direcciones { Id = 3, NombreDir = "Asuntos Públicos" },
                new Direcciones { Id = 4, NombreDir = "Atención al Ciudadano" },
                new Direcciones { Id = 5, NombreDir = "Prensa y Ciudadano" },
                new Direcciones { Id = 6, NombreDir = "Gestión Urbana" },
                new Direcciones { Id = 7, NombreDir = "Obras" },
                new Direcciones { Id = 8, NombreDir = "Servicios Generales" },
                new Direcciones { Id = 9, NombreDir = "Planeamiento Urbano" },
                new Direcciones { Id = 10, NombreDir = "Catastro" },
                new Direcciones { Id = 11, NombreDir = "Seguridad Ciudadana" },
                new Direcciones { Id = 12, NombreDir = "Protección Civil" },
                new Direcciones { Id = 13, NombreDir = "Gestión Social" },
                new Direcciones { Id = 14, NombreDir = "CMDNNA" },
                new Direcciones { Id = 15, NombreDir = "Administración y Finanzas" },
                new Direcciones { Id = 16, NombreDir = "Planificación de Presupuesto" },
                new Direcciones { Id = 17, NombreDir = "Recursos Humanos" },
                new Direcciones { Id = 18, NombreDir = "Administración Tributaria" },
                new Direcciones { Id = 19, NombreDir = "Tecnología y Sistemas" },
                new Direcciones { Id = 20, NombreDir = "Deportes" },
                new Direcciones { Id = 21, NombreDir = "IMASUR" },
                new Direcciones { Id = 22, NombreDir = "Registro Civil" },
                new Direcciones { Id = 23, NombreDir = "Tesorería Municipal" },
                new Direcciones { Id = 24, NombreDir = "Sindicatura Municipal" },
                new Direcciones { Id = 25, NombreDir = "Cultura" },
                new Direcciones { Id = 26, NombreDir = "Instituto Municipal de la Vivienda" },
                new Direcciones { Id = 27, NombreDir = "Consultoría Jurídica" },
                new Direcciones { Id = 28, NombreDir = "Cámara Municipal" }
            );

            modelBuilder.Entity<TipoServicio>().HasData(
                new TipoServicio { Id = 1, Texto = "Mantenimiento de Impresora", Recurrente = true },
                new TipoServicio { Id = 2, Texto = "Formateo de Equipo", Recurrente = true },
                new TipoServicio { Id = 3, Texto = "Mantenimiento preventivo y/o correctivo", Recurrente = true },
                new TipoServicio { Id = 4, Texto = "Instalación y Actualización de Software", Recurrente = true },
                new TipoServicio { Id = 5, Texto = "Instalación y/o Configuración de Impresora", Recurrente = true },
                new TipoServicio { Id = 6, Texto = "Instalación de Dispositivos Internos del CPU", Recurrente = true },
                new TipoServicio { Id = 7, Texto = "Configuración del Sistema Operativo", Recurrente = true },
                new TipoServicio { Id = 8, Texto = "Respaldo de Información", Recurrente = true },
                new TipoServicio { Id = 9, Texto = "Configuración de Red", Recurrente = true }
            );

            modelBuilder.Entity<Etiqueta>().HasData(
                new Etiqueta { Id = 1, Texto = "Cambio de toner" },
                new Etiqueta { Id = 2, Texto = "Reconexión de impresora" },
                new Etiqueta { Id = 3, Texto = "Instalación de impresora" },
                new Etiqueta { Id = 4, Texto = "Reconexión de internet" },
                new Etiqueta { Id = 5, Texto = "Asistencia técnica a PC" },
                new Etiqueta { Id = 6, Texto = "Gestión de cuenta de correo" },
                new Etiqueta { Id = 7, Texto = "Proceso de respaldo de información" },
                new Etiqueta { Id = 8, Texto = "Instalación de antivirus" },
                new Etiqueta { Id = 9, Texto = "Desinstalación de software" },
                new Etiqueta { Id = 10, Texto = "Cableado estructurado" },
                new Etiqueta { Id = 11, Texto = "Creación de cuenta de correo" },
                new Etiqueta { Id = 12, Texto = "Instalación de impresora" },
                new Etiqueta { Id = 13, Texto = "Configuración de impresora" },
                new Etiqueta { Id = 14, Texto = "Inducción de uso de correos" },
                new Etiqueta { Id = 15, Texto = "Inducción de uso de software" },
                new Etiqueta { Id = 16, Texto = "Sustitución de hardware" },
                new Etiqueta { Id = 17, Texto = "Limpieza de memoria RAM" },
                new Etiqueta { Id = 18, Texto = "Inducción de uso de correos" },
                new Etiqueta { Id = 19, Texto = "Inducción de uso de software" },
                new Etiqueta { Id = 20, Texto = "Instalación de software" },
                new Etiqueta { Id = 21, Texto = "Activación de licencia de software" },
                new Etiqueta { Id = 22, Texto = "Instalación de Sistema Operativo" },
                new Etiqueta { Id = 23, Texto = "Activación de licencia de Sistema Operativo" }
            );

        }
    }


    public class DireccionesService
    {
        private readonly ApplicationDbContext _context;

        public DireccionesService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Direcciones>> ObtenerDirecciones()
        {
            return await _context.Direcciones
                .OrderBy(d => d.NombreDir)
                .ToListAsync();
        }
    }
    public class  DepartamentosService
    {
        private readonly ApplicationDbContext _context;

        public DepartamentosService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AgregarDepartamento(string direccion, string nombreDepartamento)
        {
            var dir = await _context.Direcciones.FirstOrDefaultAsync(d => d.NombreDir == direccion);
            if (dir != null)
            {
                var departamento = new Departamentos { NombreDep = nombreDepartamento, DirecionId = dir.Id, Direccion = dir };
                _context.Departamentos.Add(departamento);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Departamentos>> BuscarDepartamentos()
        {
            var departamentos = await _context.Departamentos
                .Include(dep => dep.Direccion)
                .OrderBy(dep => dep.Direccion.NombreDir)
                .ToListAsync();
            return departamentos;
        }

        public async Task ModificarDepartamento(Departamentos departamento)
        {
            var original = await _context.Departamentos
            .Include(d => d.Direccion)
            .FirstOrDefaultAsync(d => d.Id == departamento.Id);

            if (original == null) return;

            // Actualizar solo lo necesario
            original.NombreDep = departamento.NombreDep;
            original.Direccion = departamento.Direccion;

            await _context.SaveChangesAsync();
        }
    }
    public class UsuariosService
    {
        private readonly ApplicationDbContext _context;
        public UsuariosService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AgregarUsuario(string direccion, string nombreUsuario)
        {
            var dir = await _context.Direcciones.FirstOrDefaultAsync(d => d.NombreDir == direccion);
            if (dir != null)
            {
                var usuario = new Usuarios { User = nombreUsuario, DirecionId = dir.Id, Direccion = dir};
                _context.Usuarios.Add(usuario);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Usuarios>> BuscarUsuarios()
        {
            return await _context.Usuarios
                .Include(u => u.Direccion)
                .OrderBy(u => u.Direccion.NombreDir)
                .ToListAsync();
        }

        public async Task ModificarUsuario(Usuarios usuario)
        {
            var original = await _context.Usuarios
            .Include(u => u.Direccion)
            .FirstOrDefaultAsync(u => u.Id == usuario.Id);

            if (original == null) return;

            // Actualizar solo lo necesario
            original.User = usuario.User;
            original.Direccion = usuario.Direccion;

            await _context.SaveChangesAsync();
        }
    }
    public class TipoServicioService
    {
        private readonly ApplicationDbContext _context;

        public TipoServicioService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<TipoServicio>> ObtenerTiposServicio()
        {
            return await _context.TiposDeServicios
                .OrderBy(t => t.Id)
                .ToListAsync();
        }

        public async Task<List<TipoServicio>> ObtenerTiposServicioFiltrados()
        {
            return await _context.TiposDeServicios
                .Where(t => t.Recurrente == true)
                .OrderBy(t => t.Id)
                .ToListAsync();
        }

        public async Task AgregarServicio(TipoServicio servicio)
        {
            _context.TiposDeServicios.Add(servicio);
            await _context.SaveChangesAsync();
        }
    }


    public class HojaServicioService
    {
        private readonly ApplicationDbContext _context;

        public HojaServicioService(ApplicationDbContext context)
        {
            _context = context;
        }

        // Método para contar el número de hojas existentes
        public async Task<int> ContarHojas()
        {
            return await _context.HojasDeServicio.CountAsync();
        }

        // Método para crear una nueva hoja de servicio
        public async Task Crear(HojaServicio hoja)
        {
            _context.HojasDeServicio.Add(hoja);
            await _context.SaveChangesAsync();
        }

        // Método para modificar solo la etiqueta de una hoja de servicio
        public async Task Modificar(HojaServicio hoja)
        {
            var original = await _context.HojasDeServicio
            .Include(h => h.Servicios)
            .Include(h => h.Etiquetas)
            .FirstOrDefaultAsync(h => h.Id == hoja.Id);

            if (original == null) return;

            // Actualizar solo lo necesario
            original.Etiquetas = hoja.Etiquetas;

            await _context.SaveChangesAsync();
        }

        // Método para generar el PDF de la hoja de servicio
        public async Task GenerarPdf(HojaServicio hoja, List<TipoServicio> tiposServicio)
        {
            var documento = new HojaDocumento(hoja, tiposServicio);
            documento.GeneratePdfAndShow();
            // Lógica para generar el PDF
        }

        // Método para obtener hojas de servicio de un mes específico
        public async Task<List<HojaServicio>> ObtenerHojasMensual(int mes, int ano)
        {
            return await _context.HojasDeServicio
                .Where(h => h.Fecha.Month == mes && h.Fecha.Year == ano)
                .Include(h => h.Servicios)
                .Include(h => h.Etiquetas)
                .ToListAsync();
        }

        // Método para obtener hojas de servicio dentro de un rango de meses y años dados
        public async Task<List<HojaServicio>> ObtenerHojas(int mesi, int mesf, int anoi, int anof)
        {
            return await _context.HojasDeServicio
                .Where(h => (h.Fecha.Month >= mesi && h.Fecha.Month <= mesf) && (h.Fecha.Year >= anoi && h.Fecha.Year <= anof))
                .Include(h => h.Servicios)
                .Include(h => h.Etiquetas)
                .ToListAsync();
        }

        // Método para obtener hojas de servicio pendientes (sin etiqueta) dentro de un rango de meses y años dados
        public async Task<List<HojaServicio>> ObtenerHojasPendientes(int mesi, int mesf, int anoi, int anof)
        {
            return await _context.HojasDeServicio
                .Where(h => (h.Fecha.Month >= mesi && h.Fecha.Month <= mesf) && (h.Fecha.Year >= anoi && h.Fecha.Year <= anof) && h.Etiquetas.Count == 0)
                .Include(h => h.Servicios)
                .ToListAsync();
        }

        // Metodo para buscar una hoja por su id
        public async Task<HojaServicio> ObtenerHoja(int id)
        {
            return await _context.HojasDeServicio
                .Include(h => h.Servicios)
                .Include(h => h.Etiquetas)
                .FirstOrDefaultAsync(h => h.Id == id);
        }

        public async Task<List<HojaServicio>> ObtenerHojasPorFiltro(DateTime fechaIni, DateTime fechaFin, string direccion)
        {
            if (direccion == "!")
            {
                return await _context.HojasDeServicio
                    .Where(h => h.Fecha >= fechaIni && h.Fecha <= fechaFin)
                    .Include(h => h.Servicios)
                    .Include(h => h.Etiquetas)
                    .ToListAsync();
            }

            return await _context.HojasDeServicio
                .Where(h => h.Fecha >= fechaIni && h.Fecha <= fechaFin && h.Direccion == direccion)
                .Include(h => h.Servicios)
                .Include(h => h.Etiquetas)
                .ToListAsync();
        }

        // Metodo para revisar las hojas de cada mes para el calendario
        public async Task<int> RevisarConteo(int mes)
        {
            var hojasSinEtiqueta = await _context.HojasDeServicio
                .Where(h => h.Fecha.Month == mes &&
                    h.Fecha.Year == DateTime.Now.Year &&
                    h.Etiquetas.Count == 0)
                .ToListAsync();

            var totalHojas = await _context.HojasDeServicio
                .Where(h => h.Fecha.Month == mes &&
                            h.Fecha.Year == DateTime.Now.Year)
                .CountAsync();

            if (totalHojas == hojasSinEtiqueta.Count)
                return 0; // mes sin etiquetar → pendiente

            if (hojasSinEtiqueta.Count == 0)
                return 2; // completo

            return 1; // incompleto
        }
    }
    public class EtiquetasService
    {
        private readonly ApplicationDbContext _context;

        public EtiquetasService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AgregarEtiqueta(Etiqueta etiqueta)
        {
            _context.Etiquetas.Add(etiqueta);
            await _context.SaveChangesAsync();
        }

        public async Task ModificarEtiqueta(Etiqueta etiqueta)
        {
            var original = await _context.Etiquetas
             .Include(e => e.HojasDeServicio)
             .FirstOrDefaultAsync(e => e.Id == etiqueta.Id);

            if (original == null) return;

            // Actualizar solo lo necesario
            original.Texto = etiqueta.Texto;
            original.HojasDeServicio.Clear();

            await _context.SaveChangesAsync();
        }

        public async Task<List<Etiqueta>> ObtenerEtiquetas()
        {
            return await _context.Etiquetas
                .OrderBy(e => e.Id)
                .ToListAsync();
        }
    }



    public class HojaDocumento : IDocument
    {
        private readonly HojaServicio _hoja;
        private readonly List<TipoServicio> _servicios;

        public HojaDocumento(HojaServicio hoja, List<TipoServicio> servicios)
        {
            _hoja = hoja;
            _servicios = servicios;
        }
        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;

        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                page.Size(PageSizes.A4);
                page.Margin(2, Unit.Centimetre);

                page.Header().Height(105).Element(ComposeHeader);
                page.Content().Element(ComposeContent);
                page.Footer().Height(64).Element(ComposeFooter);
            });
        }

        private void ComposeHeader(IContainer container)
        {
            container.DefaultTextStyle(x => x.LineHeight(1.5f)).Row(row =>
            {
                row.RelativeItem().Column(column =>
                {
                    column.Item().Text("Dirección De Tecnología Y Sistemas").FontSize(20).Bold().FontColor(Colors.Blue.Darken4);
                    column.Item().Text($"Hoja De Servicio #{_hoja.Id}").FontSize(18).Bold().FontColor(Colors.Blue.Darken4);
                    column.Item().Text($"Fecha: {_hoja.Fecha:dd/MM/yyyy}").FontSize(16);
                });
                row.ConstantItem(100).Image("wwwroot/logo-alcaldia.png");
            });
        }

        private void ComposeContent(IContainer container)
        {

            container.DefaultTextStyle(x => x.FontSize(14).LineHeight(1.5f)).Column(column =>
            {
                column.Item().Element(Seccion).Text(" ").FontSize(1);

                column.Item().PaddingVertical(15).Column(column =>
                { 
                    column.Item().AlignCenter().Text("Detalles Del Solicitante").FontSize(18).Bold().LineHeight(2f);
                    column.Item().AlignLeft().Text($"Nombre: {_hoja.Nombre}");
                    column.Item().Text($"Dirección: {_hoja.Direccion}");
                    column.Item().Text($"Departamento: {_hoja.Departamento}");
                    column.Item().Text($"Usuario: {_hoja.Usuario}");
                });

                column.Item().Element(Seccion).Text(" ").FontSize(1);

                column.Item().PaddingVertical(15).Column(column =>
                {
                    column.Item().AlignCenter().Text("Detalles Del Servicio").FontSize(18).Bold().LineHeight(2f);
                    column.Item().AlignLeft().Text($"Características del equipo: {_hoja.Caracteristicas}");
                    column.Item().Text($"Tipo de servicio(s): ");
                    foreach (var servicio in _servicios)
                    {
                        if (_hoja.Servicios.Contains(servicio))
                        {
                            column.Item().Text($"◈ {servicio.Texto}").LineHeight(1.3f).ParagraphFirstLineIndentation(5);
                        }
                        else
                        {
                            column.Item().Text($"◇ {servicio.Texto}").LineHeight(1.3f).ParagraphFirstLineIndentation(5).FontColor(Colors.Grey.Medium);
                        }
                    }
                    if (_hoja.Servicios.Any(s => s.Recurrente == false))
                    {
                        column.Item().Text($"◈ Otro: {_hoja.Servicios.First(s => s.Recurrente == false).Texto}").LineHeight(1.3f).ParagraphFirstLineIndentation(5);
                    }
                    else
                    {
                        column.Item().Text($"◇ Otro:").LineHeight(1.3f).ParagraphFirstLineIndentation(5).FontColor(Colors.Grey.Medium);
                    }

                    column.Item().Text(" ").FontSize(10).LineHeight(1.2f);
                    column.Item().Text($"Descripción del servicio: {_hoja.Descripcion}").LineHeight(1.1f).ParagraphSpacing(25);
                    column.Item().Text(" ").FontSize(5).LineHeight(1f);
                    column.Item().Text($"Sugerencias técnicas: {_hoja.Sugerencias}").LineHeight(1.1f).ParagraphSpacing(25);
                });

                static IContainer Seccion(IContainer container)
                {
                    return container.BorderBottom(3).BorderColor(Colors.Blue.Darken4);
                }
            });
        }

        private void ComposeFooter(IContainer container)
        {
            container.DefaultTextStyle(X => X.FontSize(16).Bold()).Row(row =>
            {
                row.Spacing(100);

                row.RelativeItem().Column(column =>
                {
                    column.Item().Text("Elaborado por: ");
                    column.Item().Element(FirmaEstilo).Text(" ").FontSize(32);
                });

                row.RelativeItem().Column(column =>
                {
                    column.Item().Text("Aceptado por: ");
                    column.Item().Element(FirmaEstilo).Text(" ").FontSize(32);
                });

                static IContainer FirmaEstilo(IContainer container)
                {
                    return container.BorderBottom(1).BorderColor(Colors.Blue.Darken4);
                }
            });
        }
    }
}
