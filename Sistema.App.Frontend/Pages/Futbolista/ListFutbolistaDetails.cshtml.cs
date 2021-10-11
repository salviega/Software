using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sistema.App.Persistencia;
using Sistema.App.Dominio;

namespace Sistema.App.Frontend.Pages
{
    public class ListFutbolistaDetailsModel : PageModel
    {
        private readonly IRepositorioFutbolista _repoFutbolista;
        public Futbolista futbolista {get; set;}
        public ListFutbolistaDetailsModel(IRepositorioFutbolista repoFutbolista)
        {
            _repoFutbolista = repoFutbolista;
        }

        public IActionResult OnGet(int id)
        {
            futbolista = _repoFutbolista.GetFutbolista(id);
            if(futbolista == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
    }
}
