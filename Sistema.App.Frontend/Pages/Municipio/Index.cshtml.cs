using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sistema.App.Persistencia;
using Sistema.App.Dominio;


namespace Sistema.App.Frontend.Pages.Municipio
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioMunicipio _repoMunicipio;
        public IEnumerable<Municipio> municipios {get; set;}
        public IndexModel(IRepositorioMunicipio repoMunicipio)
        {
            _repoMunicipio = repoMunicipio;
        }
        public void OnGet()
        {
            municipios = _repoMunicipio.GetAllMunicipios();
        }
    }
}
