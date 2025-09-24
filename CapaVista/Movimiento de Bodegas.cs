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
    public partial class Movimiento_de_Bodegas : Form
    {
        CapaControlador.controlador capaControlador_movimiento = new CapaControlador.controlador();
        public Movimiento_de_Bodegas()
        {
            InitializeComponent();
            CargarBodegas();
        }

        private void salir_movbodegas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
            this.Close();
        }

        private void btn_guardarregistrobodega_Click(object sender, EventArgs e)
        {
            try
            {
                capaControlador_movimiento.guardar_movimientoBodega(txt_nombreBodega.Text, txt_ubicacionBodega.Text, txt_capacidadBodega.Text);
                MessageBox.Show("Se registro el movimiento correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error " + ex.Message);
            }
        }

        private void CargarBodegas()
        {
            DataTable dt = capaControlador_movimiento.obtenerBodegas();
            dgv_bodegas.DataSource = dt;
        }

        private void btn_modregistrobodega_Click(object sender, EventArgs e)
        {
            try
            {
                int idBodega = Convert.ToInt32(txt_idBodega.Text);
                capaControlador_movimiento.editar_movimientoBodega(
                    idBodega,
                    txt_nombreBodega.Text,
                    txt_ubicacionBodega.Text,
                    txt_capacidadBodega.Text
                    );
                CargarBodegas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar: " + ex.Message);
            }
        }

        private void btn_eliminarbodega_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_idBodega.Text))
            {
                MessageBox.Show("Seleccione un empleado de la lista primero.");
                return;
            }

            int idBodega = Convert.ToInt32(txt_idBodega.Text);

            DialogResult result = MessageBox.Show(
                "¿Está seguro que desea eliminar esta bodega?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    capaControlador_movimiento.eliminarBodega(idBodega);
                    MessageBox.Show("Bodega eliminada correctamente.");
                    CargarBodegas(); // refrescar DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }

        private void dgv_bodegas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_bodegas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // validar que no sea header
            {
                DataGridViewRow fila = dgv_bodegas.Rows[e.RowIndex];

                txt_idBodega.Text = fila.Cells["ID_bodega"].Value.ToString();
                txt_nombreBodega.Text = fila.Cells["nombre_bodega"].Value.ToString();
                txt_ubicacionBodega.Text = fila.Cells["ubicacion_bodega"].Value.ToString();
                txt_capacidadBodega.Text = fila.Cells["capacidad_bodega"].Value.ToString();
            }
        }
    }
}
