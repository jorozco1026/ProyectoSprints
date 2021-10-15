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
    public class DeleteModel : PageModel
    {
       private readonly IRepositorios _appContext;

        [BindProperty]
        public Estudiante estudiante  { get; set; } 

        public DeleteModel()
        {
            this._appContext  =new Repositorios(new Proyectos.App.Persistencia.AppRepositorios.AppContext());
        }
     

        //se ejecuta al presionar Eliminar en la lista
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

        //se ejecuta al presionar Eliminar en el formulario 
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(estudiante.id > 0)
            {
               _appContext.DeleteEstudiante(estudiante.id);
            }
            return Page();
        }
    }
}