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
    public partial class Movimiento_de_empleados : Form
    {
        private string nombreUsuario;
        CapaControlador.controlador capaControlador_movimiento = new CapaControlador.controlador();
        public Movimiento_de_empleados(string nombreUsuario)
        {
            InitializeComponent();
            CargarEmpleados();
            this.nombreUsuario = nombreUsuario;
            this.Size = new Size(960, 600); // ancho x alto
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void salir_movbodegas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu(nombreUsuario); 
            menu.ShowDialog();
            this.Close();
        }

        private void btn_guardarMovimiento_Click(object sender, EventArgs e)
        {
            try
            {
                capaControlador_movimiento.guardar_movimientoEmpleado(txt_Nombre.Text, txt_Apellido.Text, txt_roles.Text, txt_area.Text, txt_tipoMovimiento.Text);
                MessageBox.Show("Se registro el movimiento correctamente");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un error " + ex.Message);
            }
        }
        private void CargarEmpleados()
        {
            DataTable dt = capaControlador_movimiento.obtenerEmpleados();
            dgv_empleados.DataSource = dt;
        }

        private void btn_editarMovimiento_Click(object sender, EventArgs e)
        {
            try
            {
                int idEmpleado = Convert.ToInt32(txt_id_Empleado.Text);
                capaControlador_movimiento.editar_movimientoEmpleados(
                    idEmpleado,
                    txt_Nombre.Text,
                    txt_Apellido.Text,
                    txt_area.Text,
                    txt_roles.Text,
                    txt_tipoMovimiento.Text

                );
                CargarEmpleados();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al editar: " + ex.Message);
            }
        }

        private void dgv_empleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0) // validar que no sea header
            {
                DataGridViewRow fila = dgv_empleados.Rows[e.RowIndex];

                txt_id_Empleado.Text = fila.Cells["ID_empleado"].Value.ToString();
                txt_Nombre.Text = fila.Cells["nombre_empleado"].Value.ToString();
                txt_Apellido.Text = fila.Cells["apellido_empleado"].Value.ToString();
                txt_area.Text = fila.Cells["rol_empleado"].Value.ToString();
                txt_roles.Text = fila.Cells["area"].Value.ToString();
                txt_tipoMovimiento.Text = fila.Cells["tipo_movimiento"].Value.ToString();
            }
        }
        private void LimpiarCampos()
        {
            txt_Nombre.Clear();
            txt_Apellido.Clear();
            txt_area.Clear();
            txt_roles.Clear();
            txt_tipoMovimiento.Clear();
        }

        private void btn_eliminarMovimiento_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_id_Empleado.Text))
            {
                MessageBox.Show("Seleccione un empleado de la lista primero.");
                return;
            }

            int idEmpleado = Convert.ToInt32(txt_id_Empleado.Text);

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
                    capaControlador_movimiento.eliminarEmpleado(idEmpleado);
                    MessageBox.Show("Empleado eliminado correctamente.");
                    CargarEmpleados(); // refrescar DataGridView
                    LimpiarCampos();   // limpiar los textbox
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }
    }
}
