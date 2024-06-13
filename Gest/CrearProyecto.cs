using ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Google.Cloud.Firestore;

namespace Gest
{
    public partial class CrearProyecto : Form
    {
        public CrearProyecto()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btnCrear_Click(object sender, EventArgs e)
        {
            string nombreProyecto = tbNombre.Text;
            string descripcionProyecto = tbDescripcion.Text;
            string propietario = tbPropietario.Text;
            string repositorio = tbRepositorio.Text;
            string FechaDeInicio = dtFechaInicio.Text;
            string FechaDeFinalizacion = dtFechaFinal.Text;


            if (string.IsNullOrWhiteSpace(nombreProyecto) ||
                string.IsNullOrWhiteSpace(descripcionProyecto) ||
                string.IsNullOrWhiteSpace(propietario) ||
                string.IsNullOrWhiteSpace(repositorio) ||
                string.IsNullOrWhiteSpace(FechaDeInicio) ||
                string.IsNullOrWhiteSpace (FechaDeFinalizacion))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de continuar.");
                return;
            }
            FirestoreService firestoreService = new FirestoreService();

            if (!await firestoreService.ExisteUsuarioConCorreoElectronico(propietario))
            {
                MessageBox.Show("El propietario no existe en la base de datos.");
                return;
            }
            Proyecto proyecto = new Proyecto
            {
                Nombre = nombreProyecto,
                Descripcion = descripcionProyecto,
                FechaDeInicio = dtFechaInicio.Text,
                FechaDeFinalizacion = dtFechaFinal.Text,
            };
            List<Usuario> usuarios = await firestoreService.GetUsuarios();

            Usuario propietarioUsuario = usuarios.FirstOrDefault(u => u.Email == propietario);

            if (propietarioUsuario == null)
            {
                MessageBox.Show("No se pudo encontrar al propietario en la base de datos.");
                return;
            }

            propietarioUsuario.Proyectos.Add(proyecto);

            await firestoreService.UpdateUsuario(propietarioUsuario.Id.ToString(), propietarioUsuario);

            await firestoreService.CreateProyecto(proyecto);

            MessageBox.Show("Proyecto creado exitosamente.");
        }
    }
}
