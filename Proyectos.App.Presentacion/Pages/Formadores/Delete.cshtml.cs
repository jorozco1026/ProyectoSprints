using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Proyectos.App.Dominio;
using Proyectos.App.Persistencia.AppRepositorios;

namespace Proyectos.App.Presentacion.Pages
{
    public class DeleteModel : PageModel
    {
       private readonly IRepositorios _appContext;

        [BindProperty]
        public Formador formador  { get; set; } 

        public DeleteModel()
        {
            this._appContext  =new Repositorios(new Proyectos.App.Persistencia.AppRepositorios.AppContext());
        }
     

        //se ejecuta al presionar Eliminar en la lista
        public IActionResult OnGet(int formadorId)
        {
            formador = _appContext.GetFormador(formadorId);
            if(formador == null)
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
            if(formador.id > 0)
            {
               _appContext.DeleteFormador(formador.id);
            }
            return Page();
        }
    }
}