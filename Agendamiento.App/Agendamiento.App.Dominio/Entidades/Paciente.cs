using System;
namespace Agendamiento.App.Dominio
{
    /// <summary>Class <c>Paciente</c>
    /// Modela un Paciente en el sistema hereda de Persona 
    /// </summary> 
    public class Paciente:Persona
    {
        public SedeIps SedeIps {get;set;}
    }
}