using System;
namespace Agendamiento.App.Dominio
{
    /// <summary>Class <c>Persona</c>
    /// Modela una Persona en general en el sistema 
    /// </summary> 
    public class Persona
    {
        public int Id { get; set; }
        public string NumeroDocumento { get; set;}
        public string Nombre {get;set;}
        public string Apellido {get;set;}
        public Usuario Usuario{get;set;}
        public string Direccion{get;set;}
        public string NumeroTelefono{get;set;}
        public string Email {get;set;}
        public Ciudad Ciudad{get;set;}
        public Genero Genero{get;set;}
        public int Edad{get;set;}
    }
}