using Microsoft.EntityFrameworkCore;
using ProyectoSoccerManager.App.Dominio;

namespace ProyectoSoccerManager.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Genero> Generos {get;set;}

        
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder
            .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = SoccerManagerData");
        }
    }
    }
}