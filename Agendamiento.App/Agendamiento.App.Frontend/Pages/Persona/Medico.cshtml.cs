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
    public class MedicoModel : PageModel
    {
        private readonly IRepositorioMedico _repoMedico;
        public Medico medico {get;set;}
        public MedicoModel()
        {
            this._repoMedico = new RepositorioMedico(new Agendamiento.App.Persistencia.AppContext());
        }
        public void OnGet()
        {
            medico = new Medico();
        }
        public IActionResult OnPost(Medico medico)
        {
            if(ModelState.IsValid)
            {
                _repoMedico.AddMedico(medico);
                return RedirectToPage("/Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
