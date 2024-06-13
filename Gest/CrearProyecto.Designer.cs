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
            pictureBox1 = new PictureBox();
            tbPropietario = new TextBox();
            lblPropietario = new Label();
            tbRepositorio = new TextBox();
            lblRepositorio = new Label();
            tbInfo = new TextBox();
            pnlInfo = new Panel();
            panel1 = new Panel();
            btnCrear = new Button();
            dtFechaInicio = new DateTimePicker();
            dtFechaFinal = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlInfo.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(27, 36);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(223, 23);
            tbNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombre.Location = new Point(27, 18);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(126, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre del proyecto";
            // 
            // tbDescripcion
            // 
            tbDescripcion.Location = new Point(27, 98);
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.Size = new Size(223, 23);
            tbDescripcion.TabIndex = 0;
            // 
            // lblDescricion
            // 
            lblDescricion.AutoSize = true;
            lblDescricion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDescricion.Location = new Point(27, 80);
            lblDescricion.Name = "lblDescricion";
            lblDescricion.Size = new Size(72, 15);
            lblDescricion.TabIndex = 1;
            lblDescricion.Text = "Descripción";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(116, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(195, 220);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // tbPropietario
            // 
            tbPropietario.Location = new Point(26, 159);
            tbPropietario.Name = "tbPropietario";
            tbPropietario.Size = new Size(223, 23);
            tbPropietario.TabIndex = 0;
            // 
            // lblPropietario
            // 
            lblPropietario.AutoSize = true;
            lblPropietario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPropietario.Location = new Point(26, 141);
            lblPropietario.Name = "lblPropietario";
            lblPropietario.Size = new Size(69, 15);
            lblPropietario.TabIndex = 1;
            lblPropietario.Text = "Propietario";
            // 
            // tbRepositorio
            // 
            tbRepositorio.Location = new Point(26, 221);
            tbRepositorio.Name = "tbRepositorio";
            tbRepositorio.Size = new Size(223, 23);
            tbRepositorio.TabIndex = 0;
            // 
            // lblRepositorio
            // 
            lblRepositorio.AutoSize = true;
            lblRepositorio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRepositorio.Location = new Point(26, 203);
            lblRepositorio.Name = "lblRepositorio";
            lblRepositorio.Size = new Size(71, 15);
            lblRepositorio.TabIndex = 1;
            lblRepositorio.Text = "Repositorio";
            // 
            // tbInfo
            // 
            tbInfo.BorderStyle = BorderStyle.FixedSingle;
            tbInfo.Location = new Point(70, 251);
            tbInfo.Multiline = true;
            tbInfo.Name = "tbInfo";
            tbInfo.Size = new Size(292, 111);
            tbInfo.TabIndex = 4;
            // 
            // pnlInfo
            // 
            pnlInfo.Controls.Add(pictureBox1);
            pnlInfo.Controls.Add(tbInfo);
            pnlInfo.Location = new Point(360, 12);
            pnlInfo.Name = "pnlInfo";
            pnlInfo.Size = new Size(413, 390);
            pnlInfo.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(dtFechaFinal);
            panel1.Controls.Add(dtFechaInicio);
            panel1.Controls.Add(btnCrear);
            panel1.Controls.Add(tbNombre);
            panel1.Controls.Add(tbPropietario);
            panel1.Controls.Add(lblNombre);
            panel1.Controls.Add(lblPropietario);
            panel1.Controls.Add(tbDescripcion);
            panel1.Controls.Add(lblRepositorio);
            panel1.Controls.Add(tbRepositorio);
            panel1.Controls.Add(lblDescricion);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(342, 426);
            panel1.TabIndex = 6;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(107, 361);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(75, 29);
            btnCrear.TabIndex = 3;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // dtFechaInicio
            // 
            dtFechaInicio.Location = new Point(35, 276);
            dtFechaInicio.Name = "dtFechaInicio";
            dtFechaInicio.Size = new Size(150, 23);
            dtFechaInicio.TabIndex = 4;
            // 
            // dtFechaFinal
            // 
            dtFechaFinal.Location = new Point(37, 321);
            dtFechaFinal.Name = "dtFechaFinal";
            dtFechaFinal.Size = new Size(145, 23);
            dtFechaFinal.TabIndex = 5;
            // 
            // CrearProyecto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(pnlInfo);
            FormBorderStyle = FormBorderStyle.None;
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
        private TextBox textBox3;
        private PictureBox pictureBox1;
        private TextBox tbPropietario;
        private Label lblPropietario;
        private TextBox tbRepositorio;
        private Label lblRepositorio;
        private TextBox tbInfo;
        private Panel pnlInfo;
        private Panel panel1;
        private Button btnCrear;
        private DateTimePicker dtFechaFinal;
        private DateTimePicker dtFechaInicio;
    }
}