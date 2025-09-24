using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Inicio_de_Sesión inicio_De_Sesión = new Inicio_de_Sesión();
            try
            {
                capaControlador_registroUsuario.registrarUsuario(txt_nombreUsuario.Text, txt_Contraseña.Text, txt_Correo.Text, txt_Telefono.Text);
                MessageBox.Show("Usuario registrado con exito");
                inicio_De_Sesión.Show();
                this.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Ocurrio un error" + ex);
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
