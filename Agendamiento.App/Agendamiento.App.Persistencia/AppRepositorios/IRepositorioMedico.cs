using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Agendamiento.App.Dominio;

namespace Agendamiento.App.Persistencia
{
    public interface IRepositorioMedico
    {
        IEnumerable<Medico> GetAllMedicos();
        Paciente AddMedico (Medico medico);
        Paciente UpdateMedico (Medico medico);
        Paciente GetMedico(int idMedico);
        void DeleteMedico (int idMedico);
    }
}