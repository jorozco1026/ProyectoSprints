using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Proyectos.App.Dominio;
using Proyectos.App.Persistencia.AppRepositorios;

namespace Proyectos.App.Presentacion.Pages.Equipos
{
    public class EditModel : PageModel
    {
       private readonly IRepositorios _appContext;

        [BindProperty]
        public Equipo equipo  { get; set; } 
        public IEnumerable<Formador> formadores {get; set;} 
        public IEnumerable<Tutor> tutores {get; set;} 
        public string searchString;
        public string searchFormador;
        public string searchTutor;

        public EditModel()
        {
            this._appContext  =new Repositorios(new Proyectos.App.Persistencia.AppRepositorios.AppContext());
        }
     

        //se ejecuta al presionar Editar en la lista
        public IActionResult OnGet(int? equipoId)
        {                           
            formadores =_appContext.GetAllFormadores(searchFormador);
            tutores =_appContext.GetAllTutores(searchTutor);
            if (equipoId.HasValue)
            {
                equipo = _appContext.GetEquipo(equipoId.Value);
            }
            else
            {
                equipo = new Equipo(); 
            }

            if (equipo == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();

        }

        //se ejecuta al presionar Editar en el formulario
        public IActionResult OnPost()
        {                           
            formadores =_appContext.GetAllFormadores(searchFormador);
            tutores =_appContext.GetAllTutores(searchTutor);
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(equipo.id > 0)
            {
               equipo = _appContext.UpdateEquipo( equipo );               
            }
            else
            {
               _appContext.AddEquipo( equipo );
            }
            return Page();
        }
    }
}