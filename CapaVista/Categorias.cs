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
    public partial class Categorias : Form
    {
        private string nombreUsuario;
        CapaControlador.controlador capaControlador_movimiento = new CapaControlador.controlador();

        public Categorias(string nombreUsuario)
        {
            InitializeComponent();
            CargarCategorias();
            this.nombreUsuario = nombreUsuario;
        }

        private void salir_equipo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu(nombreUsuario);
            menu.ShowDialog();
            this.Close();
        }

        private void btn_guardarregistrocategoria_Click(object sender, EventArgs e)
        {
            try
            {
                capaControlador_movimiento.guardar_movimientoCategoria(txt_nombre.Text, txt_descripcion.Text);
                MessageBox.Show("Se registro el movimiento correctamente");
                CargarCategorias();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error " + ex.Message);
            }
        }

        private void CargarCategorias()
        {
            DataTable dt = capaControlador_movimiento.obtenerCategorias();
            dgv_categorias.DataSource = dt;

            // Configurar encabezados legibles (opcional)
            if (dgv_categorias.Columns.Contains("id_categoria"))
                dgv_categorias.Columns["id_categoria"].HeaderText = "ID";

            if (dgv_categorias.Columns.Contains("nombre_categoria"))
                dgv_categorias.Columns["nombre_categoria"].HeaderText = "Categoría";

            if (dgv_categorias.Columns.Contains("descripcion"))
                dgv_categorias.Columns["descripcion"].HeaderText = "Descripción";
        }

        private void btn_modregistrocategoria_Click(object sender, EventArgs e)
        {
            try
            {
                int idCategoria = Convert.ToInt32(txt_idCategoria.Text);
                capaControlador_movimiento.editar_movimientoCategoria(
                    idCategoria,
                    txt_nombre.Text,
                    txt_descripcion.Text
                    );
                CargarCategorias();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar: " + ex.Message);
            }
        }

        private void btn_eliminarcategoria_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_idCategoria.Text))
            {
                MessageBox.Show("Seleccione una categoría de la lista primero.");
                return;
            }

            int idCategoria = Convert.ToInt32(txt_idCategoria.Text);

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
                    capaControlador_movimiento.eliminarCategoria(idCategoria);
                    MessageBox.Show("Categoría eliminada correctamente.");
                    CargarCategorias(); // refrescar DataGridView
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }

        private void dgv_categorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgv_categorias.Rows[e.RowIndex];

                txt_idCategoria.Text = fila.Cells["id_categoria"].Value?.ToString();
                txt_nombre.Text = fila.Cells["nombre_categoria"].Value?.ToString();
                txt_descripcion.Text = fila.Cells["descripcion"].Value?.ToString();
            }
        }
        private void LimpiarCampos()
        {
            txt_idCategoria.Clear();
            txt_nombre.Clear();
            txt_descripcion.Clear();
        }
    }
}
