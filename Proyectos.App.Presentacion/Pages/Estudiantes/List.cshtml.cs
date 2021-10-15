using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;

using Proyectos.App.Dominio;
using Proyectos.App.Persistencia.AppRepositorios;
using Proyectos.App.Persistencia;

namespace Proyectos.App.Presentacion.Pages.Estudiantes
{
    //[Authorize]
    public class ListModel : PageModel
    {
        private readonly IRepositorios _appContext;
        public IEnumerable<Estudiante> estudiantes {get; set;} 

        public string searchString;     

        public ListModel()
        {
            this._appContext = new Repositorios(new Proyectos.App.Persistencia.AppRepositorios.AppContext());
        }
       
        public void OnGet()
        {
            estudiantes =_appContext.GetAllEstudiantes(searchString); 
        }

        public IActionResult OnPost(string? searchString)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            estudiantes = _appContext.GetAllEstudiantes(searchString);
            return Page();
        }
    }
}