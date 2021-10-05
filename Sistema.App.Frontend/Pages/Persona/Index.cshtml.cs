using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sistema.App.Persistencia;
using Sistema.App.Dominio;

namespace Sistema.App.Frontend.Pages.Persona
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioPersona _repoPersona;
        public IEnumerable<Persona> personas {get; set;}
        public IndexModel(IRepositorioPersona repoPersona)
        {
            _repoPersona = repoPersona;
        }
        public void OnGet()
        {
            personas = _repoPersona.GetAllPersonas();
        }
    }
}
