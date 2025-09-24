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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void btn_movimientoEmpleados_Click(object sender, EventArgs e)
        {
            this.Hide();
            Movimiento_de_empleados movimiento_De_Empleados = new Movimiento_de_empleados();
            movimiento_De_Empleados.ShowDialog();
            this.Close();
        }
    }
}
