using CapaModelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaControlador
{
    public class Controlador
    {
        Sentencias Modelo = new Sentencias();

        // LLenar una tabla CAPA CONTROLADOR
        public string[] funcItems(string Tabla, string Campo)
        {
            string[] Items = Modelo.funcLlenarCmb(Tabla, Campo);
            return Items;
        }
        public DataTable enviarCombo(string tabla, string campo1)
        {
            var dt1 = Modelo.obtenerCombo(tabla, campo1);
            return dt1;
        }

        // Llenar datagridview
        public DataTable llenarTbl(string tabla)
        {
            OdbcDataAdapter dt = Modelo.llenarTbl(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable llenarTblMetodoPago(string metodoPago)
        {
            OdbcDataAdapter dt = Modelo.llenarTblMetodoPago(metodoPago);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable llenarTblResponsableCompra(string compra)
        {
            OdbcDataAdapter dt = Modelo.llenarTblResponsable(compra);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable llenarTblComprasDeEmpleado(string empleado)
        {
            OdbcDataAdapter dt = Modelo.llenarTblComprasDeEmpleado(empleado);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable llenarTblFecha(string fechaInicio, string fechaFin)
        {
            OdbcDataAdapter dt = Modelo.llenarTblFecha(fechaInicio, fechaFin);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable llenarTblProveedor(string proveedor)
        {
            OdbcDataAdapter dt = Modelo.llenarTblProveedor(proveedor);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }




        //clsVariableGlobal glo = new clsVariableGlobal();
        public DataTable funcObtenerCamposCombobox(string Campo1, string Campo2, string Tabla, string Estado)
        {
            string Comando = string.Format("SELECT " + Campo1 + " ," + Campo2 + " FROM " + Tabla + " WHERE " + Estado + "= 1;");
            return Modelo.funcObtenerCamposCombobox(Comando);
        }
        public OdbcDataReader funcConsultaCombo(string Campo1, string Campo2, string Tabla, string Estado, string Codigo)
        {
            string Comando = string.Format("SELECT " + Campo1 + " FROM " + Tabla + " WHERE " + Estado + "= 1 AND " + Campo2 + " = " + Codigo + ";");
            return Modelo.funcConsulta(Comando);

        }
        public OdbcDataReader funcEliminar_perfil(string Codigo)
        {
            string Consulta = "UPDATE  control_producto SET resultado_control_producto = 'Finalizado', estado_control_producto = 0 where pk_id_control_producto = " + Codigo + ";";
            return Modelo.funcModificar(Consulta);
        }
        public OdbcDataReader funcConsultaDetallesCUI(string Tabla, string CodPedido)
        {
            string Consulta = "SELECT * FROM " + Tabla + " Where pk_id_usuario_pasaporte = " + CodPedido + ";";
            return Modelo.funcConsulta(Consulta);
        }
        public OdbcDataReader funcConsultaBanco(string Tabla, string CodPedido)
        {
            string Consulta = "SELECT estado_boleta FROM " + Tabla + " Where pk_numero_boleta = " + CodPedido + ";";
            return Modelo.funcConsulta(Consulta);
        }
        //Funcion para obtener datos combobox
        public DataTable funcObtenerCamposComboboxPais(string Campo1, string Campo2, string Tabla, string Estado)
        {
            string Comando = string.Format("SELECT " + Campo1 + " ," + Campo2 + " FROM " + Tabla + " WHERE " + Estado + "= 1;");
            return Modelo.funcObtenerCamposCombobox(Comando);
        }
        public DataTable funcObtenerCamposComboboxtipoorden(string Campo1, string Campo2, string Tabla, string Estado)
        {
            string Comando = string.Format("SELECT " + Campo1 + " ," + Campo2 + " FROM " + Tabla + " WHERE " + Estado + "= 1 LIMIT 2;");
            return Modelo.funcObtenerCamposCombobox(Comando);
        }
    }
}
