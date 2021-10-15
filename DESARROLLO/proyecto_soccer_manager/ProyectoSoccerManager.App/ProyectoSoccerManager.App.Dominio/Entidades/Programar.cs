using System;
namespace ProyectoSoccerManager.App.Dominio
{
    public class Programar
    {
        public int id { get; set; }
        public DateTime fecha{ get; set;}
        public DateTime hora{ get; set;}
        public int goles { get; set;}

        public Arbitro arbitro { get; set; }
        public Campeonato_Equipo campeonato_equipo { get; set;}

        
    }
}