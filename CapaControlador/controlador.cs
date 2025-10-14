using CapaModelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaControlador
{
    public class controlador
    {
        private Cls_sentencias c_Sentencias;
        public controlador()
        {
            c_Sentencias = new Cls_sentencias();
        }
        // Registrar nuevo usuario
        public void registrarUsuario(string nombre_completo, string usuario_login, string contrasena, string correo, string telefono, string puesto, string departamento)
        {
            c_Sentencias.registrarUsuario(
                nombre_completo: nombre_completo,
                usuario_login: usuario_login,
                contrasena: contrasena,
                correo: correo,
                telefono: telefono,
                puesto: puesto,
                departamento: departamento
            );
        }
        public bool iniciarSesion(string nombre_usuario, string contrasena)
        {
            return c_Sentencias.iniciarSesion(nombre_usuario, contrasena);
        }

        //Movimiento de bodegas
        public void guardar_movimientoBodega(string nombre_bodega, string ubicacion_bodega, string capacidad_bodega)
        {
            c_Sentencias.guardar_Movimientobodega(nombre_bodega, ubicacion_bodega, capacidad_bodega);
        }
        public DataTable obtenerBodegas()
        {
            return c_Sentencias.obtenerBodegas();
        }
        public void editar_movimientoBodega(int idBodega, string nombre_bodega, string ubicacion_bodega, string capacidad_bodega)
        {
            c_Sentencias.editar_movimientoBodega(idBodega, nombre_bodega, ubicacion_bodega, capacidad_bodega);
        }
        public void eliminarBodega(int idBodega)
        {
            c_Sentencias.eliminarBodega(idBodega);
        } 
        //Equipos
        public void guardar_equipo(string codigoInventario, string nombreEquipo, string marca, string modelo, string numeroSerie, string descripcion, int idCategoria, int idEstado, int idBodega, DateTime fechaIngreso, DateTime fechaGarantia, string observaciones)
        {
            c_Sentencias.guardarEquipo(
                codigoInventario,
                nombreEquipo,
                marca,
                modelo,
                numeroSerie,
                descripcion,
                idCategoria,
                idEstado,
                idBodega,
                fechaIngreso,
                fechaGarantia,
                observaciones
            );
        }
        public DataTable obtenerEquipos()
        {
            return c_Sentencias.obtenerEquipos();
        }
        public void editar_equipo(int id_equipo, string codigoInventario, string nombreEquipo, string marca, string modelo, string numeroSerie, string descripcion, int idCategoria, int idEstado, int idBodega, DateTime fechaIngreso, DateTime fechaGarantia, string observaciones)
        {
            c_Sentencias.editar_equipos(
                id_equipo,
                codigoInventario,
                nombreEquipo,
                marca,
                modelo,
                numeroSerie,
                descripcion,
                idCategoria,
                idEstado,
                idBodega,
                fechaIngreso,
                fechaGarantia,
                observaciones
            );
        }
        public void eliminar_equipo (int id_equipo)
        {
            c_Sentencias.eliminar_equipo(id_equipo); 
        }
        public void cargarCategorias (ComboBox box)
        {
            DataTable dt = c_Sentencias.obtenerCategorias();
            box.DataSource = dt;
            box.DisplayMember = "nombre_categoria";
            box.ValueMember = "id_categoria";
            box.SelectedIndex = -1;
        }
        public void cargarEstados(ComboBox box)
        {
            DataTable dt = c_Sentencias.obtenerEstado();
            box.DataSource = dt;
            box.DisplayMember = "nombre_estado";
            box.ValueMember = "id_estado";
            box.SelectedIndex = -1;
        }
        public void cargarBodegas(ComboBox box)
        {
            DataTable dt = c_Sentencias.obtenerBodega();
            box.DataSource = dt;
            box.DisplayMember = "nombre_bodega";
            box.ValueMember = "id_bodega";
            box.SelectedIndex = -1;
        }
        // Guardar usuario (variante simple)
        public void guardarUsuario(string nombre_completo, string usuario_login, string contrasena, string correo, string telefono, string puesto, string departamento)
        {
            c_Sentencias.guardarUsuario(nombre_completo, usuario_login, contrasena, correo, telefono, puesto, departamento);
        }


        // Obtener lista de usuarios
        public DataTable obtenerUsuarios()
        {
            return c_Sentencias.obtenerUsuarios();
        }

        // Editar usuario existente
        public void editarUsuario(int id_usuario, string nombre_completo, string usuario_login, string contrasena, string correo, string telefono, string puesto, string departamento)
        {
            c_Sentencias.editarUsuario(id_usuario, nombre_completo, usuario_login, contrasena, correo, telefono, puesto, departamento);
        }

        // Eliminar usuario
        public void eliminarUsuario(int id_usuario)
        {
            c_Sentencias.eliminarUsuario(id_usuario);
        }

        //Categorías
        public void guardar_movimientoCategoria(string nombre_categoria, string descripcion_categoria)
        {
            c_Sentencias.guardar_Movimientocategoria(nombre_categoria, descripcion_categoria);
        }
        public DataTable obtenerCategorias()
        {
            return c_Sentencias.obtenerCategorias();
        }
        public void editar_movimientoCategoria(int idCategoria, string nombre_categoria, string descripcion_categoria)
        {
            c_Sentencias.editar_movimientoCategoria(idCategoria, nombre_categoria, descripcion_categoria);
        }
        public void eliminarCategoria(int idCategoria)
        {
            c_Sentencias.eliminarCategoria(idCategoria);
        }
        //Estados
        public void guardar_movimientoEstado(string nombre_estado, string descripcion_estado)
        {
            c_Sentencias.guardar_Movimientoestado(nombre_estado, descripcion_estado);
        }
        public DataTable obtenerEstados()
        {
            return c_Sentencias.obtenerEstado();
        }
        public void editar_movimientoEstado(int idEstado, string nombre_estado, string descripcion_estado)
        {
            c_Sentencias.editar_movimientoEstado(idEstado, nombre_estado, descripcion_estado);
        }
        public void eliminarEstado(int idCategoria)
        {
            c_Sentencias.eliminarEstado(idCategoria);
        }


        // Inventario de equipos
        public void guardarInventario(int id_equipo, int stock_minimo, int stock_actual = 0)
        {
            c_Sentencias.guardarInventario(id_equipo, stock_minimo, stock_actual);
        }


        public DataTable obtenerInventario()
        {
            return c_Sentencias.obtenerInventario();
        }

        public void editarInventario(int id_inventario, int stock_minimo, int stock_actual)
        {
            c_Sentencias.editarInventario(id_inventario, stock_minimo, stock_actual);
        }

        public void eliminarInventario(int id_inventario)
        {
            c_Sentencias.eliminarInventario(id_inventario);
        }


    }
}
