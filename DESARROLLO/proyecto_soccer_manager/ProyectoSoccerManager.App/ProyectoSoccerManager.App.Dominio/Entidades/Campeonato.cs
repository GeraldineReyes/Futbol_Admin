using System;
//using System.DataTime;
namespace ProyectoSoccerManager.App.Dominio
{
    public class Campeonato
    {
        public int Id { get; set; }
        public string Nombre { get; set;}
        public DateTime Fecha_Inicial { get; set;}
        public DateTime Fecha_Fin { get; set;}
        public string Reglamento { get; set;}
        public string Can_Canchas { get; set;}
        

        public Cancha cancha { get; set;}
        public Categoria categoria { get; set;}
        public Ciudad ciudad { get; set;}
        public Dias dias { get; set;}
        public Max_Equipos max_equipos { get; set;}
        public Max_Jugadores max_jugadores { get; set;}
        public Min_Equipos min_equipos { get; set;}
        public Min_Jugadores min_jugadores { get; set;}
        public Rama rama { get; set;}
        public Tipo tipo { get; set;}
        public ValorInscripcion valorinscripcion { get; set;}
        public Organizador organizador { get; set;}
        public Programar programar { get; set;}
        

        public Campeonato_Equipo campeonato_equipo { get; set;}
    }
}