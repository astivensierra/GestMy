namespace Gest
{
    partial class CrearTarea
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
            btnCrearTarea = new Button();
            tbNombre = new TextBox();
            tbPropietario = new TextBox();
            dtFechaFinal = new DateTimePicker();
            lblCrearTarea = new Label();
            dtFechaInicio = new DateTimePicker();
            lblFechaFinal = new Label();
            lblCrearPropietarioTarea = new Label();
            lblFechaInicio = new Label();
            tbDescripcion = new TextBox();
            lblDescricionTarea = new Label();
            panel1 = new Panel();
            cbproyecto = new ComboBox();
            lblCrearRepositorioTarea = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCrearTarea
            // 
            btnCrearTarea.Location = new Point(92, 481);
            btnCrearTarea.Margin = new Padding(3, 4, 3, 4);
            btnCrearTarea.Name = "btnCrearTarea";
            btnCrearTarea.Size = new Size(86, 39);
            btnCrearTarea.TabIndex = 16;
            btnCrearTarea.Text = "Crear";
            btnCrearTarea.UseVisualStyleBackColor = true;
            btnCrearTarea.Click += btnCrearTarea_Click;
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(14, 129);
            tbNombre.Margin = new Padding(3, 4, 3, 4);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(254, 27);
            tbNombre.TabIndex = 4;
            // 
            // tbPropietario
            // 
            tbPropietario.Location = new Point(14, 279);
            tbPropietario.Margin = new Padding(3, 4, 3, 4);
            tbPropietario.Name = "tbPropietario";
            tbPropietario.Size = new Size(254, 27);
            tbPropietario.TabIndex = 5;
            // 
            // dtFechaFinal
            // 
            dtFechaFinal.Location = new Point(14, 426);
            dtFechaFinal.Margin = new Padding(3, 4, 3, 4);
            dtFechaFinal.MaxDate = new DateTime(2050, 12, 31, 0, 0, 0, 0);
            dtFechaFinal.MinDate = new DateTime(2008, 1, 1, 0, 0, 0, 0);
            dtFechaFinal.Name = "dtFechaFinal";
            dtFechaFinal.Size = new Size(228, 27);
            dtFechaFinal.TabIndex = 14;
            dtFechaFinal.Value = new DateTime(2024, 6, 13, 0, 0, 0, 0);
            // 
            // lblCrearTarea
            // 
            lblCrearTarea.AutoSize = true;
            lblCrearTarea.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCrearTarea.Location = new Point(14, 105);
            lblCrearTarea.Name = "lblCrearTarea";
            lblCrearTarea.Size = new Size(146, 20);
            lblCrearTarea.TabIndex = 8;
            lblCrearTarea.Text = "Nombre de la Tarea";
            // 
            // dtFechaInicio
            // 
            dtFechaInicio.Location = new Point(14, 343);
            dtFechaInicio.Margin = new Padding(3, 4, 3, 4);
            dtFechaInicio.MaxDate = new DateTime(2050, 12, 31, 0, 0, 0, 0);
            dtFechaInicio.MinDate = new DateTime(2024, 6, 12, 7, 42, 52, 0);
            dtFechaInicio.Name = "dtFechaInicio";
            dtFechaInicio.Size = new Size(228, 27);
            dtFechaInicio.TabIndex = 15;
            dtFechaInicio.Value = new DateTime(2024, 6, 12, 7, 42, 52, 0);
            // 
            // lblFechaFinal
            // 
            lblFechaFinal.AutoSize = true;
            lblFechaFinal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFechaFinal.Location = new Point(14, 402);
            lblFechaFinal.Name = "lblFechaFinal";
            lblFechaFinal.Size = new Size(155, 20);
            lblFechaFinal.TabIndex = 9;
            lblFechaFinal.Text = "Fecha de Finalización";
            // 
            // lblCrearPropietarioTarea
            // 
            lblCrearPropietarioTarea.AutoSize = true;
            lblCrearPropietarioTarea.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCrearPropietarioTarea.Location = new Point(14, 255);
            lblCrearPropietarioTarea.Name = "lblCrearPropietarioTarea";
            lblCrearPropietarioTarea.Size = new Size(97, 20);
            lblCrearPropietarioTarea.TabIndex = 10;
            lblCrearPropietarioTarea.Text = "Responsable";
            
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFechaInicio.Location = new Point(14, 319);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(91, 20);
            lblFechaInicio.TabIndex = 11;
            lblFechaInicio.Text = "Fecha Inicio";
            // 
            // tbDescripcion
            // 
            tbDescripcion.Location = new Point(14, 212);
            tbDescripcion.Margin = new Padding(3, 4, 3, 4);
            tbDescripcion.Name = "tbDescripcion";
            tbDescripcion.Size = new Size(254, 27);
            tbDescripcion.TabIndex = 6;
            // 
            // lblDescricionTarea
            // 
            lblDescricionTarea.AutoSize = true;
            lblDescricionTarea.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDescricionTarea.Location = new Point(14, 188);
            lblDescricionTarea.Name = "lblDescricionTarea";
            lblDescricionTarea.Size = new Size(90, 20);
            lblDescricionTarea.TabIndex = 13;
            lblDescricionTarea.Text = "Descripción";
            // 
            // panel1
            // 
            panel1.Controls.Add(cbproyecto);
            panel1.Controls.Add(lblCrearTarea);
            panel1.Controls.Add(lblCrearRepositorioTarea);
            panel1.Controls.Add(btnCrearTarea);
            panel1.Controls.Add(lblDescricionTarea);
            panel1.Controls.Add(dtFechaFinal);
            panel1.Controls.Add(tbPropietario);
            panel1.Controls.Add(dtFechaInicio);
            panel1.Controls.Add(tbNombre);
            panel1.Controls.Add(lblFechaFinal);
            panel1.Controls.Add(tbDescripcion);
            panel1.Controls.Add(lblFechaInicio);
            panel1.Controls.Add(lblCrearPropietarioTarea);
            panel1.Location = new Point(12, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(298, 524);
            panel1.TabIndex = 17;
            // 
            // cbproyecto
            // 
            cbproyecto.FormattingEnabled = true;
            cbproyecto.Location = new Point(17, 62);
            cbproyecto.Name = "cbproyecto";
            cbproyecto.Size = new Size(250, 28);
            cbproyecto.TabIndex = 17;
            // 
            // lblCrearRepositorioTarea
            // 
            lblCrearRepositorioTarea.AutoSize = true;
            lblCrearRepositorioTarea.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCrearRepositorioTarea.Location = new Point(14, 36);
            lblCrearRepositorioTarea.Name = "lblCrearRepositorioTarea";
            lblCrearRepositorioTarea.Size = new Size(158, 20);
            lblCrearRepositorioTarea.TabIndex = 12;
            lblCrearRepositorioTarea.Text = "Nombre del Proyecto";
            // 
            // CrearTarea
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 551);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CrearTarea";
            Text = "CrearTarea";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCrearTarea;
        private TextBox tbNombre;
        private TextBox tbPropietario;
        private DateTimePicker dtFechaFinal;
        private Label lblCrearTarea;
        private DateTimePicker dtFechaInicio;
        private Label lblFechaFinal;
        private Label lblCrearPropietarioTarea;
        private Label lblFechaInicio;
        private TextBox tbDescripcion;
        private Label lblDescricionTarea;
        private Panel panel1;
        private Label lblCrearRepositorioTarea;
        private ComboBox cbproyecto;
    }
}