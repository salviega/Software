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
    public class ListPartidoModel : PageModel
    {
        private static IRepositorioPartido _repoPartido = new RepositorioPartido(new Persistencia.AppContext());
        public IEnumerable<Partido> Partidos {get; set;}
        public void OnGet()

        {
            Partidos = _repoPartido.GetAllPartidos();
        }
    }
}
