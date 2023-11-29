
using BibliotecaDAL;
using BibliotecaDAL.Entidades;
using Microsoft.EntityFrameworkCore;
namespace DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var obj = modelBuilder.UseSerialColumns();
            modelBuilder.Entity<Acceso>()
            .HasMany(a => a.listaUsuarios)
            .WithOne(u => u.acceso)
            .HasForeignKey(a => a.id_acceso);
            modelBuilder.Entity<Usuario>()
            .HasMany(u => u.listaPrestamos)
            .WithOne(p => p.usuario)
            .HasForeignKey(u => u.id_usuario);
            modelBuilder.Entity<Estados_Prestamos>()
            .HasMany(ep => ep.listaPrestamos)
            .WithOne(p => p.estados_prestamos)
            .HasForeignKey(u => u.id_estados_prestamos);
            modelBuilder.Entity<Libro>()
            .HasMany(l => l.listaPrestamos)
            .WithMany(p => p.listaLibros)
            .UsingEntity("Rel_Prestamos_Libros");
            modelBuilder.Entity<Autor>()
            .HasMany(a => a.listaLibros)
            .WithMany(l => l.listaAutores)
            .UsingEntity("Rel_Autores_Libros");
        }
        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<Prestamo> prestamos { get; set; }
        public DbSet<Libro> libros { get; set; }
        public DbSet<Estados_Prestamos> estados_prestamos { get; set; }
        public DbSet<Acceso> accesos { get; set; }
    }
}

