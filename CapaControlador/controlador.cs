using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo;
using System.Data.Odbc;
using System.Data;

namespace CapaControlador
{
    public class controlador
    {
        private Cls_sentencias c_Sentencias;
        public controlador()
        {
            c_Sentencias = new Cls_sentencias();
        }
        public void registrarUsuario(string nombre_usuario, string contraseña, string correo, string telefono)
        {
            c_Sentencias.registrarUsuario(nombre_usuario, contraseña, correo, telefono);
        }
        public bool iniciarSesion(string nombre_usuario, string contraseña)
        {
            return c_Sentencias.iniciarSesion(nombre_usuario, contraseña);
        }

        //Movimiento de empleados
        public void guardar_movimientoEmpleado(string nombre_empleado, string apellido_empleado, string rol_empleado, string area, string tipo_movimiento)
        {
            c_Sentencias.guardar_Movimientoempleado(nombre_empleado, apellido_empleado, rol_empleado, area, tipo_movimiento);
        }
        public DataTable obtenerEmpleados()
        {
            return c_Sentencias.obtenerEmpleados();
        }
        public void editar_movimientoEmpleados(int idEmpleado, string nombre, string apellido, string rol, string area, string tipoMovimiento)
        {
            c_Sentencias.editar_Movimientoempleaod(idEmpleado, nombre, apellido, rol, area, tipoMovimiento);
        }
        public void eliminarEmpleado(int idEmpleado)
        {
            c_Sentencias.eliminarEmpleado(idEmpleado);
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
        public void guardar_equipo(string nombre, string marca, string categoria, int stock, string proveedor, string descripcion, string modelo, float precio_unitario, DateTime fecha_garantia)
        {
            c_Sentencias.guardarequipos(nombre, marca, categoria, stock, proveedor, descripcion, modelo, precio_unitario, fecha_garantia);
        }
        public DataTable obtenerEquipos()
        {
            return c_Sentencias.obtenerEquipos();
        }
        public void editar_equipo(int id_equipo, string nombre, string marca, string categoria, int stock, string proveedor, string descripcion, string modelo, float precio_unitario, DateTime fecha_garantia)
        {
            c_Sentencias.editar_equipos(id_equipo, nombre, marca, categoria, stock, proveedor, descripcion, modelo, precio_unitario, fecha_garantia);
        }
        public void eliminar_equipo (int id_equipo)
        {
            c_Sentencias.eliminarequipo(id_equipo); 
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
            c_Sentencias.eliminarequipo(id_usuario);
        } 
    }
}
