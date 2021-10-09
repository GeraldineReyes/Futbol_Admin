using System;
using System.Collections.Generic;
using System.Linq;
using ProyectoSoccerManager.App.Dominio;
namespace ProyectoSoccerManager.App.Persistencia.bin.AppRepositorios
{
    public class RepositorioSoccerManager : IRepositorioSoccerManager
    {
        public RepositorioSoccerManager()
        {
        }
            public Genero Add(Genero nuevoGenero) // Adicionar
            {
                nuevoGenero.Id = Generos.Max(r => r.id) + 1; //id: contados Max obtiene el numero mayor, y le suma uno
                Generos.Add(nuevoGenero);
                return nuevoGenero;
            }

            public IEnumerable<Genero> GetAll() //Listar
            {
                return Generos;
            }

            public Genero GetGeneroPorId(int GeneroId)  // Buscar
            {
                return Generos.SingleOrDefault(g => g.Id == GeneroId);//recorre la lista de saludos, hasta encontrar uno igual
            }

            public IEnumerable<Genero> GetGenerosPorFiltro(string filtro) //Desplegable, Falta implementar
            {
                throw new NotImplementedException();
            }

            public Genero Update(Genero generoActualizado)  // Actualizar
            {
                var genero = Generos.SingleOrDefault(r => r.id == generoActualizado.Id);
                if (genero != null)
                {
                    genero.Nombre = generoActualizado.Nombre;
                    genero.Abreviatura = generoActualizado.Abreviatura;
                }
                return genero;
            }
        

    }
}