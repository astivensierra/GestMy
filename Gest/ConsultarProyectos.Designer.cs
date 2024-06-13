namespace Gest
{
    partial class ConsultarProyectos
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
            pnltabla = new Panel();
            tablaProyecto = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            FechaInicio = new DataGridViewTextBoxColumn();
            FechaFinalizacion = new DataGridViewTextBoxColumn();
            lblTitulo = new Label();
            pnltabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaProyecto).BeginInit();
            SuspendLayout();
            // 
            // pnltabla
            // 
            pnltabla.Controls.Add(tablaProyecto);
            pnltabla.Location = new Point(0, 133);
            pnltabla.Name = "pnltabla";
            pnltabla.Size = new Size(720, 315);
            pnltabla.TabIndex = 0;
            // 
            // tablaProyecto
            // 
            tablaProyecto.AllowUserToAddRows = false;
            tablaProyecto.AllowUserToDeleteRows = false;
            tablaProyecto.AllowUserToResizeColumns = false;
            tablaProyecto.AllowUserToResizeRows = false;
            tablaProyecto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tablaProyecto.BorderStyle = BorderStyle.None;
            tablaProyecto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaProyecto.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Descripcion, FechaInicio, FechaFinalizacion });
            tablaProyecto.Dock = DockStyle.Fill;
            tablaProyecto.Location = new Point(0, 0);
            tablaProyecto.Name = "tablaProyecto";
            tablaProyecto.ReadOnly = true;
            tablaProyecto.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            tablaProyecto.Size = new Size(720, 315);
            tablaProyecto.TabIndex = 0;
            tablaProyecto.CellContentClick += tablaProyecto_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Resizable = DataGridViewTriState.True;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Resizable = DataGridViewTriState.True;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            Descripcion.Resizable = DataGridViewTriState.True;
            // 
            // FechaInicio
            // 
            FechaInicio.HeaderText = "Fecha Inicio";
            FechaInicio.Name = "FechaInicio";
            FechaInicio.ReadOnly = true;
            FechaInicio.Resizable = DataGridViewTriState.True;
            // 
            // FechaFinalizacion
            // 
            FechaFinalizacion.HeaderText = "FechaFinalizacion";
            FechaFinalizacion.Name = "FechaFinalizacion";
            FechaFinalizacion.ReadOnly = true;
            FechaFinalizacion.Resizable = DataGridViewTriState.True;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(272, 48);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(101, 27);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Proyectos";
            // 
            // ConsultarProyectos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 450);
            Controls.Add(lblTitulo);
            Controls.Add(pnltabla);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ConsultarProyectos";
            Text = "ConsultarProyectos";
            Load += ConsultarProyectos_Load;
            pnltabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tablaProyecto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnltabla;
        private DataGridView tablaProyecto;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn FechaInicio;
        private DataGridViewTextBoxColumn FechaFinalizacion;
        private Label lblTitulo;
    }
}