using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ENTITY
{
    [FirestoreData]
    public class Tarea
    {
        [FirestoreProperty]
        public int Id { get; set; }
        [FirestoreProperty]
        public string Nombre { get; set; } = string.Empty;
        [FirestoreProperty]
        public string Descripcion { get; set; } = string.Empty;
        [FirestoreProperty]
        public DateTime FechaDeInicio { get; set; }
        [FirestoreProperty]
        public DateTime FechaDeFinalizacion { get; set; }
        [FirestoreProperty]
        public Usuario Responsable { get; set; } = new Usuario();
        [FirestoreProperty]
        public Proyecto Proyecto { get; set; }
        [FirestoreProperty]
        public string Estado { get; set; } = string.Empty;
        [FirestoreProperty]
        public List<string> Comentarios { get; set; } = new List<string>();

        // Constructor que acepta argumentos
        public Tarea(Usuario responsable)
        {
            Responsable = responsable ?? throw new ArgumentNullException(nameof(responsable));
        }
      
        public Tarea()
        {

        }

        // Métodos 
        public void AsignarResponsable(Usuario usuario)
        {
            Responsable = usuario ?? throw new ArgumentNullException(nameof(usuario));
        }

        public void ActualizarEstado(string nuevoEstado)
        {
            Estado = nuevoEstado;
        }

        public void AgregarComentario(string comentario)
        {
            Comentarios.Add(comentario);
        }

        public void EditarTarea(string nombre, string descripcion, DateTime fechaDeInicio, DateTime fechaDeFinalizacion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            FechaDeInicio = fechaDeInicio;
            FechaDeFinalizacion = fechaDeFinalizacion;
        }
    }
}
