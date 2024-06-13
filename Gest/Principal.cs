using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gest
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            customizeDesing();

        }

        private void customizeDesing()
        {
            panelProjectosSubmenu.Visible = false;
            panelTareasSubmenu.Visible = false;
        }

        private void hideSubmenu()
        {
            if (panelProjectosSubmenu.Visible == true)
                panelProjectosSubmenu.Visible = false;

            if (panelTareasSubmenu.Visible == true)
                panelTareasSubmenu.Visible = false;
        }

        private void ShowSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void Principal_Load(object sender, EventArgs e)
        {
            
            
        }

        private void ButtonProjectos_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelProjectosSubmenu);

            ConsultarProyectos consultarProyectos = new ConsultarProyectos();
            consultarProyectos.Show();
            consultarProyectos.TopLevel = false;
            consultarProyectos.Top = 0;
            consultarProyectos.Left = 0;
            pnltabla.Controls.Clear();
            pnltabla.Controls.Add(consultarProyectos);
        }

        private void ButtonProjectosCrear_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            CrearProyecto crearProyecto = new CrearProyecto()
            {
                TopLevel = false,
                Location = new Point(0, 0),
                Dock = DockStyle.None
            };
            crearProyecto.Show();
            pnltabla.Controls.Clear();
            pnltabla.Controls.Add(crearProyecto);
        }

        private void ButtonProjectosTerminados_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void ButtonProjectosEnEspera_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void ButtonProjectosActivos_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void ButtonTareas_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelTareasSubmenu);
            ConsultarTareas consultar = new ConsultarTareas()
            {
                TopLevel = false,
                Location = new Point(0, 0),
                Dock = DockStyle.None
            };
            consultar.Show();
            pnltabla.Controls.Clear();
            pnltabla.Controls.Add(consultar);
        }

        private void ButtonCrearTareas_Click(object sender, EventArgs e)
        {
            hideSubmenu();
            CrearTarea crearTarea = new CrearTarea()
            {
                TopLevel=false,
                Location = new Point(0, 0),
                Dock = DockStyle.None
            };
            crearTarea.Show();
            pnltabla.Controls.Clear();
            pnltabla.Controls.Add(crearTarea);
        }

        private void ButtonTerminadosTareas_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void ButtonEnEsperaTareas_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void ButtonActivosTareas_Click(object sender, EventArgs e)
        {
            hideSubmenu();
        }
    }
}
