using System;
//using System.DataTime;
namespace ProyectoSoccerManager.App.Dominio
{
    public class Participante
    {
         public int id { get; set; }
        public string nombre { get; set;}
        public string apellido { get; set;}
        public string correo { get; set;}
        public string documento { get; set; }

        public DateTime Fec_Nacimiento { get; set;}

        public Tipo_Documento tipo_documento { get; set;}
        public Tipo_Jugador tipo_jugador { get; set;}

        public Genero genero { get; set;}
        

        public Equipo_Jugador equipo_jugador { get; set;}
    }
}