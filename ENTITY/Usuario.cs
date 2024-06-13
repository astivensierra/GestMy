using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    [FirestoreData]
    public class Usuario
    {
        [FirestoreProperty(Name = "id")]
        public int Id { get; set; }
        [FirestoreProperty]
        public string Nombre { get; set; } = string.Empty;
        [FirestoreProperty]
        public string Apellido { get; set; } = string.Empty; // Agregue la marca [FirestoreProperty]
        [FirestoreProperty]
        public List<string> repositorios { get; set; }
        [FirestoreProperty]
        public string Email { get; set; } = string.Empty; // Agregue la marca [FirestoreProperty]
        [FirestoreProperty]
        public string PasswordHash { get; set; } = string.Empty;
        [FirestoreProperty]
        public string Rol { get; set; } = string.Empty;
        [FirestoreProperty]
        public string TokenkGuihub { get; set; } = string.Empty;
        [FirestoreProperty]
        public List<Proyecto> Proyectos { get; set; } = new List<Proyecto>();

        // Constructores
        public Usuario() { }

        public Usuario(string nombre, string email, string passwordHash, string rol)
        {
            Nombre = nombre;
            Email = email;
            PasswordHash = passwordHash;
            Rol = rol;
        }

        // Métodos
        public void AsignarProyecto(Proyecto proyecto)
        {
            Proyectos.Add(proyecto);
        }

        public void ActualizarPerfil(string nombre, string email, string rol)
        {
            Nombre = nombre;
            Email = email;
            Rol = rol;
        }
    }
}
