using BLL;
using ENTITY;
using Google.Cloud.Firestore;

namespace Gest
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registrar Registrar = new Registrar();
            Registrar.Show();
            this.Hide();
        }

        private async void ButtonEntrar_Click(object sender, EventArgs e)
        {
            string email = TextCorreo.Text.Trim();
            string password = TextContraseña.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, ingrese sus credenciales");
                return;
            }

            FirestoreService firestoreService = new FirestoreService();

            List<Usuario> usuarios = await firestoreService.GetUsuarios();

            Usuario? usuario = usuarios.FirstOrDefault(u => u.Email == email);

            if (usuario == null)
            {
                MessageBox.Show("El usuario no existe");
                return;
            }

            if (usuario.PasswordHash != password)
            {
                MessageBox.Show("Contraseña incorrecta");
                return;
            }

            // Si llegamos aquí, el usuario se ha autenticado correctamente
            // Puedes guardar el usuario autenticado en una variable de sesión o algo similar
            // y redirigir al usuario a la pantalla principal de la aplicación

            MessageBox.Show("Bienvenido, " + usuario.Nombre);
            Principal principal = new Principal();
            principal.Show();
            this.Hide();
            //...
        }
    }
}