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
            if (Proyectos == null)
            {
                Proyectos = firestore.GetProyectos().GetAwaiter().GetResult();
            }
            Proyecto p1 = new Proyecto("carlos", "Repositorio de carlos", DateTime.Now.Date, DateTime.Now.Date);
            Proyecto p2 = new Proyecto("carlos", "Repositorio de carlos", DateTime.Now.Date, DateTime.Now.Date);
            Proyecto p3 = new Proyecto("carlos", "Repositorio de carlos", DateTime.Now.Date, DateTime.Now.Date);
            p1.Id = p2.Id = p3.Id = 2;
            Proyectos.Add(p1);
            Proyectos.Add(p2);
            Proyectos.Add(p3);

            if (Proyectos != null)
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
