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

namespace Proyectos.App.Presentacion.Pages.EstadoProyectos
{
    //[Authorize]
    public class ListModel : PageModel
    {
        private readonly IRepositorios _appContext;
        public IEnumerable<EstadoProyecto> estadoProyectos {get; set;} 

        public string searchString;     

        public ListModel()
        {
            this._appContext = new Repositorios(new Proyectos.App.Persistencia.AppRepositorios.AppContext());
        }
       
        public void OnGet()
        {
            estadoProyectos =_appContext.GetAllEstadoProyectos(searchString); 
        }

        public IActionResult OnPost(string? searchString)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            estadoProyectos = _appContext.GetAllEstadoProyectos(searchString);
            return Page();
        }
    }
}