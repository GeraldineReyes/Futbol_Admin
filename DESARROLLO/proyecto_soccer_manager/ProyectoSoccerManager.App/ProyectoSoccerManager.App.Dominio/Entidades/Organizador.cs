using System;
namespace ProyectoSoccerManager.App.Dominio
{
    public class Organizador
    {
        public int id { get; set; }
        public string nombre { get; set;}
        public string apellido { get; set;}
        public string correo { get; set;}
        public string documento { get; set; }
        public string celular { get; set;}

        public Tipo_Documento tipo_documento { get; set;}
    }
}