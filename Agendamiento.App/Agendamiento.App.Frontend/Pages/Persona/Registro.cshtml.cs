using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Agendamiento.App.Dominio;
using Agendamiento.App.Persistencia;

namespace Agendamiento.App.Frontend.Pages.Persona
{
    public class RegistroModel : PageModel
    {
        private readonly IRepositorioPaciente _repoPaciente;
        public Paciente paciente {get;set;}
        public RegistroModel()
        {
            this._repoPaciente = new RepositorioPaciente(new Agendamiento.App.Persistencia.AppContext());
            //_repoPaciente = repoPaciente;
        }
        public void OnGet()
        {
            paciente = new Paciente();
        }   

        public IActionResult OnPost(Paciente paciente)
        {
            if(ModelState.IsValid)
            {
                _repoPaciente.AddPaciente(paciente);
                return RedirectToPage("/Index");
            }
            else
            {
                return Page();
            }
        }
        
    }
}
