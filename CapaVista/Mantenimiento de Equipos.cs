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
                // Validaciones básicas
                if (string.IsNullOrWhiteSpace(txt_codigoInventario.Text) ||
                    string.IsNullOrWhiteSpace(txt_nombreEquipo.Text))
                {
                    MessageBox.Show("El código de inventario y el nombre del equipo son obligatorios.");
                    return;
                }

                // Obtener IDs de ComboBox
                int idCategoria = Convert.ToInt32(cmb_idCategoria.SelectedValue);
                int idEstado = Convert.ToInt32(cmb_estado.SelectedValue);
                int idBodega = Convert.ToInt32(cmb_bodega.SelectedValue);

                // Fechas desde DateTimePicker
                DateTime fechaIngreso = fecha_ingreso.Value;
                DateTime fechaGarantia = fecha_garantia.Value;

                // Llamar al controlador para guardar
                capaControlador_equipo.guardar_equipo(
                    txt_codigoInventario.Text,
                    txt_nombreEquipo.Text,
                    txt_marcaEquipo.Text,
                    txt_modeloEquipo.Text,
                    txt_NumeroSerie.Text,
                    txt_descripcionEquipo.Text,
                    idCategoria,
                    idEstado,
                    idBodega,
                    fechaIngreso,
                    fechaGarantia,
                    txt_observaciones.Text
                );

                MessageBox.Show("Equipo registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refrescar DataGridView
                CargarEquipos();

                // Limpiar campos
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el equipo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (string.IsNullOrWhiteSpace(txt_idEquipo.Text))
                {
                    MessageBox.Show("Selecciona un equipo para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idEquipo = Convert.ToInt32(txt_idEquipo.Text);
                string codigoInventario = txt_codigoInventario.Text;
                string nombre = txt_nombreEquipo.Text;
                string marca = txt_marcaEquipo.Text;
                string modelo = txt_modeloEquipo.Text;
                string numeroSerie = txt_NumeroSerie.Text;
                string descripcion = txt_descripcionEquipo.Text;

                int idCategoria = Convert.ToInt32(cmb_idCategoria.SelectedValue);
                int idEstado = Convert.ToInt32(cmb_estado.SelectedValue);
                int idBodega = Convert.ToInt32(cmb_bodega.SelectedValue);

                DateTime FechaIngreso = fecha_ingreso.Value;
                DateTime FechaGarantia = fecha_garantia.Value;
                string observaciones = txt_observaciones.Text;

                // Llamar al método del controlador
                capaControlador_equipo.editar_equipo(
                    idEquipo,
                    codigoInventario,
                    nombre,
                    marca,
                    modelo,
                    numeroSerie,
                    descripcion,
                    idCategoria,
                    idEstado,
                    idBodega,
                    FechaIngreso,
                    FechaGarantia,
                    observaciones
                );

                CargarEquipos();   // recargar DataGridView
                LimpiarCampos();   // limpiar formulario
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el equipo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_equipos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // validar que no sea header
            {
                DataGridViewRow fila = dgv_equipos.Rows[e.RowIndex];

                txt_idEquipo.Text = fila.Cells["id_equipo"].Value.ToString();
                txt_nombreEquipo.Text = fila.Cells["nombre_equipo"].Value.ToString();
                txt_codigoInventario.Text = fila.Cells["codigo_inventario"].Value.ToString();
                txt_marcaEquipo.Text = fila.Cells["marca"].Value.ToString();
                txt_modeloEquipo.Text = fila.Cells["modelo"].Value.ToString();
                txt_NumeroSerie.Text = fila.Cells["numero_serie"].Value.ToString();
                txt_descripcionEquipo.Text = fila.Cells["descripcion"].Value.ToString();
                cmb_idCategoria.Text = fila.Cells["categoria"].Value?.ToString() ?? "";
                cmb_estado.Text = fila.Cells["estado"].Value?.ToString() ?? "";
                cmb_bodega.Text = fila.Cells["bodega"].Value?.ToString() ?? "";
                txt_observaciones.Text = fila.Cells["observaciones"].Value.ToString();
            }
        }
        private void LimpiarCampos()
        {
            txt_idEquipo.Clear();
            txt_codigoInventario.Clear();
            txt_nombreEquipo.Clear();
            txt_marcaEquipo.Clear();
            txt_modeloEquipo.Clear();
            txt_NumeroSerie.Clear();
            txt_descripcionEquipo.Clear();
            txt_observaciones.Clear();
        }
        private void btn_eliminarequipo_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_idEquipo.Text))
                {
                    MessageBox.Show("Selecciona un equipo para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idEquipo = Convert.ToInt32(txt_idEquipo.Text);

                DialogResult confirm = MessageBox.Show(
                    "¿Seguro que deseas eliminar este equipo?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirm == DialogResult.Yes)
                {
                    capaControlador_equipo.eliminar_equipo(idEquipo);
                    CargarEquipos();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el equipo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Mantenimiento_de_Equipos_Load(object sender, EventArgs e)
        {
            capaControlador_equipo.cargarCategorias(cmb_idCategoria);
            capaControlador_equipo.cargarEstados(cmb_estado);
            capaControlador_equipo.cargarBodegas(cmb_bodega);
        }
    }
}
