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
    }
}
