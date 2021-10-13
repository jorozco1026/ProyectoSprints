//Directivas
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using Proyectos.App.Dominio;

namespace Proyectos.App.Persistencia.AppRepositorios
{
    public interface IRepositorios
    {
        //contratos o firmas para los metodos Formador        
        Formador AddFormador(Formador formador);
        IEnumerable<Formador> GetAllFormadores();         
        Formador GetFormador(int? idFormador);
        Formador UpdateFormador(Formador formador);
        void DeleteFormador(int idFormador); 
    }
}