using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Proyectos.App.Dominio;
using Proyectos.App.Persistencia.AppRepositorios;

namespace Proyectos.App.Presentacion.Pages.EstadoTareas
{
    public class EditModel : PageModel
    {
       private readonly IRepositorios _appContext;

        [BindProperty]
        public EstadoTarea estadoTarea  { get; set; } 

        public EditModel()
        {
            this._appContext  =new Repositorios(new Proyectos.App.Persistencia.AppRepositorios.AppContext());
        }
     

        //se ejecuta al presionar Editar en la lista
        public IActionResult OnGet(int? estadoTareaId)
        {
            if (estadoTareaId.HasValue)
            {
                estadoTarea = _appContext.GetEstadoTarea(estadoTareaId.Value);
            }
            else
            {
                estadoTarea = new EstadoTarea();
            }

            if (estadoTarea == null)
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
            if(estadoTarea.id > 0)
            {
               estadoTarea = _appContext.UpdateEstadoTarea( estadoTarea );               
            }
            else
            {
               _appContext.AddEstadoTarea( estadoTarea );
            }
            return Page();
        }
    }
}