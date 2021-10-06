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
    public class ListArbitroModel : PageModel
    {
        private static IRepositorioArbitro _repoArbitro = new RepositorioArbitro(new Persistencia.AppContext());
        public IEnumerable<Arbitro> arbitros { get; set; }
        public void OnGet()

        {
            arbitros = _repoArbitro.GetAllArbitros();
        }
    }
}
