using System;
namespace Agendamiento.App.Dominio
{
    /// <summary>Class <c>Agenda</c>
    /// Modela la Agenda en el sistema 
    /// </summary> 
    public class Agenda
    {        
        public int Id {get;set;}
        public Paciente Paciente{get;set;}
        public Medico Medico{get;set;}
        public string Nota{get;set;}
        public DateTime FechaCita{get;set;}
    }
}