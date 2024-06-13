namespace Gest
{
    partial class CrearProyecto
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
            tbNombre = new TextBox();
            lblNombre = new Label();
            tbDescripcion = new TextBox();
            lblDescricion = new Label();
            lblFechaInicio = new Label();
            lblFechaFinal = new Label();
            dtFechaInicio = new DateTimePicker();
            dtFechaFinal = new DateTimePicker();
            pictureBox1 = new PictureBox();
            tbPropietario = new TextBox();
            lblPropietario = new Label();
            tbRepositorio = new TextBox();
            lblRepositorio = new Label();
            tbInfo = new TextBox();
            pnlInfo = new Panel();
            panel1 = new Panel();
            btnCrear = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlInfo.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(31, 48);
            tbNombre.Margin = new Padding(3, 4, 3, 4);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(254, 27);
            tbNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombre.Location = new Point(31, 24);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(158, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre del proyecto";
            // 
            // tbDescripcion
            // 
            tbDescripcion.Location = new Point(31, 131);
            tbDescripcion.Margin = new Padding(3, 4, 3, 4);
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.Size = new Size(254, 27);
            tbDescripcion.TabIndex = 0;
            // 
            // lblDescricion
            // 
            lblDescricion.AutoSize = true;
            lblDescricion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDescricion.Location = new Point(31, 107);
            lblDescricion.Name = "lblDescricion";
            lblDescricion.Size = new Size(90, 20);
            lblDescricion.TabIndex = 1;
            lblDescricion.Text = "Descripción";
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFechaInicio.Location = new Point(30, 349);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(91, 20);
            lblFechaInicio.TabIndex = 1;
            lblFechaInicio.Text = "Fecha Inicio";
            // 
            // lblFechaFinal
            // 
            lblFechaFinal.AutoSize = true;
            lblFechaFinal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFechaFinal.Location = new Point(30, 432);
            lblFechaFinal.Name = "lblFechaFinal";
            lblFechaFinal.Size = new Size(155, 20);
            lblFechaFinal.TabIndex = 1;
            lblFechaFinal.Text = "Fecha de Finalización";
            // 
            // dtFechaInicio
            // 
            dtFechaInicio.Location = new Point(30, 373);
            dtFechaInicio.Margin = new Padding(3, 4, 3, 4);
            dtFechaInicio.MaxDate = new DateTime(2050, 12, 31, 0, 0, 0, 0);
            dtFechaInicio.MinDate = new DateTime(2024, 6, 12, 7, 42, 52, 0);
            dtFechaInicio.Name = "dtFechaInicio";
            dtFechaInicio.Size = new Size(228, 27);
            dtFechaInicio.TabIndex = 2;
            dtFechaInicio.Value = new DateTime(2024, 6, 12, 7, 42, 52, 0);
            // 
            // dtFechaFinal
            // 
            dtFechaFinal.Location = new Point(30, 456);
            dtFechaFinal.Margin = new Padding(3, 4, 3, 4);
            dtFechaFinal.MaxDate = new DateTime(2050, 12, 31, 0, 0, 0, 0);
            dtFechaFinal.MinDate = new DateTime(2008, 1, 1, 0, 0, 0, 0);
            dtFechaFinal.Name = "dtFechaFinal";
            dtFechaFinal.Size = new Size(228, 27);
            dtFechaFinal.TabIndex = 2;
            dtFechaFinal.Value = new DateTime(2024, 6, 13, 0, 0, 0, 0);
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(132, 24);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(223, 293);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // tbPropietario
            // 
            tbPropietario.Location = new Point(30, 212);
            tbPropietario.Margin = new Padding(3, 4, 3, 4);
            tbPropietario.Name = "tbPropietario";
            tbPropietario.Size = new Size(254, 27);
            tbPropietario.TabIndex = 0;
            // 
            // lblPropietario
            // 
            lblPropietario.AutoSize = true;
            lblPropietario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPropietario.Location = new Point(30, 188);
            lblPropietario.Name = "lblPropietario";
            lblPropietario.Size = new Size(87, 20);
            lblPropietario.TabIndex = 1;
            lblPropietario.Text = "Propietario";
            // 
            // tbRepositorio
            // 
            tbRepositorio.Location = new Point(30, 295);
            tbRepositorio.Margin = new Padding(3, 4, 3, 4);
            tbRepositorio.Name = "tbRepositorio";
            tbRepositorio.Size = new Size(254, 27);
            tbRepositorio.TabIndex = 0;
            // 
            // lblRepositorio
            // 
            lblRepositorio.AutoSize = true;
            lblRepositorio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRepositorio.Location = new Point(30, 271);
            lblRepositorio.Name = "lblRepositorio";
            lblRepositorio.Size = new Size(90, 20);
            lblRepositorio.TabIndex = 1;
            lblRepositorio.Text = "Repositorio";
            // 
            // tbInfo
            // 
            tbInfo.BorderStyle = BorderStyle.FixedSingle;
            tbInfo.Location = new Point(80, 335);
            tbInfo.Margin = new Padding(3, 4, 3, 4);
            tbInfo.Multiline = true;
            tbInfo.Name = "tbInfo";
            tbInfo.Size = new Size(334, 147);
            tbInfo.TabIndex = 4;
            // 
            // pnlInfo
            // 
            pnlInfo.Controls.Add(pictureBox1);
            pnlInfo.Controls.Add(tbInfo);
            pnlInfo.Location = new Point(411, 16);
            pnlInfo.Margin = new Padding(3, 4, 3, 4);
            pnlInfo.Name = "pnlInfo";
            pnlInfo.Size = new Size(472, 520);
            pnlInfo.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCrear);
            panel1.Controls.Add(tbNombre);
            panel1.Controls.Add(tbPropietario);
            panel1.Controls.Add(dtFechaFinal);
            panel1.Controls.Add(lblNombre);
            panel1.Controls.Add(dtFechaInicio);
            panel1.Controls.Add(lblFechaFinal);
            panel1.Controls.Add(lblPropietario);
            panel1.Controls.Add(lblFechaInicio);
            panel1.Controls.Add(tbDescripcion);
            panel1.Controls.Add(lblRepositorio);
            panel1.Controls.Add(tbRepositorio);
            panel1.Controls.Add(lblDescricion);
            panel1.Location = new Point(14, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(391, 568);
            panel1.TabIndex = 6;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(99, 509);
            btnCrear.Margin = new Padding(3, 4, 3, 4);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(86, 39);
            btnCrear.TabIndex = 3;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // CrearProyecto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panel1);
            Controls.Add(pnlInfo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CrearProyecto";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlInfo.ResumeLayout(false);
            pnlInfo.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tbNombre;
        private Label lblNombre;
        private TextBox tbDescripcion;
        private Label lblDescricion;
        private Label lblFechaInicio;
        private TextBox textBox3;
        private Label lblFechaFinal;
        private DateTimePicker dtFechaInicio;
        private DateTimePicker dtFechaFinal;
        private PictureBox pictureBox1;
        private TextBox tbPropietario;
        private Label lblPropietario;
        private TextBox tbRepositorio;
        private Label lblRepositorio;
        private TextBox tbInfo;
        private Panel pnlInfo;
        private Panel panel1;
        private Button btnCrear;
    }
}