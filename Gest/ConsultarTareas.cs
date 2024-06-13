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
using ENTITY;
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
            Tareas = new List<Tarea>();
            if (Tareas == null)
            {
                Tareas = firestore.GetTareas().GetAwaiter().GetResult();
            }
            Tarea p1 = new Tarea()
            {
                Nombre = "Realizar cosas",
                Descripcion = "Repositorio de carlos",
                FechaDeInicio = DateTime.Now.Date,
                FechaDeFinalizacion = DateTime.Now.Date
            };
            p1.Id = 2;
            p1.Responsable.Nombre = "carlos";
            p1.Proyecto = new Proyecto();
            p1.Proyecto.Nombre = "Repositorio de carlos";
            Tareas.Add(p1);
            Tareas.Add(p1);
            Tareas.Add(p1);

            if (Tareas != null)
            {
                tablaProyecto.Rows.Clear();
                foreach (var tarea in Tareas)
                {
                    tablaProyecto.Rows.Add(tarea.Id, tarea.Nombre, tarea.Descripcion, tarea.Responsable.Nombre, tarea.Proyecto.Nombre, tarea.FechaDeInicio, tarea.FechaDeFinalizacion);
                }
            }
        }
    }
}
