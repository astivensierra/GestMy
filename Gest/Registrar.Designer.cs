
namespace Gest
{
    partial class Registrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrar));
            panel1 = new Panel();
            TextRegistrarApellido = new TextBox();
            label1 = new Label();
            TextRegistroContraseña = new TextBox();
            TextRegistroCorreo = new TextBox();
            TextRegistroNombre = new TextBox();
            ButtonVolver = new Button();
            ButtonRegistrar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(TextRegistrarApellido);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(TextRegistroContraseña);
            panel1.Controls.Add(TextRegistroCorreo);
            panel1.Controls.Add(TextRegistroNombre);
            panel1.Controls.Add(ButtonVolver);
            panel1.Controls.Add(ButtonRegistrar);
            panel1.Location = new Point(1, -1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(457, 605);
            panel1.TabIndex = 0;
            // 
            // TextRegistrarApellido
            // 
            TextRegistrarApellido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextRegistrarApellido.BackColor = SystemColors.Menu;
            TextRegistrarApellido.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextRegistrarApellido.ForeColor = Color.Black;
            TextRegistrarApellido.Location = new Point(77, 223);
            TextRegistrarApellido.Margin = new Padding(3, 4, 3, 4);
            TextRegistrarApellido.Name = "TextRegistrarApellido";
            TextRegistrarApellido.PlaceholderText = "Apellido";
            TextRegistrarApellido.Size = new Size(310, 32);
            TextRegistrarApellido.TabIndex = 9;
            TextRegistrarApellido.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(94, 79);
            label1.Name = "label1";
            label1.Size = new Size(294, 37);
            label1.TabIndex = 8;
            label1.Text = "Registro de Usuario";
            label1.Click += label1_Click;
            // 
            // TextRegistroContraseña
            // 
            TextRegistroContraseña.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextRegistroContraseña.BackColor = SystemColors.Menu;
            TextRegistroContraseña.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextRegistroContraseña.ForeColor = Color.Black;
            TextRegistroContraseña.Location = new Point(77, 336);
            TextRegistroContraseña.Margin = new Padding(3, 4, 3, 4);
            TextRegistroContraseña.Name = "TextRegistroContraseña";
            TextRegistroContraseña.PlaceholderText = "Contraseña";
            TextRegistroContraseña.Size = new Size(310, 32);
            TextRegistroContraseña.TabIndex = 7;
            TextRegistroContraseña.TextAlign = HorizontalAlignment.Center;
            // 
            // TextRegistroCorreo
            // 
            TextRegistroCorreo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextRegistroCorreo.BackColor = SystemColors.Menu;
            TextRegistroCorreo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextRegistroCorreo.ForeColor = Color.Black;
            TextRegistroCorreo.Location = new Point(77, 277);
            TextRegistroCorreo.Margin = new Padding(3, 4, 3, 4);
            TextRegistroCorreo.Name = "TextRegistroCorreo";
            TextRegistroCorreo.PlaceholderText = "Correo";
            TextRegistroCorreo.Size = new Size(310, 32);
            TextRegistroCorreo.TabIndex = 6;
            TextRegistroCorreo.TextAlign = HorizontalAlignment.Center;
            // 
            // TextRegistroNombre
            // 
            TextRegistroNombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextRegistroNombre.BackColor = SystemColors.Menu;
            TextRegistroNombre.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextRegistroNombre.ForeColor = Color.Black;
            TextRegistroNombre.Location = new Point(77, 168);
            TextRegistroNombre.Margin = new Padding(3, 4, 3, 4);
            TextRegistroNombre.Name = "TextRegistroNombre";
            TextRegistroNombre.PlaceholderText = "Nombre";
            TextRegistroNombre.Size = new Size(310, 32);
            TextRegistroNombre.TabIndex = 5;
            TextRegistroNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // ButtonVolver
            // 
            ButtonVolver.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonVolver.BackColor = SystemColors.MenuBar;
            ButtonVolver.Cursor = Cursors.Hand;
            ButtonVolver.Location = new Point(150, 484);
            ButtonVolver.Margin = new Padding(3, 4, 3, 4);
            ButtonVolver.Name = "ButtonVolver";
            ButtonVolver.Size = new Size(159, 57);
            ButtonVolver.TabIndex = 4;
            ButtonVolver.Text = "Volver";
            ButtonVolver.UseVisualStyleBackColor = false;
            ButtonVolver.Click += ButtonVolver_Click;
            // 
            // ButtonRegistrar
            // 
            ButtonRegistrar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonRegistrar.BackColor = SystemColors.MenuBar;
            ButtonRegistrar.Cursor = Cursors.Hand;
            ButtonRegistrar.Location = new Point(150, 404);
            ButtonRegistrar.Margin = new Padding(3, 4, 3, 4);
            ButtonRegistrar.Name = "ButtonRegistrar";
            ButtonRegistrar.Size = new Size(159, 57);
            ButtonRegistrar.TabIndex = 3;
            ButtonRegistrar.Text = "Registrar";
            ButtonRegistrar.UseVisualStyleBackColor = false;
            ButtonRegistrar.Click += ButtonRegistrar_ClickAsync;
            // 
            // Registrar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(914, 599);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Registrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private Panel panel1;
        private Button ButtonVolver;
        private Button ButtonRegistrar;
        private TextBox TextRegistroContraseña;
        private TextBox TextRegistroCorreo;
        private TextBox TextRegistroNombre;
        private Label label1;
        private TextBox TextRegistroApellido;
        private TextBox TextRegistrarApellido;
    }
}