using System;
using System.Collections.Generic;
using System.Linq;
using Agendamiento.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Agendamiento.App.Persistencia
{
    public class RepositorioSedeIps : IRepositorioSedeIps
    {
        /// <summary>
        /// Referencia al contexto de sedeIps
        /// </summary>
        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo Constructor Utiiza 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//
        public RepositorioSedeIps()
        {
            _appContext= new AppContext();
        }
        public RepositorioSedeIps(AppContext appContext)
        {
            _appContext = appContext;
        }

        public IEnumerable<SedeIps> GetAllsede()
        {
            return _appContext.Sedesips;
        }
        public SedeIps AddSedeIps(SedeIps sedeIps)
        {
            var sedeAdicionado = _appContext.Sedesips.Add(sedeIps);
            _appContext.SaveChanges();
            return sedeAdicionado.Entity;

        }

        public void DeleteSedeIps(int idSedeIps)
        {
            var sedeEncontrado = _appContext.Sedesips.FirstOrDefault(p => p.Id == idSedeIps);
            if (sedeEncontrado == null)
                return;
            _appContext.Sedesips.Remove(sedeEncontrado);
            _appContext.SaveChanges();
        }

       public IEnumerable<SedeIps> GetAllPacientes()
        {
            return _appContext.Sedesips;
        }
        
        public SedeIps GetSedeIps(int idSedeIps)
        {
            return _appContext.Sedesips.FirstOrDefault(p => p.Id == idSedeIps);
        }

        public SedeIps UpdateSedeIps(SedeIps sedeIps)
        {
            var sedeEncontrado = _appContext.Sedesips.FirstOrDefault(p => p.Id == sedeIps.Id);
            if (sedeEncontrado != null)
            {
                sedeEncontrado.Nombre=sedeIps.Nombre;
                sedeEncontrado.Ciudad=sedeIps.Ciudad;
                sedeEncontrado.Direccion=sedeIps.Direccion;
                sedeEncontrado.Telefono=sedeIps.Telefono;
                sedeEncontrado.Email=sedeIps.Email;
                _appContext.SaveChanges();
            }
            return sedeEncontrado;
        }

        
    }
}