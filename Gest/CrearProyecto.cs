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
using ENTITY;
using BLL;

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
            FirestoreService firestoreService = new FirestoreService();
            Proyecto proyecto = new Proyecto();
            proyecto.Nombre = tbNombre.Text;
            proyecto.Descripcion = tbDescripcion.Text;
            proyecto.FechaDeInicio = DateTime.Parse(dtFechaInicio.Text);
            proyecto.FechaDeFinalizacion = DateTime.Parse(dtFechaFinal.Text);

            List<Usuario> usuarios = await firestoreService.GetUsuarios();
            bool repoExiste = false;
            foreach (var user in usuarios)
            {
                if (user.Equals(tbPropietario.Text))
                {
                    user.Proyectos.Add(proyecto);
                    foreach (var repo in user.repositorios)
                    {
                        if (repo.Equals(tbRepositorio.Text))
                        {
                            repoExiste = true;
                        }
                    }
                    if (!repoExiste)
                    {
                        user.repositorios.Add(tbRepositorio.Text);
                        await firestoreService.UpdateUsuario(user.Id + "", user);
                        await firestoreService.CreateProyecto(proyecto);
                    }
                }
            }
        }


    }
    
}
