using System;

namespace Proyectos.App.Dominio
{
    public class Equipo
    {
        //atributos de la tabla o clase; pasa a llamarsen propiedades
        public int id { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string meet { get; set; }
        public string whatapp { get; set; }
        public int formador { get; set; }
        public int tutor { get; set; }
    }
}