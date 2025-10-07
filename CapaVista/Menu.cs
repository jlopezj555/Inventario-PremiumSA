using System;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class Menu : Form
    {
        private string nombreUsuario;
        public Menu(string usuario)
        {
            InitializeComponent();
            nombreUsuario = usuario;
        }
        private void btn_movimientoEmpleados_Click(object sender, EventArgs e)
        {
            this.Hide();
            Movimiento_de_empleados movimiento_De_Empleados = new Movimiento_de_empleados(nombreUsuario);
            movimiento_De_Empleados.ShowDialog();
            this.Close();
        }

        private void btn_mantenimientoequipos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mantenimiento_de_Equipos mantenimientoequipo = new Mantenimiento_de_Equipos(nombreUsuario);
            mantenimientoequipo.ShowDialog();
            this.Close();
        }

        private void btn_movimientobodegas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Movimiento_de_Bodegas movimientobodega = new Movimiento_de_Bodegas(nombreUsuario);
            movimientobodega.ShowDialog();
            this.Close();
        }

        private void btn_mantenimientousuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mantenimiento_de_Usuarios mantenimientousuario = new Mantenimiento_de_Usuarios(nombreUsuario);
            mantenimientousuario.ShowDialog();
            this.Close();
        }

        private void btn_movimientoinventario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Movimientos_de_Inventario movimientoinventario = new Movimientos_de_Inventario(nombreUsuario);
            movimientoinventario.ShowDialog();
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            lbl_Usuariomenu.Text = nombreUsuario;
            lbl_Fechamenu.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
