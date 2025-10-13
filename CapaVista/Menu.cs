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

        private void btn_categorias_Click(object sender, EventArgs e)
        {
            this.Hide();
            Categorias categorias = new Categorias(nombreUsuario);
            categorias.ShowDialog();
            this.Close();
        }

        private void btn_estado_Click(object sender, EventArgs e)
        {
            this.Hide();
            Estado_de_equipos estado_De_Equipos = new Estado_de_equipos(nombreUsuario);
            estado_De_Equipos.ShowDialog();
            this.Close();
        }

        private void Btn_InventarioEquipos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventario_Equipos inventario_De_Equipos = new Inventario_Equipos(nombreUsuario);
            inventario_De_Equipos.ShowDialog();
            this.Close();
        }
    }
}
