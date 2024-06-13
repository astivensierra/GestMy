namespace Gest
{
    partial class ConsultarTareas
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
            pnlTabla = new Panel();
            tablaProyecto = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Responsable = new DataGridViewTextBoxColumn();
            NombreProyecto = new DataGridViewTextBoxColumn();
            FechaInicio = new DataGridViewTextBoxColumn();
            FechaFinalizacion = new DataGridViewTextBoxColumn();
            lblTitulo = new Label();
            pnlTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaProyecto).BeginInit();
            SuspendLayout();
            // 
            // pnlTabla
            // 
            pnlTabla.AutoScroll = true;
            pnlTabla.AutoSize = true;
            pnlTabla.Controls.Add(tablaProyecto);
            pnlTabla.Location = new Point(0, 174);
            pnlTabla.Name = "pnlTabla";
            pnlTabla.Size = new Size(823, 420);
            pnlTabla.TabIndex = 0;
            // 
            // tablaProyecto
            // 
            tablaProyecto.AllowUserToAddRows = false;
            tablaProyecto.AllowUserToDeleteRows = false;
            tablaProyecto.AllowUserToResizeColumns = false;
            tablaProyecto.AllowUserToResizeRows = false;
            tablaProyecto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tablaProyecto.BorderStyle = BorderStyle.None;
            tablaProyecto.ColumnHeadersHeight = 29;
            tablaProyecto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            tablaProyecto.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Descripcion, Responsable, NombreProyecto, FechaInicio, FechaFinalizacion });
            tablaProyecto.Dock = DockStyle.Fill;
            tablaProyecto.Location = new Point(0, 0);
            tablaProyecto.Margin = new Padding(3, 4, 3, 4);
            tablaProyecto.Name = "tablaProyecto";
            tablaProyecto.ReadOnly = true;
            tablaProyecto.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            tablaProyecto.Size = new Size(823, 420);
            tablaProyecto.TabIndex = 1;
            tablaProyecto.CellContentClick += tablaProyecto_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Resizable = DataGridViewTriState.False;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Resizable = DataGridViewTriState.False;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            Descripcion.Resizable = DataGridViewTriState.False;
            // 
            // Responsable
            // 
            Responsable.HeaderText = "Responsable";
            Responsable.MinimumWidth = 6;
            Responsable.Name = "Responsable";
            Responsable.ReadOnly = true;
            Responsable.Resizable = DataGridViewTriState.False;
            // 
            // NombreProyecto
            // 
            NombreProyecto.HeaderText = "Proyecto";
            NombreProyecto.MinimumWidth = 6;
            NombreProyecto.Name = "NombreProyecto";
            NombreProyecto.ReadOnly = true;
            NombreProyecto.Resizable = DataGridViewTriState.False;
            // 
            // FechaInicio
            // 
            FechaInicio.HeaderText = "Fecha Inicio";
            FechaInicio.MinimumWidth = 6;
            FechaInicio.Name = "FechaInicio";
            FechaInicio.ReadOnly = true;
            FechaInicio.Resizable = DataGridViewTriState.False;
            // 
            // FechaFinalizacion
            // 
            FechaFinalizacion.HeaderText = "FechaFinalizacion";
            FechaFinalizacion.MinimumWidth = 6;
            FechaFinalizacion.Name = "FechaFinalizacion";
            FechaFinalizacion.ReadOnly = true;
            FechaFinalizacion.Resizable = DataGridViewTriState.False;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(301, 68);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(95, 35);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Tareas";
            // 
            // ConsultarTareas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(867, 600);
            Controls.Add(lblTitulo);
            Controls.Add(pnlTabla);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ConsultarTareas";
            Text = "ConsultarTareas";
            pnlTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tablaProyecto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTabla;
        private DataGridView tablaProyecto;
        private Label lblTitulo;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Responsable;
        private DataGridViewTextBoxColumn NombreProyecto;
        private DataGridViewTextBoxColumn FechaInicio;
        private DataGridViewTextBoxColumn FechaFinalizacion;
    }
}