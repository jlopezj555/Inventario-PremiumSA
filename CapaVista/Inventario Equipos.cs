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
    public partial class Inventario_Equipos : Form
    {
        private string nombreUsuario;
        CapaControlador.controlador capaControlador_inventario = new CapaControlador.controlador();
        public Inventario_Equipos(string nombreUsuario)
        {
            InitializeComponent();
            this.nombreUsuario = nombreUsuario;


            // Cargar datos iniciales del formulario
            InicializarFormulario();
        }

        private void InicializarFormulario()
        {
            // Cargar categorías en ComboBox
            cmb_idCategoria.DataSource = capaControlador_inventario.obtenerCategorias();
            cmb_idCategoria.ValueMember = "id_categoria";       // valor interno
            cmb_idCategoria.DisplayMember = "nombre_categoria"; // lo que ve el usuario
            cmb_idCategoria.SelectedIndex = -1;                 // sin selección inicial

            // Cargar inventario en DataGridView
            CargarInventario();
        }


        private void salir_equipo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu(nombreUsuario);
            menu.ShowDialog();
            this.Close();
        }


        private void LimpiarCampos()
        {
            txt_codigoInventario.Clear();
            txt_nombreEquipo.Clear();
            txt_marcaEquipo.Clear();
            txt_modeloEquipo.Clear();
            txtStockActual.Clear();
            txtStockMinimo.Clear();
            cmb_idCategoria.SelectedIndex = -1;
        }

        private void CargarInventario()
        {
            DataTable dt = capaControlador_inventario.obtenerInventario();
            dgv_inventario.DataSource = dt;

            // Cambiar solo encabezados visibles
            if (dgv_inventario.Columns.Contains("nombre_categoria"))
                dgv_inventario.Columns["nombre_categoria"].HeaderText = "Categoría";

            // Ocultar columna id_categoria si no quieres mostrarla
            if (dgv_inventario.Columns.Contains("id_categoria"))
                dgv_inventario.Columns["id_categoria"].Visible = false;

            dgv_inventario.AutoResizeColumns();
        }

        private void dgv_inventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgv_inventario.Rows[e.RowIndex];

                txt_codigoInventario.Text = fila.Cells["id_inventario"].Value?.ToString();
                txt_nombreEquipo.Text = fila.Cells["nombre_equipo"].Value?.ToString();
                txt_marcaEquipo.Text = fila.Cells["marca"].Value?.ToString();
                txt_modeloEquipo.Text = fila.Cells["modelo"].Value?.ToString();
                txtStockActual.Text = fila.Cells["stock_actual"].Value?.ToString();
                txtStockMinimo.Text = fila.Cells["stock_minimo"].Value?.ToString();

                // Asignar SelectedValue al ComboBox con retraso
                this.BeginInvoke((Action)(() =>
                {
                    if (fila.Cells["id_categoria"].Value != DBNull.Value)
                        cmb_idCategoria.SelectedValue = Convert.ToInt32(fila.Cells["id_categoria"].Value);
                    else
                        cmb_idCategoria.SelectedIndex = -1;
                }));
            }
        }







        // Botón actualizar DataGridView
        private void btn_actualizarInventario_Click(object sender, EventArgs e)
        {
            CargarInventario();
            MessageBox.Show("Tabla actualizada con los últimos registros.");
        }

        private void salir_equipo_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu(nombreUsuario);
            menu.ShowDialog();
            this.Close();
        }

        private void btn_guardarregistroequipo_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_nombreEquipo.Text))
                {
                    MessageBox.Show("El nombre del equipo es obligatorio.");
                    return;
                }

                int idCategoria = Convert.ToInt32(cmb_idCategoria.SelectedValue);
                string nombreEquipo = txt_nombreEquipo.Text;
                string marca = txt_marcaEquipo.Text;
                string modelo = txt_modeloEquipo.Text;
                int stockMinimo = Convert.ToInt32(txtStockMinimo.Text);
                int stockActual = Convert.ToInt32(txtStockActual.Text); // <-- nuevo

                capaControlador_inventario.guardarInventario(nombreEquipo, idCategoria, marca, modelo, stockMinimo, stockActual);

                MessageBox.Show("Inventario registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarInventario();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar inventario: " + ex.Message);
            }
        }

        private void btn_modregistroequipo_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_codigoInventario.Text))
                {
                    MessageBox.Show("Selecciona un registro para modificar.");
                    return;
                }

                int idInventario = Convert.ToInt32(txt_codigoInventario.Text);
                int idCategoria = Convert.ToInt32(cmb_idCategoria.SelectedValue);
                string nombreEquipo = txt_nombreEquipo.Text;
                string marca = txt_marcaEquipo.Text;
                string modelo = txt_modeloEquipo.Text;
                int stockMinimo = Convert.ToInt32(txtStockMinimo.Text);

                int stockActual;
                if (!int.TryParse(txtStockActual.Text, out stockActual))
                {
                    MessageBox.Show("Stock actual inválido.");
                    return;
                }

                capaControlador_inventario.editarInventario(idInventario, nombreEquipo, idCategoria, marca, modelo, stockMinimo, stockActual);

                MessageBox.Show("Inventario modificado correctamente.");
                CargarInventario();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar inventario: " + ex.Message);
            }
        }


        private void btn_actualizarequipo_Click(object sender, EventArgs e)
        {

        }

        private void btn_eliminarequipo_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_codigoInventario.Text))
                {
                    MessageBox.Show("Selecciona un registro para eliminar.");
                    return;
                }

                int idInventario = Convert.ToInt32(txt_codigoInventario.Text);
                DialogResult confirm = MessageBox.Show("¿Seguro que deseas eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo);

                if (confirm == DialogResult.Yes)
                {
                    capaControlador_inventario.eliminarInventario(idInventario);
                    CargarInventario();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar inventario: " + ex.Message);
            }
        }

        private void btn_ayudaequipo_Click(object sender, EventArgs e)
        {

        }
    }
}
