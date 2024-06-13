using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Proyecto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public DateTime FechaDeInicio { get; set; }
        public DateTime FechaDeFinalizacion { get; set; }
        public List<Usuario> Integrantes { get; set; } = new List<Usuario>();
        public List<Tarea> Tareas { get; set; } = new List<Tarea>();

// Constructores
        public Proyecto(string nombre, string descripcion, DateTime fechaDeInicio, DateTime fechaDeFinalizacion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            FechaDeInicio = fechaDeInicio;
            FechaDeFinalizacion = fechaDeFinalizacion;
        }
        public Proyecto()
        {
        }

        // Métodos 
        public void AgregarIntegrante(Usuario usuario)
        {
            if (!Integrantes.Contains(usuario))
            {
                Integrantes.Add(usuario);
                usuario.AsignarProyecto(this);
            }
        }

        public void EliminarIntegrante(Usuario usuario)
        {
            if (Integrantes.Contains(usuario))
            {
                Integrantes.Remove(usuario);
                usuario.Proyectos.Remove(this);
            }
        }

        public void AgregarTarea(Tarea tarea)
        {
            if (!Tareas.Contains(tarea))
            {
                Tareas.Add(tarea);
            }
        }

        public void EditarProyecto(string nombre, string descripcion, DateTime fechaDeInicio, DateTime fechaDeFinalizacion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            FechaDeInicio = fechaDeInicio;
            FechaDeFinalizacion = fechaDeFinalizacion;
        }
    }
}
