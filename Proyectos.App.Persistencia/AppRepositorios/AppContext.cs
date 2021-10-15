using Microsoft.EntityFrameworkCore;
using Proyectos.App.Dominio;

namespace Proyectos.App.Persistencia.AppRepositorios
{
    public class AppContext  : DbContext
    {
        public DbSet<Formador> Formadores { get; set; }
        public DbSet<Tutor> Tutores { get; set; }
        public DbSet<Estudiante> Estudiantes{ get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<EstadoProyecto> EstadoProyectos { get; set; }
        public DbSet<EstadoTarea> EstadoTareas { get; set; }
        public DbSet<Equipo> Equipos { get; set; }
  
        //crear el deContext
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            optionsBuilder
           .UseSqlServer("Server=localhost; user id=sa; password=12345; Initial Catalog=ProyectoSprint;");            
            }
        }        
    }
}