using System;
using System.Collections.Generic;
using System.Linq;
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
            InitializeComponent();
            Rellenar();
        }

        private void ConsultarProyectos_Load(object sender, EventArgs e)
        {
            // Este método puede quedar vacío o puedes inicializar otras cosas aquí si es necesario
        }

        private async void Rellenar()
        {
            try
            {
                // Obtener los proyectos desde Firestore
                Proyectos = await firestore.GetProyectos();

                // Si se obtienen proyectos, llenar el DataGridView
                if (Proyectos != null && Proyectos.Any())
                {
                    tablaProyecto.Rows.Clear();
                    foreach (var proyecto in Proyectos)
                    {
                        tablaProyecto.Rows.Add(proyecto.Id, proyecto.Nombre, proyecto.Descripcion, proyecto.FechaDeInicio, proyecto.FechaDeFinalizacion);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron proyectos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los proyectos: {ex.Message}");
            }
        }

        private void tablaProyecto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Puedes manejar los eventos de clic en las celdas aquí si es necesario
        }
    }
}
