using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BLL;

namespace Gest
{
    public partial class CrearTarea : Form
    {
        private FirestoreService firestoreService;

        public CrearTarea()
        {
            InitializeComponent();
            firestoreService = new FirestoreService();
        }

        private async void btnCrearTarea_Click(object sender, EventArgs e)
        {
            string nombreTarea = tbNombre.Text;
            string descripcionTarea = tbDescripcion.Text;
            string responsableEmail = tbPropietario.Text; // Obtener el email del responsable desde un TextBox u otro control
            string nombreProyecto = cbproyecto.Text; // Obtener el nombre del proyecto desde un ComboBox u otro control
            string fechaInicio = dtFechaInicio.Text;
            string fechaFinalizacion = dtFechaFinal.Text;

            // Validar que todos los campos estén completos
            if (string.IsNullOrWhiteSpace(nombreTarea) ||
                string.IsNullOrWhiteSpace(descripcionTarea) ||
                string.IsNullOrWhiteSpace(responsableEmail) ||
                string.IsNullOrWhiteSpace(nombreProyecto))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de continuar.");
                return;
            }

            // Buscar al usuario con el correo electrónico proporcionado
            List<Usuario> usuarios = await firestoreService.GetUsuarios();
            Usuario responsable = usuarios.FirstOrDefault(u => u.Email == responsableEmail);

            // Verificar si se encontró al usuario
            if (responsable == null)
            {
                MessageBox.Show("No se encontró al responsable en la base de datos.");
                return;
            }

            // Buscar el proyecto por su nombre
            List<Proyecto> proyectos = await firestoreService.GetProyectos();
            Proyecto proyectoSeleccionado = proyectos.FirstOrDefault(p => p.Nombre == nombreProyecto);

            // Verificar si se encontró el proyecto
            if (proyectoSeleccionado == null)
            {
                MessageBox.Show("No se encontró el proyecto en la base de datos.");
                return;
            }

            // Crear una nueva tarea asignando al responsable encontrado
            Tarea nuevaTarea = new Tarea(responsable)
            {
                Nombre = nombreTarea,
                Descripcion = descripcionTarea,
                FechaDeInicio = fechaInicio,
                FechaDeFinalizacion = fechaFinalizacion,
                ProyectoId = proyectoSeleccionado
            };

            // Lógica adicional, como guardar la tarea en Firestore
            await firestoreService.CreateTarea(nuevaTarea);

            MessageBox.Show("Tarea creada exitosamente.");
        }
    }
}
