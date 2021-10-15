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
    public class EditModel : PageModel
    {
       private readonly IRepositorios _appContext;

        [BindProperty]
        public Estudiante estudiante  { get; set; } 

        public EditModel()
        {
            this._appContext  =new Repositorios(new Proyectos.App.Persistencia.AppRepositorios.AppContext());
        }
     

        //se ejecuta al presionar Editar en la lista
        public IActionResult OnGet(int? estudianteId)
        {
            if (estudianteId.HasValue)
            {
                estudiante = _appContext.GetEstudiante(estudianteId.Value);
            }
            else
            {
                estudiante = new Estudiante();
            }

            if (estudiante == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();

        }

        //se ejecuta al presionar Editar en el formulario
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(estudiante.id > 0)
            {
               estudiante = _appContext.UpdateEstudiante( estudiante );               
            }
            else
            {
               _appContext.AddEstudiante( estudiante );
            }
            return Page();
        }
    }
}