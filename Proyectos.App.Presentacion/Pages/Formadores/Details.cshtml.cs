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
    public class DetailsModel : PageModel
    {
        private readonly IRepositorios _appContext;
        public Formador formador { get; set; }

        public DetailsModel()
        {
            this._appContext=new Repositorios(new Proyectos.App.Persistencia.AppRepositorios.AppContext());
        }

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
    }
}