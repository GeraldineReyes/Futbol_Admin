using System;
//using System.DataTime;
namespace ProyectoSoccerManager.App.Dominio.Entidades
{
    public class Participante
    {
         public int Id { get; set; }
        public string Nombre { get; set;}
        public string Apellido { get; set;}
        public string Correo { get; set;}
        public string Documento { get; set; }

        public DateTime Fec_Nacimiento { get; set;}

        public Tipo_Documento tipo_documento { get; set;}
        public Tipo_Jugador tipo_jugador { get; set;}

        public Genero genero { get; set;}
        

        public Equipo_Jugador equipo_jugador { get; set;}
    }
}