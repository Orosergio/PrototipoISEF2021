using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;


namespace CapaVista.Procesos.OrdenesCompra
{
    public partial class frmHistorial : Form
    {
        Controlador cn = new Controlador();
        public frmHistorial()
        {
            InitializeComponent();
            cmbMetodoPago.Items.Add("Seleccione...");
            cmbCompras.Items.Add("Seleccione...");
            cmbEmpleado.Items.Add("Seleccione...");
            cmbProveedor.Items.Add("Seleccione...");
            llenarComboBox("metodopago", "descripcionMetodo", cmbMetodoPago); //tabla, campo, combo|||| TABLAS(RECLUTAMIENTO, EMPLEADO),CAMPOS (R.nombre,R.apellido,R.idRecluta)
            llenarComboBox("COMPRAENCABEZADO", "pkNoDocumentoEnca", cmbCompras); //tabla, campo, combo|||| TABLAS(RECLUTAMIENTO, EMPLEADO),CAMPOS (R.nombre,R.apellido,R.idRecluta)
            llenarComboBox("empleado", "nombreEmpleado", cmbEmpleado); //tabla, campo, combo|||| TABLAS(RECLUTAMIENTO, EMPLEADO),CAMPOS (R.nombre,R.apellido,R.idRecluta)
            llenarComboBox("proveedor", "direccionProv", cmbProveedor); //tabla, campo, combo|||| TABLAS(RECLUTAMIENTO, EMPLEADO),CAMPOS (R.nombre,R.apellido,R.idRecluta)
            dtpInicio.Format = DateTimePickerFormat.Custom;
            dtpInicio.CustomFormat = "M'/'d'/'yyyy";
            dtpFin.Format = DateTimePickerFormat.Custom;
            dtpFin.CustomFormat = "M'/'d'/'yyyy";
        }

        //Mostrar los datos CAPA VISTA
        public void limpieza() {
            cmbMetodoPago.SelectedIndex = 0;
            cmbCompras.SelectedIndex = 0;
            cmbEmpleado.SelectedIndex = 0;
            cmbProveedor.SelectedIndex = 0;
        }

        string emp = "COMPRAENCABEZADO";
        public void actualizardatagriew()
        {
            DataTable dt = cn.llenarTbl(emp);
            dgvMostrar.DataSource = dt;

        }
      
        public void actualizardatagriewMetodo()
        {
            string metodo = txtMetodoPago.Text.ToString();
            DataTable dt = cn.llenarTblMetodoPago(metodo);
            dgvMostrar.DataSource = dt;

        }

        public void actualizardatagriewResponsable()
        {
            string metodo = txtCompras.Text.ToString();
            DataTable dt = cn.llenarTblResponsableCompra(metodo);
            dgvMostrar.DataSource = dt;

        }

        public void actualizardatagriewCompraEmpleado()
        {
            string metodo = txtEmpleado.Text.ToString();
            DataTable dt = cn.llenarTblComprasDeEmpleado(metodo);
            dgvMostrar.DataSource = dt;

        }

        public void actualizardatagriewFechas()
        {
            
            string inicio = dtpInicio.Text.ToString();
            string fin = dtpFin.Text.ToString();
            //MessageBox.Show("f1:"+inicio+",f2:"+fin);
            DataTable dt = cn.llenarTblFecha(inicio,fin);
            dgvMostrar.DataSource = dt;

        }

        public void actualizardatagriewProveedor()
        {
            string proveedor = txtProveedor.Text.ToString();
            DataTable dt = cn.llenarTblProveedor(proveedor);
            dgvMostrar.DataSource = dt;

        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            if (rbGeneral.Checked)
            {
                actualizardatagriew();
            }else if (rbMetodoPago.Checked)
            {
                actualizardatagriewMetodo();
            }
            else if (rbResponsable.Checked)
            {
                actualizardatagriewResponsable();
            }
            else if (rbComprasEmpleado.Checked)
            {
                actualizardatagriewCompraEmpleado();
            }
            else if (rbFecha.Checked)
            {
                actualizardatagriewFechas();
            }
            else if (rbProveedor.Checked)
            {
                actualizardatagriewProveedor();
            }
            limpieza();
        }

        private void cmbMetodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMetodoPago.Text = cmbMetodoPago.SelectedIndex.ToString();
        }

        void llenarComboBox(string tabla, string campo1, ComboBox ComboBox)
        {
            string[] items = cn.funcItems(tabla, campo1);
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] != null)
                {
                    if (items[i] != "")
                    {
                        ComboBox.Items.Add(items[i]);
                    }
                }

            }
            var dt2 = cn.enviarCombo(tabla, campo1);
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in dt2.Rows)
            {

                coleccion.Add(Convert.ToString(row[campo1]));
            }
            ComboBox.AutoCompleteCustomSource = coleccion;
            ComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ComboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void frmHistorial_Load(object sender, EventArgs e)
        {

        }

        private void rbMetodoPago_CheckedChanged(object sender, EventArgs e)
        {
            cmbMetodoPago.Visible = true;
            cmbCompras.Visible = false;
            cmbEmpleado.Visible = false;
            cmbProveedor.Visible = false;
            dtpInicio.Visible = false;
            dtpFin.Visible = false;
        }

        private void cmbCompras_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCompras.Text = cmbCompras.SelectedIndex.ToString();
        }

        private void cmbEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEmpleado.Text = cmbEmpleado.SelectedIndex.ToString();
        }

        private void cmbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtProveedor.Text = cmbProveedor.SelectedIndex.ToString();
        }

        private void rbResponsable_CheckedChanged(object sender, EventArgs e)
        {
            cmbMetodoPago.Visible = false;
            cmbCompras.Visible = true;
            cmbEmpleado.Visible = false;
            cmbProveedor.Visible = false;
            dtpInicio.Visible = false;
            dtpFin.Visible = false;
        }

        private void rbComprasEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            cmbMetodoPago.Visible = false;
            cmbCompras.Visible = false;
            cmbEmpleado.Visible = true;
            cmbProveedor.Visible = false;
            dtpInicio.Visible = false;
            dtpFin.Visible = false;
        }

        private void rbFecha_CheckedChanged(object sender, EventArgs e)
        {
            cmbMetodoPago.Visible = false;
            cmbCompras.Visible = false;
            cmbEmpleado.Visible = false;
            cmbProveedor.Visible = false;
            dtpInicio.Visible = true;
            dtpFin.Visible = true;
        }

        private void rbProveedor_CheckedChanged(object sender, EventArgs e)
        {
            cmbMetodoPago.Visible = false;
            cmbCompras.Visible = false;
            cmbEmpleado.Visible = false;
            cmbProveedor.Visible = true;
            dtpInicio.Visible = false;
            dtpFin.Visible = false;
        }

        private void rbGeneral_CheckedChanged(object sender, EventArgs e)
        {
            cmbMetodoPago.Visible = false;
            cmbCompras.Visible = false;
            cmbEmpleado.Visible = false;
            cmbProveedor.Visible = false;
            dtpInicio.Visible = false;
            dtpFin.Visible = false;
        }
    }
}
