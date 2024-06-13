namespace Gest
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelSideMenu = new Panel();
            panelTareasSubmenu = new Panel();
            ButtonActivosTareas = new Button();
            ButtonEnEsperaTareas = new Button();
            ButtonTerminadosTareas = new Button();
            ButtonCrearTareas = new Button();
            ButtonTareas = new Button();
            panelProjectosSubmenu = new Panel();
            ButtonProjectosActivos = new Button();
            ButtonProjectosEnEspera = new Button();
            ButtonProjectosTerminados = new Button();
            ButtonProjectosCrear = new Button();
            ButtonProjectos = new Button();
            panelLogo = new Panel();
            app_bar = new Panel();
            pnltabla = new Panel();
            panelSideMenu.SuspendLayout();
            panelTareasSubmenu.SuspendLayout();
            panelProjectosSubmenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.BackColor = SystemColors.ActiveCaption;
            panelSideMenu.Controls.Add(panelTareasSubmenu);
            panelSideMenu.Controls.Add(ButtonTareas);
            panelSideMenu.Controls.Add(panelProjectosSubmenu);
            panelSideMenu.Controls.Add(ButtonProjectos);
            panelSideMenu.Controls.Add(panelLogo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(227, 629);
            panelSideMenu.TabIndex = 0;
            // 
            // panelTareasSubmenu
            // 
            panelTareasSubmenu.BackColor = SystemColors.ActiveCaption;
            panelTareasSubmenu.Controls.Add(ButtonActivosTareas);
            panelTareasSubmenu.Controls.Add(ButtonEnEsperaTareas);
            panelTareasSubmenu.Controls.Add(ButtonTerminadosTareas);
            panelTareasSubmenu.Controls.Add(ButtonCrearTareas);
            panelTareasSubmenu.Dock = DockStyle.Top;
            panelTareasSubmenu.Location = new Point(0, 348);
            panelTareasSubmenu.Name = "panelTareasSubmenu";
            panelTareasSubmenu.Size = new Size(227, 167);
            panelTareasSubmenu.TabIndex = 4;
            // 
            // ButtonActivosTareas
            // 
            ButtonActivosTareas.BackColor = SystemColors.ButtonFace;
            ButtonActivosTareas.Cursor = Cursors.Hand;
            ButtonActivosTareas.Dock = DockStyle.Top;
            ButtonActivosTareas.FlatAppearance.BorderSize = 0;
            ButtonActivosTareas.FlatStyle = FlatStyle.Flat;
            ButtonActivosTareas.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonActivosTareas.ForeColor = SystemColors.ActiveCaptionText;
            ButtonActivosTareas.Location = new Point(0, 120);
            ButtonActivosTareas.Name = "ButtonActivosTareas";
            ButtonActivosTareas.Size = new Size(227, 40);
            ButtonActivosTareas.TabIndex = 5;
            ButtonActivosTareas.Text = "Activos";
            ButtonActivosTareas.UseVisualStyleBackColor = false;
            ButtonActivosTareas.Click += ButtonActivosTareas_Click;
            // 
            // ButtonEnEsperaTareas
            // 
            ButtonEnEsperaTareas.BackColor = SystemColors.ButtonFace;
            ButtonEnEsperaTareas.Cursor = Cursors.Hand;
            ButtonEnEsperaTareas.Dock = DockStyle.Top;
            ButtonEnEsperaTareas.FlatAppearance.BorderSize = 0;
            ButtonEnEsperaTareas.FlatStyle = FlatStyle.Flat;
            ButtonEnEsperaTareas.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonEnEsperaTareas.ForeColor = SystemColors.ActiveCaptionText;
            ButtonEnEsperaTareas.Location = new Point(0, 80);
            ButtonEnEsperaTareas.Name = "ButtonEnEsperaTareas";
            ButtonEnEsperaTareas.Size = new Size(227, 40);
            ButtonEnEsperaTareas.TabIndex = 4;
            ButtonEnEsperaTareas.Text = "En espera";
            ButtonEnEsperaTareas.UseVisualStyleBackColor = false;
            ButtonEnEsperaTareas.Click += ButtonEnEsperaTareas_Click;
            // 
            // ButtonTerminadosTareas
            // 
            ButtonTerminadosTareas.BackColor = SystemColors.ButtonFace;
            ButtonTerminadosTareas.Cursor = Cursors.Hand;
            ButtonTerminadosTareas.Dock = DockStyle.Top;
            ButtonTerminadosTareas.FlatAppearance.BorderSize = 0;
            ButtonTerminadosTareas.FlatStyle = FlatStyle.Flat;
            ButtonTerminadosTareas.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonTerminadosTareas.ForeColor = SystemColors.ActiveCaptionText;
            ButtonTerminadosTareas.Location = new Point(0, 40);
            ButtonTerminadosTareas.Name = "ButtonTerminadosTareas";
            ButtonTerminadosTareas.Size = new Size(227, 40);
            ButtonTerminadosTareas.TabIndex = 3;
            ButtonTerminadosTareas.Text = "Terminados";
            ButtonTerminadosTareas.UseVisualStyleBackColor = false;
            ButtonTerminadosTareas.Click += ButtonTerminadosTareas_Click;
            // 
            // ButtonCrearTareas
            // 
            ButtonCrearTareas.BackColor = SystemColors.ButtonFace;
            ButtonCrearTareas.Cursor = Cursors.Hand;
            ButtonCrearTareas.Dock = DockStyle.Top;
            ButtonCrearTareas.FlatAppearance.BorderSize = 0;
            ButtonCrearTareas.FlatStyle = FlatStyle.Flat;
            ButtonCrearTareas.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonCrearTareas.ForeColor = SystemColors.ActiveCaptionText;
            ButtonCrearTareas.Location = new Point(0, 0);
            ButtonCrearTareas.Name = "ButtonCrearTareas";
            ButtonCrearTareas.Size = new Size(227, 40);
            ButtonCrearTareas.TabIndex = 2;
            ButtonCrearTareas.Text = "Crear";
            ButtonCrearTareas.UseVisualStyleBackColor = false;
            ButtonCrearTareas.Click += ButtonCrearTareas_Click;
            // 
            // ButtonTareas
            // 
            ButtonTareas.BackColor = SystemColors.ButtonFace;
            ButtonTareas.Cursor = Cursors.Hand;
            ButtonTareas.Dock = DockStyle.Top;
            ButtonTareas.FlatAppearance.BorderSize = 0;
            ButtonTareas.FlatStyle = FlatStyle.Flat;
            ButtonTareas.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonTareas.ForeColor = SystemColors.ActiveCaptionText;
            ButtonTareas.Location = new Point(0, 308);
            ButtonTareas.Name = "ButtonTareas";
            ButtonTareas.Size = new Size(227, 40);
            ButtonTareas.TabIndex = 3;
            ButtonTareas.Text = "Tareas";
            ButtonTareas.UseVisualStyleBackColor = false;
            ButtonTareas.Click += ButtonTareas_Click;
            // 
            // panelProjectosSubmenu
            // 
            panelProjectosSubmenu.BackColor = SystemColors.ActiveCaption;
            panelProjectosSubmenu.Controls.Add(ButtonProjectosActivos);
            panelProjectosSubmenu.Controls.Add(ButtonProjectosEnEspera);
            panelProjectosSubmenu.Controls.Add(ButtonProjectosTerminados);
            panelProjectosSubmenu.Controls.Add(ButtonProjectosCrear);
            panelProjectosSubmenu.Dock = DockStyle.Top;
            panelProjectosSubmenu.Location = new Point(0, 141);
            panelProjectosSubmenu.Name = "panelProjectosSubmenu";
            panelProjectosSubmenu.Size = new Size(227, 167);
            panelProjectosSubmenu.TabIndex = 2;
            // 
            // ButtonProjectosActivos
            // 
            ButtonProjectosActivos.BackColor = SystemColors.ButtonFace;
            ButtonProjectosActivos.Cursor = Cursors.Hand;
            ButtonProjectosActivos.Dock = DockStyle.Top;
            ButtonProjectosActivos.FlatAppearance.BorderSize = 0;
            ButtonProjectosActivos.FlatStyle = FlatStyle.Flat;
            ButtonProjectosActivos.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonProjectosActivos.ForeColor = SystemColors.ActiveCaptionText;
            ButtonProjectosActivos.Location = new Point(0, 120);
            ButtonProjectosActivos.Name = "ButtonProjectosActivos";
            ButtonProjectosActivos.Size = new Size(227, 40);
            ButtonProjectosActivos.TabIndex = 5;
            ButtonProjectosActivos.Text = "Activos";
            ButtonProjectosActivos.UseVisualStyleBackColor = false;
            ButtonProjectosActivos.Click += ButtonProjectosActivos_Click;
            // 
            // ButtonProjectosEnEspera
            // 
            ButtonProjectosEnEspera.BackColor = SystemColors.ButtonFace;
            ButtonProjectosEnEspera.Cursor = Cursors.Hand;
            ButtonProjectosEnEspera.Dock = DockStyle.Top;
            ButtonProjectosEnEspera.FlatAppearance.BorderSize = 0;
            ButtonProjectosEnEspera.FlatStyle = FlatStyle.Flat;
            ButtonProjectosEnEspera.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonProjectosEnEspera.ForeColor = SystemColors.ActiveCaptionText;
            ButtonProjectosEnEspera.Location = new Point(0, 80);
            ButtonProjectosEnEspera.Name = "ButtonProjectosEnEspera";
            ButtonProjectosEnEspera.Size = new Size(227, 40);
            ButtonProjectosEnEspera.TabIndex = 4;
            ButtonProjectosEnEspera.Text = "En espera";
            ButtonProjectosEnEspera.UseVisualStyleBackColor = false;
            ButtonProjectosEnEspera.Click += ButtonProjectosEnEspera_Click;
            // 
            // ButtonProjectosTerminados
            // 
            ButtonProjectosTerminados.BackColor = SystemColors.ButtonFace;
            ButtonProjectosTerminados.Cursor = Cursors.Hand;
            ButtonProjectosTerminados.Dock = DockStyle.Top;
            ButtonProjectosTerminados.FlatAppearance.BorderSize = 0;
            ButtonProjectosTerminados.FlatStyle = FlatStyle.Flat;
            ButtonProjectosTerminados.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonProjectosTerminados.ForeColor = SystemColors.ActiveCaptionText;
            ButtonProjectosTerminados.Location = new Point(0, 40);
            ButtonProjectosTerminados.Name = "ButtonProjectosTerminados";
            ButtonProjectosTerminados.Size = new Size(227, 40);
            ButtonProjectosTerminados.TabIndex = 3;
            ButtonProjectosTerminados.Text = "Terminados";
            ButtonProjectosTerminados.UseVisualStyleBackColor = false;
            ButtonProjectosTerminados.Click += ButtonProjectosTerminados_Click;
            // 
            // ButtonProjectosCrear
            // 
            ButtonProjectosCrear.BackColor = SystemColors.ButtonFace;
            ButtonProjectosCrear.Cursor = Cursors.Hand;
            ButtonProjectosCrear.Dock = DockStyle.Top;
            ButtonProjectosCrear.FlatAppearance.BorderSize = 0;
            ButtonProjectosCrear.FlatStyle = FlatStyle.Flat;
            ButtonProjectosCrear.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonProjectosCrear.ForeColor = SystemColors.ActiveCaptionText;
            ButtonProjectosCrear.Location = new Point(0, 0);
            ButtonProjectosCrear.Name = "ButtonProjectosCrear";
            ButtonProjectosCrear.Size = new Size(227, 40);
            ButtonProjectosCrear.TabIndex = 2;
            ButtonProjectosCrear.Text = "Crear";
            ButtonProjectosCrear.UseVisualStyleBackColor = false;
            ButtonProjectosCrear.Click += ButtonProjectosCrear_Click;
            // 
            // ButtonProjectos
            // 
            ButtonProjectos.BackColor = SystemColors.ButtonFace;
            ButtonProjectos.Cursor = Cursors.Hand;
            ButtonProjectos.Dock = DockStyle.Top;
            ButtonProjectos.FlatAppearance.BorderSize = 0;
            ButtonProjectos.FlatStyle = FlatStyle.Flat;
            ButtonProjectos.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonProjectos.ForeColor = SystemColors.ActiveCaptionText;
            ButtonProjectos.Location = new Point(0, 101);
            ButtonProjectos.Name = "ButtonProjectos";
            ButtonProjectos.Size = new Size(227, 40);
            ButtonProjectos.TabIndex = 1;
            ButtonProjectos.Text = "Projectos";
            ButtonProjectos.UseVisualStyleBackColor = false;
            ButtonProjectos.Click += ButtonProjectos_Click;
            // 
            // panelLogo
            // 
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(227, 101);
            panelLogo.TabIndex = 0;
            // 
            // app_bar
            // 
            app_bar.Location = new Point(233, 3);
            app_bar.Name = "app_bar";
            app_bar.Size = new Size(731, 60);
            app_bar.TabIndex = 1;
            // 
            // pnltabla
            // 
            pnltabla.Location = new Point(233, 101);
            pnltabla.Name = "pnltabla";
            pnltabla.Size = new Size(731, 528);
            pnltabla.TabIndex = 2;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 629);
            Controls.Add(pnltabla);
            Controls.Add(app_bar);
            Controls.Add(panelSideMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Principal";
            Text = "Principal";
            Load += Principal_Load;
            panelSideMenu.ResumeLayout(false);
            panelTareasSubmenu.ResumeLayout(false);
            panelProjectosSubmenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideMenu;
        private Panel app_bar;
        private Button ButtonProjectos;
        private Panel panelLogo;
        private Panel panelProjectosSubmenu;
        private Button ButtonProjectosTerminados;
        private Button ButtonProjectosCrear;
        private Button ButtonProjectosActivos;
        private Button ButtonProjectosEnEspera;
        private Panel panelTareasSubmenu;
        private Button ButtonActivosTareas;
        private Button ButtonEnEsperaTareas;
        private Button ButtonTerminadosTareas;
        private Button ButtonCrearTareas;
        private Button ButtonTareas;
        private Panel pnltabla;
    }
}