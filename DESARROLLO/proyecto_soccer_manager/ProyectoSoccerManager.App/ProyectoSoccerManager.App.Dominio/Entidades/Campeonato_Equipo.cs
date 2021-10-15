using System;
namespace ProyectoSoccerManager.App.Dominio
{
    public class Campeonato_Equipo
    {
        public string local { get; set; }
        public string visitante { get; set; }


        public Campeonato campeonato { get; set; }
        public Equipo equipo { get; set; }
    }
}