using System;
using System.Collections.Generic;
using System.Linq;
using Agendamiento.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Agendamiento.App.Persistencia
{
    public class RepositorioMedico : IRepositorioMedico
    {
        private readonly AppContext _appContext; //recomendable por seguridad

        public RepositorioMedico(AppContext appContext)
        {
            _appContext = appContext;
        }

        public Medico AddMedico(Medico medico)
        {
            var medicoAdicionado = _appContext.Medicos.Add(medico);
            _appContext.SaveChanges(); //Se deben guardar los cambios
            return medicoAdicionado.Entity; 
        }

        public void DeleteMedico(int idMedico)
        {
            var medicoEncontrado= _appContext.Medicos.FirstOrDefault(m =>m.Id==idMedico);//m es el primero que encuentra. Recorre todos los elementos de la tabla
            if(medicoEncontrado==null)
            return;
            _appContext.Medicos.Remove(medicoEncontrado);
            _appContext.SaveChanges();//Se deben guardar los cambios
        }

        public IEnumerable <Medico> GetAllMedicos()
        {
            return _appContext.Medicos;
        }

        public Medico GetMedico  (int idMedico)
          {
           return _appContext.Medicos.FirstOrDefault(m =>m.Id==idMedico);//retorna lo que encuentra
          }

        public Medico UpdateMedico  (Medico medico)
          {
           var medicoEncontrado= _appContext.Medicos.FirstOrDefault(m =>m.Id==medico.Id);
           //No se busca el idMedico, se busca el medico.Id
           if(medicoEncontrado!=null)
           {
                medicoEncontrado.Nombre=medico.Nombre;
                medicoEncontrado.Apellido=medico.Apellido;
                medicoEncontrado.NumeroTelefono=medico.NumeroTelefono;
                medicoEncontrado.Direccion=medico.Direccion;
                medicoEncontrado.Ciudad=medico.Ciudad;
                _appContext.SaveChanges();        
           }
             return medicoEncontrado; //retorna el medico encontrado
            
          }  
     }
}