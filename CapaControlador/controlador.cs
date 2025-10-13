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
        public void registrarUsuario(string nombre_usuario, string usuario_login, string contraseña, string correo, string telefono, string puesto, string departamento)
        {
            // Llamamos a la función adaptada de c_Sentencias
            c_Sentencias.registrarUsuario(
                nombre_completo: nombre_usuario,
                usuario_login: usuario_login,
                contraseña: contraseña,
                correo: correo,
                telefono: telefono,
                puesto: puesto,
                departamento: departamento
            );
        }
        public bool iniciarSesion(string nombre_usuario, string contraseña)
        {
            return c_Sentencias.iniciarSesion(nombre_usuario, contraseña);
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
        //Logica de la tabla usuarios
        public void guardar_usuario(string nombre, string telefono, string correo, string direccion, string contacto)
        {
            c_Sentencias.guardarUsuarios(nombre,  telefono, correo, direccion, contacto);
        }
        public DataTable obtenerUsuarios()
        {
            return c_Sentencias.obtenerUsuarios();
        }
        public void editar_usuario(int id_usuario, string nombre, string telefono, string correo, string direccion, string contacto)
        {
            c_Sentencias.editar_usuario(id_usuario, nombre, telefono, correo, direccion, contacto);
        }
        public void eliminar_usuario(int id_usuario)
        {
            c_Sentencias.eliminar_usuario(id_usuario);
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
    }
}
