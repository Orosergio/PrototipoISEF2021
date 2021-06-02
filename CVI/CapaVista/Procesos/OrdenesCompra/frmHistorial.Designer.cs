namespace CapaVista.Procesos.OrdenesCompra
{
    partial class frmHistorial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.rbGeneral = new System.Windows.Forms.RadioButton();
            this.rbMetodoPago = new System.Windows.Forms.RadioButton();
            this.rbResponsable = new System.Windows.Forms.RadioButton();
            this.rbComprasEmpleado = new System.Windows.Forms.RadioButton();
            this.rbFecha = new System.Windows.Forms.RadioButton();
            this.rbProveedor = new System.Windows.Forms.RadioButton();
            this.cmbMetodoPago = new System.Windows.Forms.ComboBox();
            this.txtMetodoPago = new System.Windows.Forms.TextBox();
            this.cmbCompras = new System.Windows.Forms.ComboBox();
            this.txtCompras = new System.Windows.Forms.TextBox();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbProveedor);
            this.groupBox1.Controls.Add(this.rbFecha);
            this.groupBox1.Controls.Add(this.rbComprasEmpleado);
            this.groupBox1.Controls.Add(this.rbResponsable);
            this.groupBox1.Controls.Add(this.rbMetodoPago);
            this.groupBox1.Controls.Add(this.rbGeneral);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 319);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por";
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.AllowUserToAddRows = false;
            this.dgvMostrar.AllowUserToDeleteRows = false;
            this.dgvMostrar.AllowUserToResizeColumns = false;
            this.dgvMostrar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Location = new System.Drawing.Point(267, 180);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.ReadOnly = true;
            this.dgvMostrar.Size = new System.Drawing.Size(773, 224);
            this.dgvMostrar.TabIndex = 1;
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(859, 104);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(128, 58);
            this.btnBusqueda.TabIndex = 2;
            this.btnBusqueda.Text = "Consultar";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // rbGeneral
            // 
            this.rbGeneral.AutoSize = true;
            this.rbGeneral.Location = new System.Drawing.Point(20, 45);
            this.rbGeneral.Name = "rbGeneral";
            this.rbGeneral.Size = new System.Drawing.Size(62, 17);
            this.rbGeneral.TabIndex = 0;
            this.rbGeneral.TabStop = true;
            this.rbGeneral.Text = "General";
            this.rbGeneral.UseVisualStyleBackColor = true;
            this.rbGeneral.CheckedChanged += new System.EventHandler(this.rbGeneral_CheckedChanged);
            // 
            // rbMetodoPago
            // 
            this.rbMetodoPago.AutoSize = true;
            this.rbMetodoPago.Location = new System.Drawing.Point(20, 83);
            this.rbMetodoPago.Name = "rbMetodoPago";
            this.rbMetodoPago.Size = new System.Drawing.Size(103, 17);
            this.rbMetodoPago.TabIndex = 1;
            this.rbMetodoPago.TabStop = true;
            this.rbMetodoPago.Text = "Método de pago";
            this.rbMetodoPago.UseVisualStyleBackColor = true;
            this.rbMetodoPago.CheckedChanged += new System.EventHandler(this.rbMetodoPago_CheckedChanged);
            // 
            // rbResponsable
            // 
            this.rbResponsable.AutoSize = true;
            this.rbResponsable.Location = new System.Drawing.Point(20, 125);
            this.rbResponsable.Name = "rbResponsable";
            this.rbResponsable.Size = new System.Drawing.Size(141, 17);
            this.rbResponsable.TabIndex = 2;
            this.rbResponsable.TabStop = true;
            this.rbResponsable.Text = "Responsable de Compra";
            this.rbResponsable.UseVisualStyleBackColor = true;
            this.rbResponsable.CheckedChanged += new System.EventHandler(this.rbResponsable_CheckedChanged);
            // 
            // rbComprasEmpleado
            // 
            this.rbComprasEmpleado.AutoSize = true;
            this.rbComprasEmpleado.Location = new System.Drawing.Point(20, 166);
            this.rbComprasEmpleado.Name = "rbComprasEmpleado";
            this.rbComprasEmpleado.Size = new System.Drawing.Size(171, 17);
            this.rbComprasEmpleado.TabIndex = 3;
            this.rbComprasEmpleado.TabStop = true;
            this.rbComprasEmpleado.Text = "Compras hechas por empleado";
            this.rbComprasEmpleado.UseVisualStyleBackColor = true;
            this.rbComprasEmpleado.CheckedChanged += new System.EventHandler(this.rbComprasEmpleado_CheckedChanged);
            // 
            // rbFecha
            // 
            this.rbFecha.AutoSize = true;
            this.rbFecha.Location = new System.Drawing.Point(20, 208);
            this.rbFecha.Name = "rbFecha";
            this.rbFecha.Size = new System.Drawing.Size(55, 17);
            this.rbFecha.TabIndex = 4;
            this.rbFecha.TabStop = true;
            this.rbFecha.Text = "Fecha";
            this.rbFecha.UseVisualStyleBackColor = true;
            this.rbFecha.CheckedChanged += new System.EventHandler(this.rbFecha_CheckedChanged);
            // 
            // rbProveedor
            // 
            this.rbProveedor.AutoSize = true;
            this.rbProveedor.Location = new System.Drawing.Point(20, 255);
            this.rbProveedor.Name = "rbProveedor";
            this.rbProveedor.Size = new System.Drawing.Size(127, 17);
            this.rbProveedor.TabIndex = 5;
            this.rbProveedor.TabStop = true;
            this.rbProveedor.Text = "Proveedor de compra";
            this.rbProveedor.UseVisualStyleBackColor = true;
            this.rbProveedor.CheckedChanged += new System.EventHandler(this.rbProveedor_CheckedChanged);
            // 
            // cmbMetodoPago
            // 
            this.cmbMetodoPago.FormattingEnabled = true;
            this.cmbMetodoPago.Location = new System.Drawing.Point(286, 79);
            this.cmbMetodoPago.Name = "cmbMetodoPago";
            this.cmbMetodoPago.Size = new System.Drawing.Size(162, 21);
            this.cmbMetodoPago.TabIndex = 3;
            this.cmbMetodoPago.Visible = false;
            this.cmbMetodoPago.SelectedIndexChanged += new System.EventHandler(this.cmbMetodoPago_SelectedIndexChanged);
            // 
            // txtMetodoPago
            // 
            this.txtMetodoPago.Location = new System.Drawing.Point(485, 79);
            this.txtMetodoPago.Name = "txtMetodoPago";
            this.txtMetodoPago.Size = new System.Drawing.Size(70, 20);
            this.txtMetodoPago.TabIndex = 4;
            this.txtMetodoPago.Visible = false;
            // 
            // cmbCompras
            // 
            this.cmbCompras.FormattingEnabled = true;
            this.cmbCompras.Location = new System.Drawing.Point(286, 78);
            this.cmbCompras.Name = "cmbCompras";
            this.cmbCompras.Size = new System.Drawing.Size(55, 21);
            this.cmbCompras.TabIndex = 5;
            this.cmbCompras.Visible = false;
            this.cmbCompras.SelectedIndexChanged += new System.EventHandler(this.cmbCompras_SelectedIndexChanged);
            // 
            // txtCompras
            // 
            this.txtCompras.Location = new System.Drawing.Point(485, 82);
            this.txtCompras.Name = "txtCompras";
            this.txtCompras.Size = new System.Drawing.Size(100, 20);
            this.txtCompras.TabIndex = 6;
            this.txtCompras.Visible = false;
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(286, 79);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(193, 21);
            this.cmbEmpleado.TabIndex = 7;
            this.cmbEmpleado.Visible = false;
            this.cmbEmpleado.SelectedIndexChanged += new System.EventHandler(this.cmbEmpleado_SelectedIndexChanged);
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(485, 82);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtEmpleado.TabIndex = 8;
            this.txtEmpleado.Visible = false;
            // 
            // dtpInicio
            // 
            this.dtpInicio.CustomFormat = "";
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(286, 121);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(103, 20);
            this.dtpInicio.TabIndex = 9;
            this.dtpInicio.Visible = false;
            // 
            // dtpFin
            // 
            this.dtpFin.CustomFormat = "";
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFin.Location = new System.Drawing.Point(395, 121);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(100, 20);
            this.dtpFin.TabIndex = 10;
            this.dtpFin.Visible = false;
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(286, 78);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(172, 21);
            this.cmbProveedor.TabIndex = 11;
            this.cmbProveedor.Visible = false;
            this.cmbProveedor.SelectedIndexChanged += new System.EventHandler(this.cmbProveedor_SelectedIndexChanged);
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(485, 83);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(100, 20);
            this.txtProveedor.TabIndex = 12;
            this.txtProveedor.Visible = false;
            // 
            // frmHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1052, 437);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.cmbProveedor);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.cmbEmpleado);
            this.Controls.Add(this.txtCompras);
            this.Controls.Add(this.cmbCompras);
            this.Controls.Add(this.txtMetodoPago);
            this.Controls.Add(this.cmbMetodoPago);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.dgvMostrar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHistorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHistorial";
            this.Load += new System.EventHandler(this.frmHistorial_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvMostrar;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.RadioButton rbProveedor;
        private System.Windows.Forms.RadioButton rbFecha;
        private System.Windows.Forms.RadioButton rbComprasEmpleado;
        private System.Windows.Forms.RadioButton rbResponsable;
        private System.Windows.Forms.RadioButton rbMetodoPago;
        private System.Windows.Forms.RadioButton rbGeneral;
        private System.Windows.Forms.ComboBox cmbMetodoPago;
        private System.Windows.Forms.TextBox txtMetodoPago;
        private System.Windows.Forms.ComboBox cmbCompras;
        private System.Windows.Forms.TextBox txtCompras;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.TextBox txtProveedor;
    }
}