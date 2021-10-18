using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Agendamiento.App.Dominio;

namespace Agendamiento.App.Persistencia
{
    public interface IRepositorioSedeIps
    {
        IEnumerable<SedeIps> GetAllsede();
        SedeIps AddSedeIps (SedeIps sedeIps);
        SedeIps UpdateSedeIps (SedeIps sedeIps);
        SedeIps GetSedeIps(int idSedeIps);
        void DeleteSedeIps (int idSedeIps);
    }
}