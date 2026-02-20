using AdministradorBliblioteca.Models;
using Microsoft.EntityFrameworkCore;

namespace AdministradorBliblioteca.Datos
{
    public class ApplicationDbContext : DbContext
    {
        //constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        // Definir tus DbSet para las entidades aquí
        public DbSet<Libro> Libros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configuraciones adicionales de tus entidades si es necesario
            modelBuilder.Entity<Libro>(entity =>
            {
                entity.ToTable("Libros");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(150);
                entity.Property(e => e.Autor).HasMaxLength(150);
                entity.Property(e => e.AnioPublicacion)
                        .HasColumnType("int");
                entity.Property(e => e.Precio)
                        .HasPrecision(10, 2);
            });
        }

    }
}
