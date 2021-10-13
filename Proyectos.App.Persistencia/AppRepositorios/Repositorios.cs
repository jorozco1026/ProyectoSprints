using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

using Proyectos.App.Dominio;


namespace Proyectos.App.Persistencia.AppRepositorios
{
    public class Repositorios : IRepositorios
    {
        private readonly AppContext _appContext;

       public Repositorios(AppContext appContext)
        {
            _appContext = appContext;
        }
        //AQUÍ CADA UNO DE LOS MÉTODOS DEL CRUD, REFERENCIADOS EN LA INTERFACE
         //SIGUIENTE DIAPOSITIVA

        Formador IRepositorios.AddFormador(Formador formador)
        {
        try
         {
            var FormadorAdicionado = _appContext.Formadores.Add( formador );  //INSERT en la BD
            _appContext.SaveChanges();                  
            return FormadorAdicionado.Entity;
          }catch
            {
                throw;
            }
        }

        IEnumerable<Formador> IRepositorios.GetAllFormadores()
        {
            return _appContext.Formadores;
        }

       Formador IRepositorios.GetFormador(int? idFormador)
       {
            return _appContext.Formadores.FirstOrDefault(p => p.id == idFormador);
       }

       Formador IRepositorios.UpdateFormador(Formador formador)
        {
            var FormadorEncontrado = _appContext.Formadores.FirstOrDefault(p => p.id == formador.id);
            if (FormadorEncontrado != null)
            {
                FormadorEncontrado.identificacion  = formador.identificacion;
                FormadorEncontrado.nombre          = formador.nombre;
                _appContext.SaveChanges();
            }
            return FormadorEncontrado;
        }

        void IRepositorios.DeleteFormador(int idFormador)
        {
            var FormadorEncontrado = _appContext.Formadores.FirstOrDefault(p => p.id == idFormador);
            if (FormadorEncontrado == null)
                return;
            _appContext.Formadores.Remove(FormadorEncontrado);
            _appContext.SaveChanges();
        }

    }
}