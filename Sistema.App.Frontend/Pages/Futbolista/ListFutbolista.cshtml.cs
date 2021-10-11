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
    public class ListFutbolistaModel : PageModel
    {
        private readonly IRepositorioFutbolista _repoFutbolista;
        //private static IRepositorioEstadio _repoEstadio = new RepositorioEstadio(new Persistencia.AppContext());
        public IEnumerable<Futbolista> futbolistas {get; set;}
        public ListFutbolistaModel(IRepositorioFutbolista repoFutbolista)
        {
           _repoFutbolista = repoFutbolista;
        }
        public void OnGet()
        {
            futbolistas = _repoFutbolista.GetAllFutbolista();
        } 
    }
}
