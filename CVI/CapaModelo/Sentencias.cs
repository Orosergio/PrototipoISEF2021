using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaModelo
{
   public class Sentencias
    {
        Conexion cn = new Conexion();
        OdbcCommand Comm;
        private DataTable tabla;

        public string[] funcLlenarCmb(string Tabla, string Campo)
        {
            string[] Campos = new string[100];
            int I = 0;
            string Sql = "SELECT " + Campo + " FROM " + Tabla + ";";
            try
            {
                OdbcCommand Command = new OdbcCommand(Sql, cn.conexion());
                OdbcDataReader Reader = Command.ExecuteReader();
                while (Reader.Read())
                {
                    Campos[I] = Reader.GetValue(0).ToString();
                    I++;
                }
            }
            catch (Exception Ex) { Console.WriteLine(Ex.Message.ToString() + " \nError en asignarCombo, revise los parametros \n -" + Tabla + "\n -" + Campo); }
            return Campos;
        }
        public DataTable obtenerCombo(string tabla, string campo1)
        {
            string sql = "SELECT " + campo1 + " FROM " + tabla + " ;";
            OdbcCommand command = new OdbcCommand(sql, cn.conexion());
            OdbcDataAdapter adaptador = new OdbcDataAdapter(command);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            return dt;
        }

        //funcion para realizar consultas al a DB
        public OdbcDataAdapter llenarTbl(string tabla)// metodo  que obtinene el contenio de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT * FROM " + tabla + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public OdbcDataAdapter llenarTblMetodoPago(string metodoPago)// metodo  que obtinene el contenio de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT P.direccionProv AS Proveedor, E.apellidoEmpleado AS Empleado, EM.nombreEmpresa, SUC.nombreSucursal, BOD.descripcionBodega, CE.fechaCompra, CE.totalCompra, TC.nombretipocompra, MP.descripcionMetodo "+
                "FROM proveedor P, empleado E, empresa EM, sucursal SUC, bodega BOD, compraencabezado CE, tipocompra TC, metodopago MP WHERE "+
                "P.pkIdProv = CE.fkIdProv AND E.pkIdEmpleado = CE.fkIdEmpleado AND EM.pkIdEmpresa = CE.fkIdEmpresa "+
                "AND SUC.pkIdSucursal = CE.fkIdSucursal AND BOD.pkIdBodega = CE.fkIdBodegadestino AND TC.pktipocompra = CE.fktipocompra AND MP.pkIdMetodoPago = CE.fkmetodoPago "+
                "AND MP.pkIdMetodoPago = "+metodoPago+"; ";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public OdbcDataAdapter llenarTblResponsable(string compra)// metodo  que obtinene el contenio de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT CE.pkNoDocumentoEnca, CE.totalCompra, CE.fechaCompra, P.direccionProv AS Proveedor, E.apellidoEmpleado, E.nombreEmpleado "+
                         "FROM proveedor P, empleado E, empresa EM, sucursal SUC, bodega BOD, compraencabezado CE, tipocompra TC, metodopago MP WHERE "+
                         "P.pkIdProv = CE.fkIdProv AND E.pkIdEmpleado = CE.fkIdEmpleado AND EM.pkIdEmpresa = CE.fkIdEmpresa "+
                         "AND SUC.pkIdSucursal = CE.fkIdSucursal AND BOD.pkIdBodega = CE.fkIdBodegadestino AND TC.pktipocompra = CE.fktipocompra AND MP.pkIdMetodoPago = CE.fkmetodoPago "+
                         "AND CE.pkNoDocumentoEnca = "+compra+"; ";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public OdbcDataAdapter llenarTblComprasDeEmpleado(string empleado)// metodo  que obtinene el contenio de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT P.direccionProv AS Proveedor, E.apellidoEmpleado AS Empleado, EM.nombreEmpresa, SUC.nombreSucursal, BOD.descripcionBodega, CE.fechaCompra, CE.totalCompra, TC.nombretipocompra, MP.descripcionMetodo "+
                "FROM proveedor P, empleado E, empresa EM, sucursal SUC, bodega BOD, compraencabezado CE, tipocompra TC, metodopago MP WHERE "+
                "P.pkIdProv = CE.fkIdProv AND E.pkIdEmpleado = CE.fkIdEmpleado AND EM.pkIdEmpresa = CE.fkIdEmpresa "+
                "AND SUC.pkIdSucursal = CE.fkIdSucursal AND BOD.pkIdBodega = CE.fkIdBodegadestino AND TC.pktipocompra = CE.fktipocompra AND MP.pkIdMetodoPago = CE.fkmetodoPago "+
                "AND E.pkIdEmpleado = "+empleado+"; ";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public OdbcDataAdapter llenarTblFecha(string fechaInicio, string fechaFin)// metodo  que obtinene el contenio de una tabla
        {
            MessageBox.Show("f1:" + fechaInicio + ",f2:" + fechaFin);
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT P.direccionProv AS Proveedor, E.apellidoEmpleado AS Empleado, EM.nombreEmpresa, SUC.nombreSucursal, BOD.descripcionBodega, CE.fechaCompra, CE.totalCompra, TC.nombretipocompra, MP.descripcionMetodo " +
                "FROM proveedor P, empleado E, empresa EM, sucursal SUC, bodega BOD, compraencabezado CE, tipocompra TC, metodopago MP WHERE "+
                "P.pkIdProv = CE.fkIdProv AND E.pkIdEmpleado = CE.fkIdEmpleado AND EM.pkIdEmpresa = CE.fkIdEmpresa "+
                "AND SUC.pkIdSucursal = CE.fkIdSucursal AND BOD.pkIdBodega = CE.fkIdBodegadestino AND TC.pktipocompra = CE.fktipocompra AND MP.pkIdMetodoPago = CE.fkmetodoPago AND "+
                "fechaCompra BETWEEN '"+fechaInicio+"' AND '"+fechaFin+"'; ";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public OdbcDataAdapter llenarTblProveedor(string proveedor)// metodo  que obtinene el contenio de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT P.direccionProv AS Proveedor, E.apellidoEmpleado AS Empleado, EM.nombreEmpresa, SUC.nombreSucursal, BOD.descripcionBodega, CE.fechaCompra, CE.totalCompra, TC.nombretipocompra, MP.descripcionMetodo "+
                "FROM proveedor P, empleado E, empresa EM, sucursal SUC, bodega BOD, compraencabezado CE, tipocompra TC, metodopago MP WHERE "+
                "P.pkIdProv = CE.fkIdProv AND E.pkIdEmpleado = CE.fkIdEmpleado AND EM.pkIdEmpresa = CE.fkIdEmpresa "+
                "AND SUC.pkIdSucursal = CE.fkIdSucursal AND BOD.pkIdBodega = CE.fkIdBodegadestino AND TC.pktipocompra = CE.fktipocompra AND MP.pkIdMetodoPago = CE.fkmetodoPago "+
                "AND P.pkIdProv = "+proveedor+"; ";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }






        public OdbcDataReader funcConsulta(string Consulta)
        {
            try
            {
                Comm = new OdbcCommand(Consulta, cn.conexion());
                OdbcDataReader reader = Comm.ExecuteReader();
                return reader;
            }
            catch (Exception Error)
            {
                Console.WriteLine("Error en modelo " + Error);
                return null;
            }

        }
        //Funcion obtener datos combobox
        public DataTable funcObtenerCamposCombobox(string Comando)
        {
            try
            {
                OdbcDataAdapter datos = new OdbcDataAdapter(Comando, cn.conexion());
                tabla = new DataTable();
                datos.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        //funcion para insertar en la BD
        public OdbcDataReader funcInsertar(String Consulta)
        {
            try
            {
                Comm = new OdbcCommand(Consulta, cn.conexion());
                OdbcDataReader mostrar = Comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine("Ocurrio un error al registrar modelo" + err);
                return null;
            }
        }
        //funcion para la modificacion en la DB
        public OdbcDataReader funcModificar(string Consulta)
        {
            try
            {
                Comm = new OdbcCommand(Consulta, cn.conexion());
                OdbcDataReader mostrar = Comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception Error)
            {
                Console.WriteLine("Error en modelo-modificar ", Error);
                return null;
            }
        }
    }
}
