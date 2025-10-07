using System;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class Registro_de_Usuario : Form
    {
        CapaControlador.controlador capaControlador_registroUsuario = new CapaControlador.controlador();
        public Registro_de_Usuario()
        {
            InitializeComponent();
        }
        private void btn_registrarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                capaControlador_registroUsuario.registrarUsuario(
                    txt_nombreUsuario.Text,
                    txt_Contraseña.Text,
                    txt_Correo.Text,
                    txt_Telefono.Text
                );

                MessageBox.Show("Usuario registrado con éxito");

                // Vuelve al login sin cerrar la aplicación principal
                this.Hide();
                Inicio_de_Sesión login = new Inicio_de_Sesión();
                login.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void salir_registrousuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio_de_Sesión inicio = new Inicio_de_Sesión();
            inicio.ShowDialog();
            this.Close();
        }
    }
}
