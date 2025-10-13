using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace CapaModelo
{
    public class Cls_sentencias
    {
        private conexion cn = new conexion();

        // Registrar usuario nuevo
        public void registrarUsuario(string nombre_completo, string usuario_login, string contrasena, string correo, string telefono, string puesto = null, string departamento = null)
        {
            using (OdbcConnection connection = cn.Conexion())
            {
                try
                {
                    string query = @"INSERT INTO Usuarios 
                                (nombre_completo, usuario_login, contrasena, puesto, departamento, telefono, correo)
                                VALUES (?, ?, ?, ?, ?, ?, ?)";

                    OdbcCommand cmd = new OdbcCommand(query, connection);
                    cmd.Parameters.AddWithValue("@nombre_completo", nombre_completo);
                    cmd.Parameters.AddWithValue("@usuario_login", usuario_login);
                    cmd.Parameters.AddWithValue("@contrasena", contrasena);
                    cmd.Parameters.AddWithValue("@puesto", puesto ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@departamento", departamento ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@telefono", telefono ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@correo", correo);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Usuario registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Logica para iniciar sesión
        public bool iniciarSesion(string nombre_usuario, string contrasena)
        {
            OdbcConnection connection = cn.Conexion();
            if (connection == null)
            {
                MessageBox.Show("No se pudo conectar a la base de datos", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                string query_iniciarSesion = "SELECT COUNT(*) FROM Usuarios WHERE usuario_login = ? AND contrasena = ?";
                OdbcCommand cmd = new OdbcCommand(query_iniciarSesion, connection);
                cmd.Parameters.AddWithValue("usuario_login", nombre_usuario);
                cmd.Parameters.AddWithValue("contrasena", contrasena);

                int resultado = Convert.ToInt32(cmd.ExecuteScalar());
                return resultado > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
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
                string query_guardar_movimientoBodega = "INSERT INTO Bodegas (nombre_bodega, ubicacion_bodega, capacidad_bodega) VALUES (?, ?, ?)";
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
                string query = "SELECT id_bodega, nombre_bodega, ubicacion_bodega, capacidad_bodega FROM Bodegas";
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
                string query_editar_MovimientoEmpleado = @"UPDATE Bodegas 
                             SET nombre_bodega = ?, ubicacion_bodega = ?, capacidad_bodega = ?
                             WHERE id_bodega = ?";
                OdbcCommand cmd2 = new OdbcCommand(query_editar_MovimientoEmpleado, connection);
                cmd2.Parameters.AddWithValue("nombre_bodega", nombre_bodega);
                cmd2.Parameters.AddWithValue("ubicacion_bodega", ubicacion_bodega);
                cmd2.Parameters.AddWithValue("capacidad_bodega", capacidad_bodega);
                cmd2.Parameters.AddWithValue("id_bodega", idBodega);

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
                string query = "DELETE FROM Bodegas WHERE id_bodega = ?";
                using (OdbcCommand cmd = new OdbcCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id_bodega", idBodega);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        //Logica de movimiento de equipos
        public void guardarEquipo(
            string codigoInventario,
            string nombreEquipo,
            string marca,
            string modelo,
            string numeroSerie,
            string descripcion,
            int idCategoria,
            int idEstado,
            int idBodega,
            DateTime fechaIngreso,
            DateTime fechaGarantia,
            string observaciones
        )
        {
            OdbcConnection connection = cn.Conexion();
            if (connection == null)
            {
                MessageBox.Show("No se pudo conectar a la base de datos", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string query_guardar_equipo = @"INSERT INTO Equipos 
            (codigo_inventario, nombre_equipo, marca, modelo, numero_serie, descripcion, 
             id_categoria, id_estado, id_bodega, fecha_ingreso, fecha_garantia, observaciones)
            VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

                OdbcCommand cmd = new OdbcCommand(query_guardar_equipo, connection);
                cmd.Parameters.AddWithValue("@codigo_inventario", codigoInventario);
                cmd.Parameters.AddWithValue("@nombre_equipo", nombreEquipo);
                cmd.Parameters.AddWithValue("@marca", marca);
                cmd.Parameters.AddWithValue("@modelo", modelo);
                cmd.Parameters.AddWithValue("@numero_serie", numeroSerie);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@id_categoria", idCategoria);
                cmd.Parameters.AddWithValue("@id_estado", idEstado);
                cmd.Parameters.AddWithValue("@id_bodega", idBodega);
                cmd.Parameters.AddWithValue("@fecha_ingreso", fechaIngreso);
                cmd.Parameters.AddWithValue("@fecha_garantia", fechaGarantia);
                cmd.Parameters.AddWithValue("@observaciones", observaciones);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Equipo guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al intentar registrar el equipo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable obtenerEquipos()
        {
            DataTable dt = new DataTable();
            using (OdbcConnection connection = cn.Conexion())
            {
                string query = @"
            SELECT 
                e.id_equipo,
                e.codigo_inventario,
                e.nombre_equipo,
                e.marca,
                e.modelo,
                e.numero_serie,
                e.descripcion,
                c.nombre_categoria AS categoria,
                s.nombre_estado AS estado,
                b.nombre_bodega AS bodega,
                e.fecha_ingreso,
                e.fecha_garantia,
                e.observaciones
            FROM Equipos e
            LEFT JOIN Categorias c ON e.id_categoria = c.id_categoria
            LEFT JOIN Estados_Equipos s ON e.id_estado = s.id_estado
            LEFT JOIN Bodegas b ON e.id_bodega = b.id_bodega
            ORDER BY e.id_equipo";

                using (OdbcDataAdapter da = new OdbcDataAdapter(query, connection))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }
        public void editar_equipos(
            int id_equipo,
            string codigoInventario,
            string nombre,
            string marca,
            string modelo,
            string numeroSerie,
            string descripcion,
            int idCategoria,
            int idEstado,
            int idBodega,
            DateTime fechaIngreso,
            DateTime fechaGarantia,
            string observaciones
        )
        {
            OdbcConnection connection = cn.Conexion();
            if (connection == null)
            {
                MessageBox.Show("No se pudo conectar a la base de datos", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string query_editar = @"UPDATE Equipos 
                                SET codigo_inventario = ?,
                                    nombre_equipo = ?,
                                    marca = ?,
                                    modelo = ?,
                                    numero_serie = ?,
                                    descripcion = ?,
                                    id_categoria = ?,
                                    id_estado = ?,
                                    id_bodega = ?,
                                    fecha_ingreso = ?,
                                    fecha_garantia = ?,
                                    observaciones = ?
                                WHERE id_equipo = ?";

                OdbcCommand cmd = new OdbcCommand(query_editar, connection);
                cmd.Parameters.AddWithValue("@codigo_inventario", codigoInventario);
                cmd.Parameters.AddWithValue("@nombre_equipo", nombre);
                cmd.Parameters.AddWithValue("@marca", marca);
                cmd.Parameters.AddWithValue("@modelo", modelo);
                cmd.Parameters.AddWithValue("@numero_serie", numeroSerie);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@id_categoria", idCategoria);
                cmd.Parameters.AddWithValue("@id_estado", idEstado);
                cmd.Parameters.AddWithValue("@id_bodega", idBodega);
                cmd.Parameters.AddWithValue("@fecha_ingreso", fechaIngreso);
                cmd.Parameters.AddWithValue("@fecha_garantia", fechaGarantia);
                cmd.Parameters.AddWithValue("@observaciones", observaciones);
                cmd.Parameters.AddWithValue("@id_equipo", id_equipo);

                int filas = cmd.ExecuteNonQuery();

                if (filas > 0)
                {
                    MessageBox.Show("Equipo actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontró el equipo con el ID especificado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar el equipo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
        public void eliminar_equipo(int id_equipo)
        {
            OdbcConnection connection = cn.Conexion();
            if (connection == null)
            {
                MessageBox.Show("No se pudo conectar a la base de datos", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string query = "DELETE FROM Equipos WHERE id_equipo = ?";
                OdbcCommand cmd = new OdbcCommand(query, connection);
                cmd.Parameters.AddWithValue("@id_equipo", id_equipo);

                int filas = cmd.ExecuteNonQuery();
                if (filas > 0)
                {
                    MessageBox.Show("Equipo eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontró el equipo con el ID especificado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el equipo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
        //Logica combo box
        public DataTable obtenerCategorias()
        {
            DataTable dt = new DataTable();
            using (OdbcConnection connection = cn.Conexion())
            {
                string query = "SELECT id_categoria, nombre_categoria FROM Categorias";
                using (OdbcDataAdapter da = new OdbcDataAdapter(query, connection))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }
        public DataTable obtenerEstado()
        {
            DataTable dt = new DataTable();
            using (OdbcConnection connection = cn.Conexion())
            {
                string query = "SELECT id_estado, nombre_estado FROM Estados_Equipos";
                using (OdbcDataAdapter da = new OdbcDataAdapter(query, connection))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }
        public DataTable obtenerBodega()
        {
            DataTable dt = new DataTable();
            using (OdbcConnection connection = cn.Conexion())
            {
                string query = "SELECT id_bodega, nombre_bodega FROM Bodegas";
                using (OdbcDataAdapter da = new OdbcDataAdapter(query, connection))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }
        public void CargarCategorias(ComboBox combo)
        {
            try
            {
                using (OdbcConnection connection = cn.Conexion())
                {
                    string query = "SELECT id_categoria, nombre_categoria FROM Categorias";
                    using (OdbcDataAdapter da = new OdbcDataAdapter(query, connection))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        combo.DataSource = dt;
                        combo.DisplayMember = "nombre_categoria";  // lo que se muestra
                        combo.ValueMember = "id_categoria";        // lo que se guarda
                        combo.SelectedIndex = -1; // Ninguno seleccionado al inicio
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message);
            }
        }
        public void CargarEstados(ComboBox combo)
        {
            try
            {
                using (OdbcConnection connection = cn.Conexion())
                {
                    string query = "SELECT id_estado, nombre_estado FROM Estados_Equipos";
                    using (OdbcDataAdapter da = new OdbcDataAdapter(query, connection))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        combo.DataSource = dt;
                        combo.DisplayMember = "nombre_categoria";  // lo que se muestra
                        combo.ValueMember = "id_categoria";        // lo que se guarda
                        combo.SelectedIndex = -1; // Ninguno seleccionado al inicio
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message);
            }
        }
        public void CargarBodegas(ComboBox combo)
        {
            try
            {
                using (OdbcConnection connection = cn.Conexion())
                {
                    string query = "SELECT id_bodega, nombre_bodega FROM Bodegas";
                    using (OdbcDataAdapter da = new OdbcDataAdapter(query, connection))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        combo.DataSource = dt;
                        combo.DisplayMember = "nombre_categoria";  // lo que se muestra
                        combo.ValueMember = "id_categoria";        // lo que se guarda
                        combo.SelectedIndex = -1; // Ninguno seleccionado al inicio
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message);
            }
        }
        // Guardar usuario (equivalente al registrar)
        public void guardarUsuario(string nombre_completo, string usuario_login, string contrasena, string correo, string telefono, string puesto, string departamento)
        {
            registrarUsuario(nombre_completo, usuario_login, contrasena, correo, telefono, puesto, departamento);
        }

        // Obtener todos los usuarios
        public DataTable obtenerUsuarios()
        {
            DataTable dt = new DataTable();
            using (OdbcConnection connection = cn.Conexion())
            {
                string query = @"SELECT id_usuario, nombre_completo, usuario_login, contrasena, puesto, departamento, telefono, correo
                             FROM Usuarios";
                using (OdbcDataAdapter da = new OdbcDataAdapter(query, connection))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }
        // Editar usuario existente
        public void editarUsuario(int id_usuario, string nombre_completo, string usuario_login, string contrasena, string correo, string telefono, string puesto, string departamento)
        {
            using (OdbcConnection connection = cn.Conexion())
            {
                try
                {
                    string query = @"UPDATE Usuarios
                                 SET nombre_completo = ?, usuario_login = ?, contrasena = ?, correo = ?, telefono = ?, puesto = ?, departamento = ?
                                 WHERE id_usuario = ?";

                    OdbcCommand cmd = new OdbcCommand(query, connection);
                    cmd.Parameters.AddWithValue("@nombre_completo", nombre_completo);
                    cmd.Parameters.AddWithValue("@usuario_login", usuario_login);
                    cmd.Parameters.AddWithValue("@contrasena", contrasena);
                    cmd.Parameters.AddWithValue("@correo", correo);
                    cmd.Parameters.AddWithValue("@telefono", telefono ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@puesto", puesto ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@departamento", departamento ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@id_usuario", id_usuario);

                    int filas = cmd.ExecuteNonQuery();
                    if (filas > 0)
                        MessageBox.Show("Usuario actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("No se encontró el usuario con el ID especificado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Eliminar usuario
        public void eliminarUsuario(int id_usuario)
        {
            using (OdbcConnection connection = cn.Conexion())
            {
                try
                {
                    string query = "DELETE FROM Usuarios WHERE id_usuario = ?";
                    OdbcCommand cmd = new OdbcCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id_usuario", id_usuario);

                    int filas = cmd.ExecuteNonQuery();

                    if (filas > 0)
                        MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("No se encontró el usuario con el ID especificado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
