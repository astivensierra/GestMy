using ENTITY;
using Google.Cloud.Firestore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DLL
{
    public class FirestoreRepository
    {
        private readonly FirestoreDb _firestoreDb;

        public FirestoreRepository()
        {
            FirestoreHelper.SetEnvironmentVariable();
            _firestoreDb = FirestoreHelper.Database ?? throw new InvalidOperationException("No se pudo inicializar Firestore.");
        }

        // Métodos para interactuar con Firestore...

        public async Task CreateProyecto(Proyecto proyecto)
        {
            await _firestoreDb.Collection("proyectos").AddAsync(proyecto);
        }

        public async Task<List<Proyecto>> GetProyectos()
        {
            QuerySnapshot snapshot = await _firestoreDb.Collection("proyectos").GetSnapshotAsync();
            return snapshot.Documents.Select(document => document.ConvertTo<Proyecto>()).ToList();
        }

        public async Task<Proyecto> GetProyecto(string proyectoId)
        {
            DocumentSnapshot document = await _firestoreDb.Collection("proyectos").Document(proyectoId).GetSnapshotAsync();
            return document.ConvertTo<Proyecto>();
        }

        public async Task UpdateProyecto(string proyectoId, Proyecto proyecto)
        {
            await _firestoreDb.Collection("proyectos").Document(proyectoId).SetAsync(proyecto);
        }

        public async Task DeleteProyecto(string proyectoId)
        {
            await _firestoreDb.Collection("proyectos").Document(proyectoId).DeleteAsync();
        }

        public async Task CreateTarea(Tarea tarea)
        {
            await _firestoreDb.Collection("tareas").AddAsync(tarea);
        }

        public async Task<List<Tarea>> GetTareas()
        {
            QuerySnapshot snapshot = await _firestoreDb.Collection("tareas").GetSnapshotAsync();
            return snapshot.Documents.Select(document => document.ConvertTo<Tarea>()).ToList();
        }

        public async Task<Tarea> GetTarea(string tareaId)
        {
            DocumentSnapshot document = await _firestoreDb.Collection("tareas").Document(tareaId).GetSnapshotAsync();
            return document.ConvertTo<Tarea>();
        }

        public async Task UpdateTarea(string tareaId, Tarea tarea)
        {
            await _firestoreDb.Collection("tareas").Document(tareaId).SetAsync(tarea);
        }

        public async Task DeleteTarea(string tareaId)
        {
            await _firestoreDb.Collection("tareas").Document(tareaId).DeleteAsync();
        }

        public async Task CreateUsuario(Usuario usuario)
        {
            await _firestoreDb.Collection("usuarios").AddAsync(usuario);
        }

        public async Task<List<Usuario>> GetUsuarios()
        {
            QuerySnapshot snapshot = await _firestoreDb.Collection("usuarios").GetSnapshotAsync();
            return snapshot.Documents.Select(document => document.ConvertTo<Usuario>()).ToList();
        }

        public async Task<Usuario> GetUsuario(string usuarioId)
        {
            DocumentSnapshot document = await _firestoreDb.Collection("usuarios").Document(usuarioId).GetSnapshotAsync();
            return document.ConvertTo<Usuario>();
        }

        public async Task UpdateUsuario(string usuarioId, Usuario usuario)
        {
            await _firestoreDb.Collection("usuarios").Document(usuarioId).SetAsync(usuario);
        }

        public async Task DeleteUsuario(string usuarioId)
        {
            await _firestoreDb.Collection("usuarios").Document(usuarioId).DeleteAsync();
        }
    }
}