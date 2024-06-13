using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITY;
using BLL;

namespace Gest
{
    public partial class CrearTarea : Form
    {
        public CrearTarea()
        {
            InitializeComponent();
        }

        private void CrearTarea_Load(object sender, EventArgs e)
        {

            foreach (var item in MdiChildren)
            {
                FirestoreService firestoreService = new FirestoreService();
                List<Proyecto> proyectos = firestoreService.GetProyectos().Result;
                foreach (var proyecto in proyectos)
                {
                    cbproyecto.Items.Add(proyecto.Nombre);
                }
            }

        }

        private void vaciarCampos()
        {
            cbproyecto.SelectedIndex = -1;
            tbNombre.Text = "";
            tbDescripcion.Text = "";
            tbPropietario.Text = "";
            dtFechaFinal.Text = "";
            dtFechaInicio.Text = "";
        }

        private void btnCrearTarea_Click(object sender, EventArgs e)
        {
            FirestoreService firestoreService = new FirestoreService();
            Tarea tarea = new Tarea();
            tarea.Nombre = tbNombre.Text;
            tarea.Descripcion = tbDescripcion.Text;
            tarea.FechaDeInicio = DateTime.Parse(dtFechaInicio.Text);
            tarea.FechaDeFinalizacion = DateTime.Parse(dtFechaFinal.Text);
            List<Usuario> usuarios = new List<Usuario>();
            usuarios = firestoreService.GetUsuarios().GetAwaiter().GetResult();

            foreach (var user in usuarios)
            {
                if (user.Equals(tbPropietario.Text))
                {
                    tarea.Responsable = user;
                    foreach (var proyecto in user.Proyectos)
                    {
                        if (proyecto.Equals(cbproyecto.Items[cbproyecto.SelectedIndex]))
                        {
                            proyecto.Tareas.Add(tarea);
                            firestoreService.UpdateProyecto(proyecto.Id+"", proyecto);
                            firestoreService.CreateTarea(tarea);
                            vaciarCampos();
                        }
                    }
                }
            }
        }
    }
}
