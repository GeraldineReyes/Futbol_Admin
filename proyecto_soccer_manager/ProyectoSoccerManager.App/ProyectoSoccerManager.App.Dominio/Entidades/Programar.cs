using System;
namespace ProyectoSoccerManager.App.Dominio.Entidades
{
    public class Programar
    {
        public int Id { get; set; }
        public DateTime Fecha{ get; set;}
        public DateTime Hora{ get; set;}
        public int Goles { get; set;}

        public Arbitro arbitro { get; set; }
        public Campeonato_Equipo campeonato_equipo { get; set;}

        
    }
}