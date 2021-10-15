using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Proyectos.App.Dominio;
using Proyectos.App.Persistencia.AppRepositorios;

namespace Proyectos.App.Presentacion.Pages.Estudiantes
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorios _appContext;
        public Estudiante estudiante { get; set; }

        public DetailsModel()
        {
            this._appContext=new Repositorios(new Proyectos.App.Persistencia.AppRepositorios.AppContext());
        }

        //se ejecuta al presionar Detalle en la lista
        public IActionResult OnGet(int estudianteId)
        {
            estudiante = _appContext.GetEstudiante(estudianteId);
            if(estudiante == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();
        }
    }
}