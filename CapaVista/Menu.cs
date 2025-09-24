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

        private void btn_mantenimientoequipos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mantenimiento_de_Equipos mantenimientoequipo = new Mantenimiento_de_Equipos();
            mantenimientoequipo.ShowDialog();
            this.Close();
        }

        private void btn_movimientobodegas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Movimiento_de_Bodegas movimientobodega = new Movimiento_de_Bodegas();
            movimientobodega.ShowDialog();
            this.Close();
        }

        private void btn_mantenimientousuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mantenimiento_de_Usuarios mantenimientousuario = new Mantenimiento_de_Usuarios();
            mantenimientousuario.ShowDialog();
            this.Close();
        }

        private void btn_movimientoinventario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Movimientos_de_Inventario movimientoinventario = new Movimientos_de_Inventario();
            movimientoinventario.ShowDialog();
            this.Close();
        }
    }
}
