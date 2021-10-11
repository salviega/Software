using System.Collections.Generic;
//using System.Linq;
using Sistema.App.Dominio;


namespace Sistema.App.Persistencia
{
    public class RepositorioMunicipio : IRepositorioMunicipio
    {

        
        private readonly AppContext _appContext = new AppContext();
        

        
        //Municipio IRepositorioMunicipio.AddMunicipio(Municipio municipio)
        public Municipio AddMunicipio(Municipio municipio)
        {
            var municipioAdicionado = _appContext.Municipios.Add(municipio);
            _appContext.SaveChanges();
            return municipioAdicionado.Entity;
        }


        void IRepositorioMunicipio.DeleteMunicipio(int idMunicipio)
        {
            //var MunicipioEncontrado = _appContext.Municipios.FirstOrDefault(m => m.Id == idMunicipio);
            var MunicipioEncontrado = _appContext.Municipios.Find(idMunicipio);
            if (MunicipioEncontrado == null)
                return;
            _appContext.Municipios.Remove(MunicipioEncontrado);
            _appContext.SaveChanges();
        }

        //IEnumerable<Municipio> IRepositorioMunicipio.GetAllMunicipios()
         public IEnumerable<Municipio> GetAllMunicipios()
        {
            return _appContext.Municipios;
        }

       // Municipio IRepositorioMunicipio.GetMunicipio(int idMunicipio)
        public Municipio GetMunicipio(int idMunicipio)
        {
            //return _appContext.Municipios.FirstOrDefault(m => m.Id == idMunicipio);
            return _appContext.Municipios.Find(idMunicipio);
            
        }        

        Municipio IRepositorioMunicipio.UpdateMunicipio(string nombre, Municipio municipio)
        {
            //var MunicipioEncontrado = _appContext.Municipios.FirstOrDefault(m => m.Nombre == nombre);
            var MunicipioEncontrado = _appContext.Municipios.Find(nombre);
            if (MunicipioEncontrado != null)
            {
                MunicipioEncontrado.Nombre = municipio.Nombre;


                _appContext.SaveChanges();

            }
            return MunicipioEncontrado;
        }


        










    }
}

