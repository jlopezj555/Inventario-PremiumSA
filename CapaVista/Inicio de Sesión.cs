using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{
    public partial class Inicio_de_Sesión : Form
    {
        public Inicio_de_Sesión()
        {
            InitializeComponent();
        }
        private void btn_iniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txt_Usuario.Text;
            string contrasena = txt_Contraseña.Text;

            try
            {
                controlador capaControlador_Login = new controlador();
                bool sesionValida = capaControlador_Login.iniciarSesion(usuario, contrasena);

                if (sesionValida)
                {
                    MessageBox.Show("Bienvenido " + usuario + "!");
                    this.Hide();
                    Menu menu = new Menu(usuario);
                    menu.ShowDialog();
                    this.Close();
                }
                else 
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_registrarusuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro_de_Usuario registro = new Registro_de_Usuario();
            registro.ShowDialog();
            this.Close();
        }
    }
}
