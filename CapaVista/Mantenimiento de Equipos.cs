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
    public partial class Mantenimiento_de_Equipos : Form
    {
        public Mantenimiento_de_Equipos()
        {
            InitializeComponent();
        }

        private void salir_equipo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
            this.Close();
        }

        private void btn_registroequipo_Click(object sender, EventArgs e)
        {

        }

        private void btn_guardarregistroequipo_Click(object sender, EventArgs e)
        {

        }
    }
}
