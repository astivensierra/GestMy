using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ENTITY
{
    [FirestoreData]
    public class Proyecto
    {
        [FirestoreProperty(Name = "id")]
        public int Id { get; set; }
        [FirestoreProperty]
        public string Nombre { get; set; } = string.Empty;
        [FirestoreProperty]
        public string Descripcion { get; set; } = string.Empty;
        [FirestoreProperty]
        public string FechaDeInicio { get; set; }
        [FirestoreProperty]
        public string FechaDeFinalizacion { get; set; }
        [FirestoreProperty]
        public List<Usuario> Integrantes { get; set; } = new List<Usuario>();
        [FirestoreProperty]
        public List<Tarea> Tareas { get; set; } = new List<Tarea>();

// Constructores
        public Proyecto(string nombre, string descripcion, string fechaDeInicio, string fechaDeFinalizacion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            FechaDeInicio = fechaDeInicio;
            FechaDeFinalizacion = fechaDeFinalizacion;
        }

        public Proyecto(string nombre, string descripcion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            
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

        public void EditarProyecto(string nombre, string descripcion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
        }
    }
}
