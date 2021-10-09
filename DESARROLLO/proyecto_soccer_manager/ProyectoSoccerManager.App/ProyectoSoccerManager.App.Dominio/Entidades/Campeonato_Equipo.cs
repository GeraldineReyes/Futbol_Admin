using System;
namespace ProyectoSoccerManager.App.Dominio
{
    public class Campeonato_Equipo
    {
        public string Local { get; set; }
        public string Visitante { get; set; }


        public Campeonato campeonato { get; set; }
        public Equipo equipo { get; set; }
    }
}