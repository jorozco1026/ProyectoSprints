using System;

namespace Proyectos.App.Dominio
{
    public class Estudiante
    {
        //atributos de la tabla o clase; pasa a llamarsen propiedades
        public int id { get; set; }
        public string identificacion { get; set; }
        public string nombre { get; set; }
        public string mail { get; set; }
        public string movil { get; set; }
    }
}