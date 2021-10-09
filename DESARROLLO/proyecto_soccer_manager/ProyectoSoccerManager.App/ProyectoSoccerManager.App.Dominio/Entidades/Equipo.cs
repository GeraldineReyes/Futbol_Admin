using System;
namespace ProyectoSoccerManager.App.Dominio.Entidades
{
    public class Equipo
    {
        public int Id {get; set; }
        public string Nombre {get; set; }
        public string Color_Uniforme {get; set; }
        public string Disponibilidad {get; set;}
    }
}