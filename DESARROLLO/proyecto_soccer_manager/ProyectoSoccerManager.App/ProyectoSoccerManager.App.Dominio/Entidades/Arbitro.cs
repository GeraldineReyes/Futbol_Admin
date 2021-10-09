using System;
namespace ProyectoSoccerManager.App.Dominio.Entidades
{
    public class Arbitro
    {
         public int Id { get; set; }
        public string Nombre { get; set;}
        public string Apellido { get; set;}
        public string Correo { get; set;}
        public string Documento { get; set; }
        public string Celular { get; set;}
        public string Certificado { get;set;}
        

        public Tipo_Documento tipo_documento { get; set;}

    }
}