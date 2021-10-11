using System;
using System.Collections.Generic;
using Sistema.App.Dominio;

namespace Sistema.App.Persistencia
{
    ///Interface completa///
    public interface IRepositorioDirectorTecnico
    {
        IEnumerable<DirectorTecnico> GetAllDirectorTecnico();
        DirectorTecnico AddDirectorTecnico(DirectorTecnico directorTecnico);
        DirectorTecnico UpdateDirectorTecnico(DirectorTecnico Dt);
        void DeleteDirectorTecnico(int idDirectorTecnico);
        DirectorTecnico GetDirectorTecnico(int idDirectorTecnico); 
    }
}