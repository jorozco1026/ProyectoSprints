using Microsoft.EntityFrameworkCore;
using Proyectos.App.Dominio;

namespace Proyectos.App.Persistencia.AppRepositorios
{
    public class AppContext  : DbContext
    {
        public DbSet<Formador> Formadores { get; set; }
  
        //crear el deContext
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            optionsBuilder
           .UseSqlServer("Server=localhost; user id=sa; password=12345; Initial Catalog=Proyectos;");            
            }
        }        
    }
}