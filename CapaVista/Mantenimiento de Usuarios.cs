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
    public partial class Mantenimiento_de_Usuarios : Form
    {
        private string nombreUsuario;
        CapaControlador.controlador capaControlador_usuarios = new CapaControlador.controlador();
        public Mantenimiento_de_Usuarios(string nombreUsuario)
        {
            InitializeComponent();
            this.nombreUsuario = nombreUsuario;
            CargarUsuarios();
        }

        private void salir_usuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu(nombreUsuario);
            menu.ShowDialog();
            this.Close();
        }

        //private void btn_guardarregistrousuario_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        capaControlador_usuarios.guardarUsuario(
        //            txt_nombreUsuario.Text,
        //            txt_usuarioLogin.Text,
        //            txtContra.Text,
        //            txt_correoUsuario.Text,
        //            txt_telefonoUsuario.Text,
        //            txt_puestoUsuario.Text,
        //            txt_Departamento.Text,


        //            null // departamento (ajustar si corresponde)
        //        );
        //        CargarUsuarios();
        //        LimpiarCampos();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Ocurrio un error: " + ex);
        //    }
        //}
        public void CargarUsuarios()
        {
            DataTable dt = capaControlador_usuarios.obtenerUsuarios();
            dgv_usuarios.DataSource = dt;
        }
        private void LimpiarCampos()
        {
            txt_idUsuario.Clear();
            txt_nombreUsuario.Clear();
            txt_telefonoUsuario.Clear();
            txt_correoUsuario.Clear();
            txt_puestoUsuario.Clear();
            txt_Departamento.Clear();
        }
        private void btn_modregistrousuario_Click(object sender, EventArgs e)
        {
            try
            {
                int idUsuario = Convert.ToInt32(txt_idUsuario.Text);
                capaControlador_usuarios.editarUsuario(
                    idUsuario,
                    txt_nombreUsuario.Text,
                    txt_usuarioLogin.Text,
                    txtContra.Text,
                    txt_correoUsuario.Text,
                    txt_telefonoUsuario.Text,
                    txt_puestoUsuario.Text,
                    txt_Departamento.Text
                );

                CargarUsuarios();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar: " + ex.Message);
            }
        }


        private void dgv_usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgv_usuarios.Rows[e.RowIndex];

                txt_idUsuario.Text = fila.Cells["id_usuario"].Value.ToString();
                txt_nombreUsuario.Text = fila.Cells["nombre_completo"].Value.ToString();
                txt_usuarioLogin.Text = fila.Cells["usuario_login"].Value.ToString();
                txtContra.Text = "********"; // 👈 No mostrar el hash
                txt_puestoUsuario.Text = fila.Cells["puesto"].Value.ToString();
                txt_Departamento.Text = fila.Cells["departamento"].Value.ToString();
                txt_telefonoUsuario.Text = fila.Cells["telefono"].Value.ToString();
                txt_correoUsuario.Text = fila.Cells["correo"].Value.ToString();
            }
        }


        private void btn_eliminarusuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_idUsuario.Text))
            {
                MessageBox.Show("Seleccione un empleado de la lista primero.");
                return;
            }

            int id_usuario = Convert.ToInt32(txt_idUsuario.Text);

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
                    capaControlador_usuarios.eliminarUsuario(id_usuario);
                    CargarUsuarios(); // refrescar DataGridView
                    LimpiarCampos();   // limpiar los textbox
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }

        private void btn_actualizarusuario_Click(object sender, EventArgs e)
        {
            try
            {
                CargarUsuarios();
                MessageBox.Show("Tabla actualizada con los ultimos registros");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el equipo: " + ex.Message);
            }
        }

        private void Mantenimiento_de_Usuarios_Load(object sender, EventArgs e)
        {
            txtContra.UseSystemPasswordChar = true;

        }

        private void btn_cambiarContrasena_MouseDown(object sender, MouseEventArgs e)
        {
            txtContra.UseSystemPasswordChar = false; // Mostrar contraseña

        }

        private void btn_cambiarContrasena_MouseUp(object sender, MouseEventArgs e)
        {
            txtContra.UseSystemPasswordChar = true; // Ocultar contraseña

        }


    }
}
