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
    public class EditModel : PageModel
    {
       private readonly IRepositorios _appContext;

        [BindProperty]
        public Formador formador  { get; set; } 

        public EditModel()
        {
            this._appContext  =new Repositorios(new Proyectos.App.Persistencia.AppRepositorios.AppContext());
        }
     

        //se ejecuta al presionar Editar en la lista
        public IActionResult OnGet(int? formadorId)
        {
            if (formadorId.HasValue)
            {
                formador = _appContext.GetFormador(formadorId.Value);
            }
            else
            {
                formador = new Formador();
            }
            if (formador == null)
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
            if(formador.id > 0)
            {
               formador = _appContext.UpdateFormador(formador);               
            }
            else
            {
               _appContext.AddFormador(formador);
            }
            return Page();
        }
    }
}