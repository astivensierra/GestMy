using ENTITY;
using Google.Cloud.Firestore.V1;
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

namespace Gest
{
    public partial class ConsultarTareas : Form
    {
        List<Tarea> Tareas;
        FirestoreService firestore = new FirestoreService();
        public ConsultarTareas()
        {
            InitializeComponent();
            llenarTabla();
        }

        private void tablaProyecto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void llenarTabla()
        {
          
        }
    }
}
