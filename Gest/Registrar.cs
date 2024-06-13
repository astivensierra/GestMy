using BLL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gest
{
    public partial class Registrar : Form
    {
        private readonly FirestoreService _firestoreService;

        // Constructor que acepta un objeto FirestoreService
        public Registrar(FirestoreService firestoreService)
        {
            InitializeComponent();
            _firestoreService = firestoreService;
            this.StartPosition = FormStartPosition.CenterScreen; // Ajusta la posición inicial del formulario
        }

        // Constructor sin parámetros, crea una instancia de FirestoreService
        public Registrar() : this(new FirestoreService())
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonVolver_Click(object sender, EventArgs e)
        {
            Login login = Application.OpenForms.OfType<Login>().FirstOrDefault();
            if (login != null)
            {
                login.Show();
                this.Close();
            }
            else
            {
                login = new Login();
                login.Show();
                this.Close();
            }
        }

        private async void ButtonRegistrar_ClickAsync(object sender, EventArgs e)
        {
            string nombre = TextRegistroNombre.Text;
            string email = TextRegistroCorreo.Text;
            string password = TextRegistroContraseña.Text;


            if (await _firestoreService.ExisteUsuarioConCorreoElectronico(email))
            {
                MessageBox.Show("Ya existe un usuario con este correo electrónico");
                return;
            }
            else
            {
                var nuevoUsuario = new Usuario
                {
                    Nombre = nombre,
                    Email = email,
                    PasswordHash = password,

                };

                // Usa await dentro de un método asincrónico
                await _firestoreService.CreateUsuario(nuevoUsuario);
                MessageBox.Show("Registro exitoso");
                this.Close();
            }
        }
    }
}