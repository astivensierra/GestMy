namespace Gest
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label1 = new Label();
            TextContraseña = new TextBox();
            TextCorreo = new TextBox();
            ButtonSalir = new Button();
            linkLabel1 = new LinkLabel();
            ButtonEntrar = new Button();
            bindingSource1 = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.Menu;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(TextContraseña);
            panel1.Controls.Add(TextCorreo);
            panel1.Controls.Add(ButtonSalir);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(ButtonEntrar);
            panel1.Location = new Point(438, -1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(477, 601);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(130, 77);
            label1.Name = "label1";
            label1.Size = new Size(243, 37);
            label1.TabIndex = 5;
            label1.Text = "Inicio de Sesión";
            // 
            // TextContraseña
            // 
            TextContraseña.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextContraseña.BackColor = SystemColors.Menu;
            TextContraseña.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextContraseña.ForeColor = Color.Black;
            TextContraseña.Location = new Point(91, 240);
            TextContraseña.Margin = new Padding(3, 4, 3, 4);
            TextContraseña.Name = "TextContraseña";
            TextContraseña.PasswordChar = '*';
            TextContraseña.PlaceholderText = "Contraseña";
            TextContraseña.Size = new Size(311, 32);
            TextContraseña.TabIndex = 4;
            TextContraseña.TextAlign = HorizontalAlignment.Center;
            // 
            // TextCorreo
            // 
            TextCorreo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TextCorreo.BackColor = SystemColors.Menu;
            TextCorreo.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextCorreo.ForeColor = Color.Black;
            TextCorreo.Location = new Point(91, 165);
            TextCorreo.Margin = new Padding(3, 4, 3, 4);
            TextCorreo.Name = "TextCorreo";
            TextCorreo.PlaceholderText = "Correo";
            TextCorreo.Size = new Size(311, 32);
            TextCorreo.TabIndex = 3;
            TextCorreo.TextAlign = HorizontalAlignment.Center;
            // 
            // ButtonSalir
            // 
            ButtonSalir.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonSalir.BackColor = SystemColors.MenuBar;
            ButtonSalir.Cursor = Cursors.Hand;
            ButtonSalir.Location = new Point(163, 423);
            ButtonSalir.Margin = new Padding(3, 4, 3, 4);
            ButtonSalir.Name = "ButtonSalir";
            ButtonSalir.Size = new Size(160, 57);
            ButtonSalir.TabIndex = 2;
            ButtonSalir.Text = "Salir";
            ButtonSalir.UseVisualStyleBackColor = false;
            ButtonSalir.Click += ButtonSalir_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.DodgerBlue;
            linkLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = SystemColors.MenuBar;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(107, 500);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(275, 20);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "¿No tienes una cuenta? Registrate ahora\r\n";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // ButtonEntrar
            // 
            ButtonEntrar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonEntrar.BackColor = SystemColors.MenuBar;
            ButtonEntrar.Cursor = Cursors.Hand;
            ButtonEntrar.Location = new Point(163, 339);
            ButtonEntrar.Margin = new Padding(3, 4, 3, 4);
            ButtonEntrar.Name = "ButtonEntrar";
            ButtonEntrar.Size = new Size(160, 57);
            ButtonEntrar.TabIndex = 0;
            ButtonEntrar.Text = "Entrar";
            ButtonEntrar.UseVisualStyleBackColor = false;
            ButtonEntrar.Click += ButtonEntrar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(914, 600);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox TextContraseña;
        private TextBox TextCorreo;
        private Button ButtonSalir;
        private LinkLabel linkLabel1;
        private Button ButtonEntrar;
        private BindingSource bindingSource1;
        private Label label1;
    }
}
