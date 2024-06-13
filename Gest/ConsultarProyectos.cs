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
using Google.Cloud.Firestore;


namespace Gest
{
    public partial class ConsultarProyectos : Form
    {
        private List<Proyecto> Proyectos;
        private FirestoreService firestore = new FirestoreService();

        public ConsultarProyectos()
        {
            this.Visible = true;
            InitializeComponent();

            Rellenar();

        }

        private void ConsultarProyectos_Load(object sender, EventArgs e)
        {
            
        }



        private void Rellenar()
        {

            Proyectos = new List<Proyecto>();
            if (Proyectos.Count <= 0)
            {
                Proyectos = firestore.GetProyectos().Result;
            }
            if (Proyectos.Count >= 0)
            {
                tablaProyecto.Rows.Clear();
                foreach (var proyecto in Proyectos)
                {
                    tablaProyecto.Rows.Add(proyecto.Id, proyecto.Nombre, proyecto.Descripcion, proyecto.FechaDeInicio, proyecto.FechaDeFinalizacion);
                }
            }
        }

        private void tablaProyecto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
