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
        IEnumerable<Formador> GetAllFormadores(string? nombre);         
        Formador GetFormador(int? idFormador);
        Formador UpdateFormador(Formador formador);
        void DeleteFormador(int idFormador); 

        //firmas tutores
        Tutor AddTutor(Tutor tutor);
        IEnumerable<Tutor> GetAllTutores(string? nombre);         
        Tutor GetTutor(int? idTutor);
        Tutor UpdateTutor(Tutor tutor);
        void DeleteTutor(int idTutor); 

        //firmas Estudiantes
        Estudiante AddEstudiante(Estudiante estudiante);
        IEnumerable<Estudiante> GetAllEstudiantes(string? nombre);         
        Estudiante GetEstudiante(int? idEstudiante);
        Estudiante UpdateEstudiante(Estudiante estudiante);
        void DeleteEstudiante(int idEstudiante); 

        //firmas rol
        Rol AddRol(Rol rol);
        IEnumerable<Rol> GetAllRoles(string? nombre);         
        Rol GetRol(int? idRol);
        Rol UpdateRol(Rol rol);
        void DeleteRol(int idRol); 

        //firmas Estado Proyectos
        EstadoProyecto AddEstadoProyecto(EstadoProyecto estadoProyecto);
        IEnumerable<EstadoProyecto> GetAllEstadoProyectos(string? nombre);         
        EstadoProyecto GetEstadoProyecto(int? idEstadoProyecto);
        EstadoProyecto UpdateEstadoProyecto(EstadoProyecto estadoProyecto);
        void DeleteEstadoProyecto(int idEstadoProyecto); 

        //firmas estado tareas
        EstadoTarea AddEstadoTarea(EstadoTarea estadoTarea);
        IEnumerable<EstadoTarea> GetAllEstadoTareas(string? nombre);         
        EstadoTarea GetEstadoTarea(int? idEstadoTarea);
        EstadoTarea UpdateEstadoTarea(EstadoTarea estadoTarea);
        void DeleteEstadoTarea(int idEstadoTarea);

        //firmas equipos
        Equipo AddEquipo(Equipo equipo);
        IEnumerable<Equipo> GetAllEquipos(string? nombre);         
        Equipo GetEquipo(int? idEquipo);
        Equipo UpdateEquipo(Equipo equipo);
        void DeleteEquipo(int idEquipo);
    }
}