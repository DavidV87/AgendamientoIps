using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Agendamiento.App.Dominio;
using Agendamiento.App.Persistencia;


namespace Agendamiento.App.Frontend.Pages.SedesIps
{
    public class CrearSedesModel : PageModel
    {
        private readonly IRepositorioSedeIps _repoSedeIps;
        public SedeIps sedeIps {get;set;}
        public CrearSedesModel()
        {
            this._repoSedeIps = new RepositorioSedeIps(new Agendamiento.App.Persistencia.AppContext());
        }
        public void OnGet()
        {
            sedeIps = new SedeIps();
        }
        public IActionResult OnPost(SedeIps sedeIps)
        {
            if(ModelState.IsValid)
            {
                _repoSedeIps.AddSedeIps(sedeIps);
                return RedirectToPage("/Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
