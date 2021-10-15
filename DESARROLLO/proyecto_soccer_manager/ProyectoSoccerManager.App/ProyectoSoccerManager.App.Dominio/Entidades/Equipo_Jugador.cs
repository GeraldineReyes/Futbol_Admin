using System;
namespace ProyectoSoccerManager.App.Dominio
{
    public class Equipo_Jugador
    {
        public string dorsal { get; set; }

        public Equipo equipo { get; set; }

        public Participante participante { get; set; }

        public Tipo_Jugador tipojugador { get; set; }

        public Posicion posicion { get; set; }
    }
}