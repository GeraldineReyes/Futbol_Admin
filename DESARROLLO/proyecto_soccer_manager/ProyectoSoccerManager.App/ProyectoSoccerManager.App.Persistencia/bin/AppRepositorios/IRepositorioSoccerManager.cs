using System;
using ProyectoSoccerManager.App.Dominio;
namespace ProyectoSoccerManager.App.Persistencia.bin.AppRepositorios
{
    public interface IRepositorioSoccerManager
    {
        IEnumerable<Genero> GetAll();
        IEnumerable<Genero> GetGeneroPorFiltro(string filtro);

        Genero GetGeneroPorId(int GeneroId);
        Genero Update(Genero generoActualizado);

        Genero Add(Genero nuevoGenero);
    }
}