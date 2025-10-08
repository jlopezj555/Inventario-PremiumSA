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
        private string nombreUsuario;
        CapaControlador.controlador capaControlador_equipo = new CapaControlador.controlador();

        public Mantenimiento_de_Equipos(string nombreUsuario)
        {
            InitializeComponent();
            this.nombreUsuario = nombreUsuario;
            CargarEquipos();
        }

        private void salir_equipo_Click(object sender, EventArgs e)
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
                int stock;
                if(!int.TryParse(txt_stockEquipo.Text, out stock))
                {
                    MessageBox.Show("Ingresa un valo numerico valido en el stock");
                    return;
                }
                float precio;
                if(!float.TryParse(txt_preciouEquipo.Text, out precio))
                {
                    MessageBox.Show("Ingrese un valor numerico valdio en el precio");
                    return;
                }
                DateTime fechaGarantia = fechaSeleccionada.Value.Date;
                capaControlador_equipo.guardar_equipo(txt_nombreEquipo.Text, txt_marcaEquipo.Text, txt_categoriaEquipo.Text, stock, txt_provEquipo.Text, txt_descripcionEquipo.Text, txt_modeloEquipo.Text, precio, fechaGarantia);
                MessageBox.Show("Equipo registrado correctamente");
                CargarEquipos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el equipo: " + ex.Message);
            }
        }
        private void CargarEquipos()
        {
            DataTable dt = capaControlador_equipo.obtenerEquipos();
            dgv_equipos.DataSource = dt;
        }

        private void btn_modregistroequipo_Click(object sender, EventArgs e)
        {
            try
            {
                int stock;
                if (!int.TryParse(txt_stockEquipo.Text, out stock))
                {
                    MessageBox.Show("Ingresa un valo numerico valido en el stock");
                    return;
                }
                float precio;
                if (!float.TryParse(txt_preciouEquipo.Text, out precio))
                {
                    MessageBox.Show("Ingrese un valor numerico valdio en el precio");
                    return;
                }
                DateTime fechaGarantia = fechaSeleccionada.Value.Date;
                int idEquipo = Convert.ToInt32(txt_idEquipo.Text);
                capaControlador_equipo.editar_equipo(
                    idEquipo,
                    txt_nombreEquipo.Text,
                    txt_marcaEquipo.Text,
                    txt_categoriaEquipo.Text,
                    stock,
                    txt_provEquipo.Text,
                    txt_descripcionEquipo.Text,
                    txt_modeloEquipo.Text,
                    precio,
                    fechaGarantia
                );
                CargarEquipos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar: " + ex.Message);
            }
        }

        private void dgv_equipos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // validar que no sea header
            {
                DataGridViewRow fila = dgv_equipos.Rows[e.RowIndex];

                txt_idEquipo.Text = fila.Cells["id_equipo"].Value.ToString();
                txt_nombreEquipo.Text = fila.Cells["nombre"].Value.ToString();
                txt_marcaEquipo.Text = fila.Cells["marca"].Value.ToString();
                txt_categoriaEquipo.Text = fila.Cells["categoria"].Value.ToString();
                txt_stockEquipo.Text = fila.Cells["stock"].Value.ToString();
                txt_provEquipo.Text = fila.Cells["proveedor"].Value.ToString();
                txt_descripcionEquipo.Text = fila.Cells["descripcion"].Value.ToString();
                txt_modeloEquipo.Text = fila.Cells["modelo"].Value.ToString();
                txt_preciouEquipo.Text = fila.Cells["precio_unitario"].Value.ToString();
            }
        }
        private void LimpiarCampos()
        {
            txt_idEquipo.Clear();
            txt_nombreEquipo.Clear();
            txt_marcaEquipo.Clear();
            txt_categoriaEquipo.Clear();
            txt_stockEquipo.Clear();
            txt_provEquipo.Clear();
            txt_descripcionEquipo.Clear();
            txt_modeloEquipo.Clear();
            txt_preciouEquipo.Clear();
        }
        private void btn_eliminarequipo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_idEquipo.Text))
            {
                MessageBox.Show("Seleccione un empleado de la lista primero.");
                return;
            }

            int id_equipo = Convert.ToInt32(txt_idEquipo.Text);

            DialogResult result = MessageBox.Show(
                "¿Está seguro que desea eliminar este empleado?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    capaControlador_equipo.eliminar_equipo(id_equipo);
                    MessageBox.Show("Empleado eliminado correctamente.");
                    CargarEquipos(); // refrescar DataGridView
                    LimpiarCampos();   // limpiar los textbox
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }
        private void btn_actualizarequipo_Click(object sender, EventArgs e)
        {
            try
            {
                CargarEquipos();
                MessageBox.Show("Tabla actualizada con los ultimos registros");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el equipo: " + ex.Message);
            }
        }
    }
}
