using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.DATA
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Alojam> alojam {get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Si el nombre de la tabla en SQL es distinto al de la clase, mapea aquí:
            modelBuilder.Entity<Alojam>().ToTable("TBAlojam");

            // Si la clave primaria no se llama Id, configúrala:
            // modelBuilder.Entity<Usuario>().HasKey(x => x.UsuarioId);
        }
    };
   
    }
