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
        Medico AddMedico (Medico medico);
        Medico UpdateMedico (Medico medico);
        Medico GetMedico(int idMedico);
        void DeleteMedico (int idMedico);
    }
}