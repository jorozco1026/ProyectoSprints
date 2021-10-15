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
        public IEnumerable<Formador> formadores {get; set;} 
        public IEnumerable<Tutor> tutores {get; set;} 
        public IEnumerable<Estudiante> estudiantes {get; set;} 
        public IEnumerable<Rol> roles {get; set;} 
        public IEnumerable<EstadoProyecto> estadoProyectos {get; set;} 
        public IEnumerable<EstadoTarea> estadoTareas{get; set;} 
        public IEnumerable<Equipo> equipos{get; set;} 

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
            var FormadorAdicionado = _appContext.Formadores.Add( formador ); //INSERT en la BD
            _appContext.SaveChanges();                  
            return FormadorAdicionado.Entity;
          }catch
          {
                throw;
          }
        }

        IEnumerable<Formador> IRepositorios.GetAllFormadores(string? nombre)
        {
            if (nombre != null) {
              formadores = _appContext.Formadores.Where(p => p.nombre.Contains(nombre)); //like sobre la tabla
            }
            else 
               formadores = _appContext.Formadores;  //select * from formador
            return formadores;
        }

       Formador IRepositorios.GetFormador(int? idFormador)
       {
            return _appContext.Formadores.FirstOrDefault(p => p.id == idFormador);
       }

       Formador IRepositorios.UpdateFormador(Formador formador)
        {
            var FormadorEncontrado = _appContext.Formadores.FirstOrDefault(p => p.id == formador.id); //SELECT
            if (FormadorEncontrado != null)
            {
                FormadorEncontrado.identificacion  = formador.identificacion; //
                FormadorEncontrado.nombre          = formador.nombre;
                _appContext.SaveChanges();  //UPDATE 
            }
            return FormadorEncontrado;
        }

        void IRepositorios.DeleteFormador(int idFormador)
        {
            var FormadorEncontrado = _appContext.Formadores.FirstOrDefault(p => p.id == idFormador);
            if (FormadorEncontrado == null)
                return;
            _appContext.Formadores.Remove( FormadorEncontrado );
            _appContext.SaveChanges();
        }
         
        //CRUD TUTORES
        Tutor IRepositorios.AddTutor(Tutor tutor)
        {
          try
          {
            var TutorAdicionado = _appContext.Tutores.Add( tutor ); //INSERT en la BD
            _appContext.SaveChanges();                  
            return TutorAdicionado.Entity;
          }catch
          {
                throw;
          }
        }

        IEnumerable<Tutor> IRepositorios.GetAllTutores(string? nombre)
        {
            if (nombre != null) {
              tutores = _appContext.Tutores.Where(p => p.nombre.Contains(nombre)); //like sobre la tabla
            }
            else 
               tutores = _appContext.Tutores;  //select * from tutor
            return tutores;
        }

       Tutor IRepositorios.GetTutor(int? idTutor)
       {
            return _appContext.Tutores.FirstOrDefault(p => p.id == idTutor);
       }

       Tutor IRepositorios.UpdateTutor(Tutor tutor)
        {
            var TutorEncontrado = _appContext.Tutores.FirstOrDefault(p => p.id == tutor.id); //SELECT
            if (TutorEncontrado != null)
            {
                TutorEncontrado.identificacion  = tutor.identificacion; //
                TutorEncontrado.nombre          = tutor.nombre;
                _appContext.SaveChanges();  //UPDATE 
            }
            return TutorEncontrado;
        }

        void IRepositorios.DeleteTutor(int idTutor)
        {
            var TutorEncontrado = _appContext.Tutores.FirstOrDefault(p => p.id == idTutor);
            if (TutorEncontrado == null)
                return;
            _appContext.Tutores.Remove( TutorEncontrado );
            _appContext.SaveChanges();
        }
 
        //CRUD Estudiante
        Estudiante IRepositorios.AddEstudiante(Estudiante estudiante)
        {
          try
          {
            var EstudianteAdicionado = _appContext.Estudiantes.Add( estudiante ); //INSERT en la BD
            _appContext.SaveChanges();                  
            return EstudianteAdicionado.Entity;
          }catch
          {
                throw;
          }
        }

        IEnumerable<Estudiante> IRepositorios.GetAllEstudiantes(string? nombre)
        {
            if (nombre != null) {
              estudiantes = _appContext.Estudiantes.Where(p => p.nombre.Contains(nombre)); //like sobre la tabla
            }
            else 
               estudiantes = _appContext.Estudiantes;  //select * from estudiante
            return estudiantes;
        }

       Estudiante IRepositorios.GetEstudiante(int? idEstudiante)
       {
            return _appContext.Estudiantes.FirstOrDefault(p => p.id == idEstudiante);
       }

       Estudiante IRepositorios.UpdateEstudiante(Estudiante estudiante)
        {
            var EstudianteEncontrado = _appContext.Estudiantes.FirstOrDefault(p => p.id == estudiante.id); //SELECT
            if (EstudianteEncontrado != null)
            {
                EstudianteEncontrado.identificacion  = estudiante.identificacion; //
                EstudianteEncontrado.nombre          = estudiante.nombre;
                EstudianteEncontrado.movil           = estudiante.movil;
                EstudianteEncontrado.mail            = estudiante.mail;
                _appContext.SaveChanges();  //UPDATE 
            }
            return EstudianteEncontrado;
        }

        void IRepositorios.DeleteEstudiante(int idEstudiante)
        {
            var EstudianteEncontrado = _appContext.Estudiantes.FirstOrDefault(p => p.id == idEstudiante);
            if (EstudianteEncontrado == null)
                return;
            _appContext.Estudiantes.Remove( EstudianteEncontrado );
            _appContext.SaveChanges();
        }
 
        //CRUD Rol
        Rol IRepositorios.AddRol(Rol rol)
        {
          try
          {
            var RolAdicionado = _appContext.Roles.Add( rol ); //INSERT en la BD
            _appContext.SaveChanges();                  
            return RolAdicionado.Entity;
          }catch
          {
                throw;
          }
        }

        IEnumerable<Rol> IRepositorios.GetAllRoles(string? nombre)
        {
            if (nombre != null) {
              roles = _appContext.Roles.Where(p => p.nombre.Contains(nombre)); //like sobre la tabla
            }
            else 
               roles = _appContext.Roles;  //select * from rol
            return roles;
        }

       Rol IRepositorios.GetRol(int? idRol)
       {
            return _appContext.Roles.FirstOrDefault(p => p.id == idRol);
       }

       Rol IRepositorios.UpdateRol(Rol rol)
        {
            var RolEncontrado = _appContext.Roles.FirstOrDefault(p => p.id == rol.id); //SELECT
            if (RolEncontrado != null)
            {
                RolEncontrado.descripcion     = rol.descripcion; //
                RolEncontrado.nombre          = rol.nombre;
                _appContext.SaveChanges();  //UPDATE 
            }
            return RolEncontrado;
        }

        void IRepositorios.DeleteRol(int idRol)
        {
            var RolEncontrado = _appContext.Roles.FirstOrDefault(p => p.id == idRol);
            if (RolEncontrado == null)
                return;
            _appContext.Roles.Remove( RolEncontrado );
            _appContext.SaveChanges();
        }
 
        //CRUD estado proyectos_ciclo3
        EstadoProyecto IRepositorios.AddEstadoProyecto(EstadoProyecto estadoProyecto)
        {
          try
          {
            var EstadoProyectoAdicionado = _appContext.EstadoProyectos.Add( estadoProyecto ); //INSERT en la BD
            _appContext.SaveChanges();                  
            return EstadoProyectoAdicionado.Entity;
          }catch
          {
                throw;
          }
        }

        IEnumerable<EstadoProyecto> IRepositorios.GetAllEstadoProyectos(string? nombre)
        {
            if (nombre != null) {
              estadoProyectos = _appContext.EstadoProyectos.Where(p => p.nombre.Contains(nombre)); //like sobre la tabla
            }
            else 
               estadoProyectos = _appContext.EstadoProyectos;  //select * from estadoProyecto
            return estadoProyectos;
        }

       EstadoProyecto IRepositorios.GetEstadoProyecto(int? idEstadoProyecto)
       {
            return _appContext.EstadoProyectos.FirstOrDefault(p => p.id == idEstadoProyecto);
       }

       EstadoProyecto IRepositorios.UpdateEstadoProyecto(EstadoProyecto estadoProyecto)
        {
            var EstadoProyectoEncontrado = _appContext.EstadoProyectos.FirstOrDefault(p => p.id == estadoProyecto.id); //SELECT
            if (EstadoProyectoEncontrado != null)
            {
                EstadoProyectoEncontrado.nombre  = estadoProyecto.nombre;
                _appContext.SaveChanges();  //UPDATE 
            }
            return EstadoProyectoEncontrado;
        }

        void IRepositorios.DeleteEstadoProyecto(int idEstadoProyecto)
        {
            var EstadoProyectoEncontrado = _appContext.EstadoProyectos.FirstOrDefault(p => p.id == idEstadoProyecto);
            if (EstadoProyectoEncontrado == null)
                return;
            _appContext.EstadoProyectos.Remove( EstadoProyectoEncontrado );
            _appContext.SaveChanges();
        }
 
        //crud de estado estadoTareas
        EstadoTarea IRepositorios.AddEstadoTarea(EstadoTarea estadoTarea)
        {
          try
          {
            var EstadoTareaAdicionado = _appContext.EstadoTareas.Add( estadoTarea ); //INSERT en la BD
            _appContext.SaveChanges();                  
            return EstadoTareaAdicionado.Entity;
          }catch
          {
                throw;
          }
        }

        IEnumerable<EstadoTarea> IRepositorios.GetAllEstadoTareas(string? nombre)
        {
            if (nombre != null) {
              estadoTareas = _appContext.EstadoTareas.Where(p => p.nombre.Contains(nombre)); //like sobre la tabla
            }
            else 
               estadoTareas = _appContext.EstadoTareas;  //select * from estadoTarea
            return estadoTareas;
        }

       EstadoTarea IRepositorios.GetEstadoTarea(int? idEstadoTarea)
       {
            return _appContext.EstadoTareas.FirstOrDefault(p => p.id == idEstadoTarea);
       }

       EstadoTarea IRepositorios.UpdateEstadoTarea(EstadoTarea estadoTarea)
        {
            var EstadoTareaEncontrado = _appContext.EstadoTareas.FirstOrDefault(p => p.id == estadoTarea.id); //SELECT
            if (EstadoTareaEncontrado != null)
            {                
                EstadoTareaEncontrado.nombre          = estadoTarea.nombre;
                _appContext.SaveChanges();  //UPDATE 
            }
            return EstadoTareaEncontrado;
        }

        void IRepositorios.DeleteEstadoTarea(int idEstadoTarea)
        {
            var EstadoTareaEncontrado = _appContext.EstadoTareas.FirstOrDefault(p => p.id == idEstadoTarea);
            if (EstadoTareaEncontrado == null)
                return;
            _appContext.EstadoTareas.Remove( EstadoTareaEncontrado );
            _appContext.SaveChanges();
        }

        //CRUD Equipo
        Equipo IRepositorios.AddEquipo(Equipo equipo)
        {
          try
          {
            var EquipoAdicionado = _appContext.Equipos.Add( equipo ); //INSERT en la BD
            _appContext.SaveChanges();                  
            return EquipoAdicionado.Entity;
          }catch
          {
                throw;
          }
        }

        IEnumerable<Equipo> IRepositorios.GetAllEquipos(string? nombre)
        {
            if (nombre != null) {
              equipos = _appContext.Equipos.Where(p => p.nombre.Contains(nombre)); //like sobre la tabla
            }
            else 
               equipos = _appContext.Equipos;  //select * from equipo
            return equipos;
        }

       Equipo IRepositorios.GetEquipo(int? idEquipo)
       {
            return _appContext.Equipos.FirstOrDefault(p => p.id == idEquipo);
       }

       Equipo IRepositorios.UpdateEquipo(Equipo equipo)
        {
            var EquipoEncontrado = _appContext.Equipos.FirstOrDefault(p => p.id == equipo.id); //SELECT
            if (EquipoEncontrado != null)
            {
                EquipoEncontrado.codigo     = equipo.codigo; //
                EquipoEncontrado.nombre          = equipo.nombre;
                EquipoEncontrado.meet          = equipo.meet;
                EquipoEncontrado.whatapp          = equipo.whatapp;
                EquipoEncontrado.formador          = equipo.formador;
                EquipoEncontrado.tutor          = equipo.tutor;
                _appContext.SaveChanges();  //UPDATE 
            }
            return EquipoEncontrado;
        }

        void IRepositorios.DeleteEquipo(int idEquipo)
        {
            var EquipoEncontrado = _appContext.Equipos.FirstOrDefault(p => p.id == idEquipo);
            if (EquipoEncontrado == null)
                return;
            _appContext.Equipos.Remove( EquipoEncontrado );
            _appContext.SaveChanges();
        }
 

    }
}