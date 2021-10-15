using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Proyectos.App.Dominio;
using Proyectos.App.Persistencia.AppRepositorios;

namespace Proyectos.App.Presentacion.Pages.Roles
{
    public class EditModel : PageModel
    {
       private readonly IRepositorios _appContext;

        [BindProperty]
        public Rol rol  { get; set; } 

        public EditModel()
        {
            this._appContext  =new Repositorios(new Proyectos.App.Persistencia.AppRepositorios.AppContext());
        }
     

        //se ejecuta al presionar Editar en la lista
        public IActionResult OnGet(int? rolId)
        {
            if (rolId.HasValue)
            {
                rol = _appContext.GetRol(rolId.Value);
            }
            else
            {
                rol = new Rol();
            }

            if (rol == null)
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
            if(rol.id > 0)
            {
               rol = _appContext.UpdateRol( rol );               
            }
            else
            {
               _appContext.AddRol( rol );
            }
            return Page();
        }
    }
}