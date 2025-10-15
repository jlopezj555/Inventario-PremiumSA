using CapaControlador;
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
    public partial class Movimientos_de_Inventario : Form
    {
        private string nombreUsuario;
        CapaControlador.controlador capaControlador_movimiento = new CapaControlador.controlador();
        public Movimientos_de_Inventario(string nombreUsuario)
        {
            InitializeComponent();
            this.nombreUsuario = nombreUsuario;
            InicializarFormulario();
        }
        private void InicializarFormulario()
        {
            // Cargar ComboBox
            capaControlador_movimiento.cargarEquipos(cmbEquipo);
            capaControlador_movimiento.cargarUsuarios(cmbUsuario);

            cmbTipoMovimiento.Items.Clear();
            cmbTipoMovimiento.Items.AddRange(new string[] { "Retiro", "Devolución", "Reparación", "Asignación", "Baja" });
            cmbTipoMovimiento.SelectedIndex = -1;

            // Cargar historial de movimientos
            CargarMovimientos();
        }

        private void salir_movinventario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu(nombreUsuario);
            menu.ShowDialog();
            this.Close();
        }

        private void dgvMovimientos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvMovimientos.Rows[e.RowIndex];
                cmbEquipo.Text = fila.Cells["Equipo"].Value?.ToString();
                cmbUsuario.Text = fila.Cells["Usuario"].Value?.ToString();
                cmbTipoMovimiento.Text = fila.Cells["tipo_movimiento"].Value?.ToString();
                txtObservaciones.Text = fila.Cells["observaciones"].Value?.ToString();
            }
        }

        private void CargarMovimientos()
        {
            DataTable dt = capaControlador_movimiento.obtenerMovimientos(); // Método en sentencias/controlador
            dgvMovimientos.DataSource = dt;
            dgvMovimientos.AutoResizeColumns();
        }

        private void LimpiarCampos()
        {
            cmbEquipo.SelectedIndex = -1;
            cmbUsuario.SelectedIndex = -1;
            cmbTipoMovimiento.SelectedIndex = -1;
            txtObservaciones.Clear();
        }

        private void btnRegistrarMovimiento_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbEquipo.SelectedIndex == -1 || cmbUsuario.SelectedIndex == -1 || cmbTipoMovimiento.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar Equipo, Usuario y Tipo de Movimiento.");
                    return;
                }

                int idEquipo = Convert.ToInt32(cmbEquipo.SelectedValue);
                int idUsuario = Convert.ToInt32(cmbUsuario.SelectedValue);
                string tipoMovimiento = cmbTipoMovimiento.SelectedItem.ToString();
                string observaciones = txtObservaciones.Text;

                capaControlador_movimiento.guardarMovimiento(idEquipo, idUsuario, tipoMovimiento, observaciones);

                MessageBox.Show("Movimiento registrado correctamente.");
                CargarMovimientos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar movimiento: " + ex.Message);
            }
        }

        private void btn_modmovimiento_Click(object sender, EventArgs e)
        {
            try
            {
                int idEquipo = Convert.ToInt32(cmbEquipo.Text);
                int idUsuario = Convert.ToInt32(cmbUsuario.Text);
                capaControlador_movimiento.modificarMovimiento(
                    idEquipo,
                    idUsuario,
                    cmbTipoMovimiento.Text,
                    txtObservaciones.Text
                    );
                CargarMovimientos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar: " + ex.Message);
            }
        }

        private void btn_actualizarmovimiento_Click(object sender, EventArgs e)
        {
            CargarMovimientos();
        }

        private void btn_eliminarmovimiento_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbEquipo.Text))
            {
                MessageBox.Show("Seleccione un movimiento de la lista primero.");
                return;
            }

            int idEquipo = Convert.ToInt32(cmbEquipo.Text);

            DialogResult result = MessageBox.Show(
                "¿Está seguro que desea eliminar este movimiento?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    capaControlador_movimiento.eliminarMovimiento(idEquipo);
                    MessageBox.Show("Estado eliminado correctamente.");
                    CargarMovimientos(); // refrescar DataGridView
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }
    }
}
