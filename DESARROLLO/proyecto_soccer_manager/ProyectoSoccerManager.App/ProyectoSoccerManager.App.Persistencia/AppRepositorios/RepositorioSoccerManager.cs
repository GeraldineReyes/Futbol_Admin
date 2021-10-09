using System;
using System.Collections.Generic;
using System.Linq;
using ProyectoSoccerManager.App.Dominio;
namespace ProyectoSoccerManager.App.Persistencia
{
    public class RepositorioSoccerManager : IRepositorioSoccerManager
    {
        List<Genero> Generos;
        public RepositorioSoccerManager()
        {
            Generos = new List<Genero>()
            {
                new Genero(Id=1, Nombre="Masculino", Abreviatura="M"),
                new Genero(Id=2, Nombre="Femenino", Abreviatura="F")
            };
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