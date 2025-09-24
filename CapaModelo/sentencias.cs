using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Data;


namespace CapaModelo
{
    public class Cls_sentencias
    {
        private conexion cn = new conexion();

        //Logica para registrar un nuevo usuario
        public void registrarUsuario(string nombre_usuario, string contraseña, string correo, string telefono)
        {
            OdbcConnection connection = cn.Conexion();
            if (connection == null)
            {
                MessageBox.Show("No se pudo conectar a la base de datos", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string query_registrarUsuario = "INSERT INTO tbl_usuario (nombre_usuario, contraseña, correo, telefono) VALUES (?, ?, ?, ?)";
                OdbcCommand cmd = new OdbcCommand(query_registrarUsuario, connection);
                cmd.Parameters.AddWithValue("@nombre_usuario", nombre_usuario);
                cmd.Parameters.AddWithValue("@contraseña", contraseña);
                cmd.Parameters.AddWithValue("@correo", correo);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al intentar registrar el usuario" + ex.Message, "Error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            { cn.Conexion(); }
        }
        //Logica para iniciar sesión
        public bool iniciarSesion(string nombre_usuario, string contraseña)
        {
            OdbcConnection connection = cn.Conexion();
            if (connection == null)
            {
                MessageBox.Show("No se pudo conectar a la base de datos", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                string query_iniciarSesion = "SELECT COUNT(*) FROM tbl_usuario WHERE nombre_usuario = ? AND contraseña = ?";
                OdbcCommand cmd = new OdbcCommand(query_iniciarSesion, connection);
                cmd.Parameters.AddWithValue("nombre_usuario", nombre_usuario);
                cmd.Parameters.AddWithValue("contraseña", contraseña);

                int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                return resultado > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        //CRUD movimiento de empleados
        public void guardar_Movimientoempleado(string nombre_Empleado, string apellido_Empleado, string area, string rol, string tipomovimiento)
        {
            OdbcConnection connection = cn.Conexion();
            if (connection == null)
            {
                MessageBox.Show("No se pudo conectar a la base de datos", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string query_guardar_movimientoEmpleado = "INSERT INTO tbl_empleado (nombre_empleado, apellido_empleado, rol_empleado, area, tipo_movimiento) VALUES (?, ?, ?, ?, ?)";
                OdbcCommand cmd = new OdbcCommand(query_guardar_movimientoEmpleado, connection);
                cmd.Parameters.AddWithValue("@nombre_empleado", nombre_Empleado);
                cmd.Parameters.AddWithValue("@apellido_empleado", apellido_Empleado);
                cmd.Parameters.AddWithValue("@rol_empleado", rol);
                cmd.Parameters.AddWithValue("@area", area);
                cmd.Parameters.AddWithValue("@tipo_movimiento", tipomovimiento);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al intentar registrar el movimiento" + ex.Message, "Error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { cn.Conexion(); }
        }
        public DataTable obtenerEmpleados()
        {
            DataTable dt = new DataTable();
            using (OdbcConnection connection = cn.Conexion())
            {
                string query = "SELECT ID_empleado, nombre_empleado, apellido_empleado, rol_empleado, area, tipo_movimiento FROM tbl_empleado";
                using (OdbcDataAdapter da = new OdbcDataAdapter(query, connection))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }
        public void editar_Movimientoempleaod(int idEmpleado, string nombre, string apellido, string rol, string area, string tipoMovimiento)
        {
            OdbcConnection connection = cn.Conexion();
            if (connection == null)
            {
                MessageBox.Show("No se pudo conectar a la base de datos", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string query_editar_MovimientoEmpleado = @"UPDATE tbl_empleado 
                             SET nombre_empleado = ?, apellido_empleado = ?, rol_empleado = ?, 
                                 area = ?, tipo_movimiento = ?
                             WHERE ID_empleado = ?";
                OdbcCommand cmd = new OdbcCommand(query_editar_MovimientoEmpleado, connection);
                cmd.Parameters.AddWithValue("nombre_empleado", nombre);
                cmd.Parameters.AddWithValue("apellido_empleado", apellido);
                cmd.Parameters.AddWithValue("rol_empleado", rol);
                cmd.Parameters.AddWithValue("area", area);
                cmd.Parameters.AddWithValue("tipo_movimiento", tipoMovimiento);
                cmd.Parameters.AddWithValue("ID_empleado", idEmpleado);

                int filas = cmd.ExecuteNonQuery();
                if (filas > 0)
                {
                    MessageBox.Show("Empleado actualizado correctamente");
                }
                else
                {
                    MessageBox.Show("No se encontró el empleado con el ID especificado");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Hubo un error al intentar registrar el movimiento" + e.Message, "Error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void eliminarEmpleado(int idEmpleado)
        {
            using (OdbcConnection connection = cn.Conexion())
            {
                string query = "DELETE FROM tbl_empleado WHERE ID_empleado = ?";
                using (OdbcCommand cmd = new OdbcCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ID_empleado", idEmpleado);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //CRUD movimiento de bodegas
        public void guardar_Movimientobodega(string nombre_bodega, string ubicacion_bodega, string capacidad_bodega)
        {
            OdbcConnection connection = cn.Conexion();
            if (connection == null)
            {
                MessageBox.Show("No se pudo conectar a la base de datos", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string query_guardar_movimientoBodega = "INSERT INTO tbl_bodega (nombre_bodega, ubicacion_bodega, capacidad_bodega) VALUES (?, ?, ?)";
                OdbcCommand cmd = new OdbcCommand(query_guardar_movimientoBodega, connection);
                cmd.Parameters.AddWithValue("@nombre_bodega", nombre_bodega);
                cmd.Parameters.AddWithValue("@ubicacion_bodega", ubicacion_bodega);
                cmd.Parameters.AddWithValue("@capacidad_bodega", capacidad_bodega);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al intentar registrar el movimiento" + ex.Message, "Error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { cn.Conexion(); }
        }

        public DataTable obtenerBodegas()
        {
            DataTable dt = new DataTable();
            using (OdbcConnection connection = cn.Conexion())
            {
                string query = "SELECT ID_bodega, nombre_bodega, ubicacion_bodega, capacidad_bodega FROM tbl_bodega";
                using (OdbcDataAdapter da = new OdbcDataAdapter(query, connection))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }

        public void editar_movimientoBodega(int idBodega, string nombre_bodega, string ubicacion_bodega, string capacidad_bodega)
        {
            OdbcConnection connection = cn.Conexion();
            if (connection == null)
            {
                MessageBox.Show("No se pudo conectar a la base de datos", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string query_editar_MovimientoEmpleado = @"UPDATE tbl_bodega 
                             SET nombre_bodega = ?, ubicacion_bodega = ?, capacidad_bodega = ?
                             WHERE ID_bodega = ?";
                OdbcCommand cmd2 = new OdbcCommand(query_editar_MovimientoEmpleado, connection);
                cmd2.Parameters.AddWithValue("nombre_bodega", nombre_bodega);
                cmd2.Parameters.AddWithValue("ubicacion_bodega", ubicacion_bodega);
                cmd2.Parameters.AddWithValue("capacidad_bodega", capacidad_bodega);
                cmd2.Parameters.AddWithValue("ID_bodega", idBodega);

                int filas = cmd2.ExecuteNonQuery();
                if (filas > 0)
                {
                    MessageBox.Show("Empleado actualizado correctamente");
                }
                else
                {
                    MessageBox.Show("No se encontró el empleado con el ID especificado");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Hubo un error al intentar registrar el movimiento" + e.Message, "Error: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void eliminarBodega(int idBodega)
        {
            using (OdbcConnection connection = cn.Conexion())
            {
                string query = "DELETE FROM tbl_bodega WHERE ID_bodega = ?";
                using (OdbcCommand cmd = new OdbcCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ID_bodega", idBodega);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
