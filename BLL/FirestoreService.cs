using DLL;
using ENTITY;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL
{
    public class FirestoreService
    {
        private readonly FirestoreRepository _firestoreRepository;

        public FirestoreService()
        {
            _firestoreRepository = new FirestoreRepository();
        }

        // Métodos para interactuar con el repositorio...

        public async Task CreateProyecto(Proyecto proyecto)
        {
            await _firestoreRepository.CreateProyecto(proyecto);
        }

        public async Task<List<Proyecto>> GetProyectos()
        {
            return await _firestoreRepository.GetProyectos();
        }

        public async Task<Proyecto> GetProyecto(string proyectoId)
        {
            return await _firestoreRepository.GetProyecto(proyectoId);
        }

        public async Task UpdateProyecto(string proyectoId, Proyecto proyecto)
        {
            await _firestoreRepository.UpdateProyecto(proyectoId, proyecto);
        }

        public async Task DeleteProyecto(string proyectoId)
        {
            await _firestoreRepository.DeleteProyecto(proyectoId);
        }

        public async Task CreateTarea(Tarea tarea)
        {
            await _firestoreRepository.CreateTarea(tarea);
        }

        public async Task<List<Tarea>> GetTareas()
        {
            return await _firestoreRepository.GetTareas();
        }

        public async Task<Tarea> GetTarea(string tareaId)
        {
            return await _firestoreRepository.GetTarea(tareaId);
        }

        public async Task UpdateTarea(string tareaId, Tarea tarea)
        {
            await _firestoreRepository.UpdateTarea(tareaId, tarea);
        }

        public async Task DeleteTarea(string tareaId)
        {
            await _firestoreRepository.DeleteTarea(tareaId);
        }

        public async Task CreateUsuario(Usuario usuario)
        {
            await _firestoreRepository.CreateUsuario(usuario);
        }

        public async Task<List<Usuario>> GetUsuarios()
        {
            return await _firestoreRepository.GetUsuarios();
        }

        public async Task<Usuario> GetUsuario(string usuarioId)
        {
            return await _firestoreRepository.GetUsuario(usuarioId);
        }

        public async Task UpdateUsuario(string usuarioId, Usuario usuario)
        {
            await _firestoreRepository.UpdateUsuario(usuarioId, usuario);
        }

        public async Task<bool> ExisteUsuarioConCorreoElectronico(string correoElectronico)
        {
            List<Usuario> usuarios = await GetUsuarios();
            return usuarios.Any(u => u.Email.ToLower() == correoElectronico.ToLower());
        }

        public async Task DeleteUsuario(string usuarioId)
        {
            await _firestoreRepository.DeleteUsuario(usuarioId);
        }
    }
}