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
    public partial class Mantenimiento_de_Usuarios : Form
    {
        private string nombreUsuario;
        public Mantenimiento_de_Usuarios(string nombreUsuario)
        {
            InitializeComponent();
            this.nombreUsuario = nombreUsuario;
        }

        private void salir_usuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu(nombreUsuario);
            menu.ShowDialog();
            this.Close();
        }
    }
}
