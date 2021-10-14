using System;
namespace Agendamiento.App.Dominio
{
    /// <summary>Class <c>Usuario</c>
    /// Modela el usuario en el sistema 
    /// </summary>
    public class Usuario
    {
        public int Id{get;set;}
        public string User{get;set;}
        public string Password{get;set;}
        public DateTime LastUpdate{get;set;}
    }
}
