using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Agendamiento.App.Dominio;

namespace Agendamiento.App.Persistencia
{
    public interface IRepositorioPaciente
    {
        IEnumerable<Paciente> GetAllPacientes();
        Paciente AddPaciente (Paciente paciente);
        Paciente UpdatePaciente (Paciente paciente);
        Paciente GetPaciente(int idPaciente);
        void DeletePaciente (int idPaciente);
    }
}