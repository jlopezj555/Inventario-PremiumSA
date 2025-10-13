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

    public partial class Estado_de_equipos : Form
    {
        private string nombreUsuario;
        CapaControlador.controlador capaControlador_movimiento = new CapaControlador.controlador();

        public Estado_de_equipos(string nombreUsuario)
        {
            InitializeComponent();
            CargarEstados();
            this.nombreUsuario = nombreUsuario;
        }

        private void salir_equipo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu(nombreUsuario);
            menu.ShowDialog();
            this.Close();
        }

        private void btn_guardarregistroestado_Click(object sender, EventArgs e)
        {
            try
            {
                capaControlador_movimiento.guardar_movimientoEstado(txt_nombreestado.Text, txt_descripcionestado.Text);
                MessageBox.Show("Se registro el movimiento correctamente");
                CargarEstados();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error " + ex.Message);
            }
        }

        private void CargarEstados()
        {
            DataTable dt = capaControlador_movimiento.obtenerEstados();
            dgv_estados.DataSource = dt;
        }

        private void btn_modregistroestado_Click(object sender, EventArgs e)
        {
            try
            {
                int idEstado = Convert.ToInt32(txt_idEstado.Text);
                capaControlador_movimiento.editar_movimientoEstado(
                    idEstado,
                    txt_nombreestado.Text,
                    txt_descripcionestado.Text
                    );
                CargarEstados();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar: " + ex.Message);
            }
        }

        private void btn_eliminarestado_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_idEstado.Text))
            {
                MessageBox.Show("Seleccione un estado de la lista primero.");
                return;
            }

            int idEstado = Convert.ToInt32(txt_idEstado.Text);

            DialogResult result = MessageBox.Show(
                "¿Está seguro que desea eliminar esta categoría?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    capaControlador_movimiento.eliminarEstado(idEstado);
                    MessageBox.Show("Estado eliminado correctamente.");
                    CargarEstados(); // refrescar DataGridView
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }

        private void dgv_estados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // validar que no sea header
            {
                DataGridViewRow fila = dgv_estados.Rows[e.RowIndex];

                txt_idEstado.Text = fila.Cells["id_estado"].Value.ToString();
                txt_nombreestado.Text = fila.Cells["nombre_estado"].Value.ToString();
                txt_descripcionestado.Text = fila.Cells["descripcion"].Value.ToString();
            }
        }

        private void LimpiarCampos()
        {
            txt_idEstado.Clear();
            txt_nombreestado.Clear();
            txt_descripcionestado.Clear();
        }
    }
}
