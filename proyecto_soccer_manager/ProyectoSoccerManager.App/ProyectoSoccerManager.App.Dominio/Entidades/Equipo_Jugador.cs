using System;
namespace ProyectoSoccerManager.App.Dominio.Entidades
{
    public class Equipo_Jugador
    {
        public string Dorsal { get; set; }

        public Equipo equipo { get; set; }

        public Participante participante { get; set; }

        public Tipo_Jugador tipojugador { get; set; }

        public Posicion posicion { get; set; }
    }
}