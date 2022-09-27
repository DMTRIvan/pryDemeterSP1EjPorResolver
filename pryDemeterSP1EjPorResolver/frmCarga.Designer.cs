namespace pryDemeterSP1EjPorResolver
{
    partial class frmCarga
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcCarga = new System.Windows.Forms.TabControl();
            this.tpCliente = new System.Windows.Forms.TabPage();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtNumeroCliente = new System.Windows.Forms.TextBox();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblNumeroCliente = new System.Windows.Forms.Label();
            this.lblCargarCliente = new System.Windows.Forms.Label();
            this.tpVendedor = new System.Windows.Forms.TabPage();
            this.txtComision = new System.Windows.Forms.TextBox();
            this.lblComision = new System.Windows.Forms.Label();
            this.txtCargarVendedor = new System.Windows.Forms.Button();
            this.txtNombreVendedor = new System.Windows.Forms.TextBox();
            this.txtNumeroVendedor = new System.Windows.Forms.TextBox();
            this.lblNombreVendedor = new System.Windows.Forms.Label();
            this.lblNumeroVendedor = new System.Windows.Forms.Label();
            this.txtCargueVendedor = new System.Windows.Forms.Label();
            this.tpVentas = new System.Windows.Forms.TabPage();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.cmdCargar1 = new System.Windows.Forms.Button();
            this.txtNumeroDeFactura = new System.Windows.Forms.TextBox();
            this.lblTipoFactura = new System.Windows.Forms.Label();
            this.txtFacturaVentass = new System.Windows.Forms.TextBox();
            this.dtpVenta = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTipoDeFactura = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstIDCliente = new System.Windows.Forms.ComboBox();
            this.lstNombreVenta = new System.Windows.Forms.ComboBox();
            this.lblNombreVenta = new System.Windows.Forms.Label();
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.tcCarga.SuspendLayout();
            this.tpCliente.SuspendLayout();
            this.tpVendedor.SuspendLayout();
            this.tpVentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcCarga
            // 
            this.tcCarga.Controls.Add(this.tpCliente);
            this.tcCarga.Controls.Add(this.tpVendedor);
            this.tcCarga.Controls.Add(this.tpVentas);
            this.tcCarga.Location = new System.Drawing.Point(12, 13);
            this.tcCarga.Name = "tcCarga";
            this.tcCarga.SelectedIndex = 0;
            this.tcCarga.Size = new System.Drawing.Size(336, 334);
            this.tcCarga.TabIndex = 0;
            this.tcCarga.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tpCliente
            // 
            this.tpCliente.Controls.Add(this.txtNombreCliente);
            this.tpCliente.Controls.Add(this.txtNumeroCliente);
            this.tpCliente.Controls.Add(this.cmdCargar);
            this.tpCliente.Controls.Add(this.lblNombreCliente);
            this.tpCliente.Controls.Add(this.lblNumeroCliente);
            this.tpCliente.Controls.Add(this.lblCargarCliente);
            this.tpCliente.Location = new System.Drawing.Point(4, 22);
            this.tpCliente.Name = "tpCliente";
            this.tpCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tpCliente.Size = new System.Drawing.Size(328, 308);
            this.tpCliente.TabIndex = 0;
            this.tpCliente.Text = "Cliente";
            this.tpCliente.UseVisualStyleBackColor = true;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(195, 93);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(127, 20);
            this.txtNombreCliente.TabIndex = 5;
            // 
            // txtNumeroCliente
            // 
            this.txtNumeroCliente.Location = new System.Drawing.Point(195, 55);
            this.txtNumeroCliente.Name = "txtNumeroCliente";
            this.txtNumeroCliente.Size = new System.Drawing.Size(127, 20);
            this.txtNumeroCliente.TabIndex = 4;
            // 
            // cmdCargar
            // 
            this.cmdCargar.Location = new System.Drawing.Point(220, 171);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(75, 23);
            this.cmdCargar.TabIndex = 3;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(29, 96);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(145, 13);
            this.lblNombreCliente.TabIndex = 2;
            this.lblNombreCliente.Text = "Nombre y apellido del cliente:";
            // 
            // lblNumeroCliente
            // 
            this.lblNumeroCliente.AutoSize = true;
            this.lblNumeroCliente.Location = new System.Drawing.Point(32, 58);
            this.lblNumeroCliente.Name = "lblNumeroCliente";
            this.lblNumeroCliente.Size = new System.Drawing.Size(98, 13);
            this.lblNumeroCliente.TabIndex = 1;
            this.lblNumeroCliente.Text = "Numero del cliente:";
            // 
            // lblCargarCliente
            // 
            this.lblCargarCliente.AutoSize = true;
            this.lblCargarCliente.Location = new System.Drawing.Point(104, 19);
            this.lblCargarCliente.Name = "lblCargarCliente";
            this.lblCargarCliente.Size = new System.Drawing.Size(134, 13);
            this.lblCargarCliente.TabIndex = 0;
            this.lblCargarCliente.Text = "Por favor cargue el cliente:";
            // 
            // tpVendedor
            // 
            this.tpVendedor.Controls.Add(this.txtComision);
            this.tpVendedor.Controls.Add(this.lblComision);
            this.tpVendedor.Controls.Add(this.txtCargarVendedor);
            this.tpVendedor.Controls.Add(this.txtNombreVendedor);
            this.tpVendedor.Controls.Add(this.txtNumeroVendedor);
            this.tpVendedor.Controls.Add(this.lblNombreVendedor);
            this.tpVendedor.Controls.Add(this.lblNumeroVendedor);
            this.tpVendedor.Controls.Add(this.txtCargueVendedor);
            this.tpVendedor.Location = new System.Drawing.Point(4, 22);
            this.tpVendedor.Name = "tpVendedor";
            this.tpVendedor.Padding = new System.Windows.Forms.Padding(3);
            this.tpVendedor.Size = new System.Drawing.Size(328, 308);
            this.tpVendedor.TabIndex = 1;
            this.tpVendedor.Text = "Vendedor";
            this.tpVendedor.UseVisualStyleBackColor = true;
            // 
            // txtComision
            // 
            this.txtComision.Location = new System.Drawing.Point(183, 136);
            this.txtComision.Name = "txtComision";
            this.txtComision.Size = new System.Drawing.Size(127, 20);
            this.txtComision.TabIndex = 13;
            // 
            // lblComision
            // 
            this.lblComision.AutoSize = true;
            this.lblComision.Location = new System.Drawing.Point(17, 139);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(52, 13);
            this.lblComision.TabIndex = 12;
            this.lblComision.Text = "Comisión:";
            // 
            // txtCargarVendedor
            // 
            this.txtCargarVendedor.Location = new System.Drawing.Point(197, 181);
            this.txtCargarVendedor.Name = "txtCargarVendedor";
            this.txtCargarVendedor.Size = new System.Drawing.Size(113, 23);
            this.txtCargarVendedor.TabIndex = 11;
            this.txtCargarVendedor.Text = "Cargar vendedor";
            this.txtCargarVendedor.UseVisualStyleBackColor = true;
            this.txtCargarVendedor.Click += new System.EventHandler(this.txtCargarVendedor_Click);
            // 
            // txtNombreVendedor
            // 
            this.txtNombreVendedor.Location = new System.Drawing.Point(183, 98);
            this.txtNombreVendedor.Name = "txtNombreVendedor";
            this.txtNombreVendedor.Size = new System.Drawing.Size(127, 20);
            this.txtNombreVendedor.TabIndex = 10;
            // 
            // txtNumeroVendedor
            // 
            this.txtNumeroVendedor.Location = new System.Drawing.Point(183, 60);
            this.txtNumeroVendedor.Name = "txtNumeroVendedor";
            this.txtNumeroVendedor.Size = new System.Drawing.Size(127, 20);
            this.txtNumeroVendedor.TabIndex = 9;
            // 
            // lblNombreVendedor
            // 
            this.lblNombreVendedor.AutoSize = true;
            this.lblNombreVendedor.Location = new System.Drawing.Point(17, 101);
            this.lblNombreVendedor.Name = "lblNombreVendedor";
            this.lblNombreVendedor.Size = new System.Drawing.Size(159, 13);
            this.lblNombreVendedor.TabIndex = 8;
            this.lblNombreVendedor.Text = "Nombre y apellido del vendedor:";
            // 
            // lblNumeroVendedor
            // 
            this.lblNumeroVendedor.AutoSize = true;
            this.lblNumeroVendedor.Location = new System.Drawing.Point(20, 63);
            this.lblNumeroVendedor.Name = "lblNumeroVendedor";
            this.lblNumeroVendedor.Size = new System.Drawing.Size(112, 13);
            this.lblNumeroVendedor.TabIndex = 7;
            this.lblNumeroVendedor.Text = "Numero del vendedor:";
            // 
            // txtCargueVendedor
            // 
            this.txtCargueVendedor.AutoSize = true;
            this.txtCargueVendedor.Location = new System.Drawing.Point(92, 24);
            this.txtCargueVendedor.Name = "txtCargueVendedor";
            this.txtCargueVendedor.Size = new System.Drawing.Size(148, 13);
            this.txtCargueVendedor.TabIndex = 6;
            this.txtCargueVendedor.Text = "Por favor cargue el vendedor:";
            // 
            // tpVentas
            // 
            this.tpVentas.Controls.Add(this.txtMonto);
            this.tpVentas.Controls.Add(this.lblMonto);
            this.tpVentas.Controls.Add(this.cmdCargar1);
            this.tpVentas.Controls.Add(this.txtNumeroDeFactura);
            this.tpVentas.Controls.Add(this.lblTipoFactura);
            this.tpVentas.Controls.Add(this.txtFacturaVentass);
            this.tpVentas.Controls.Add(this.dtpVenta);
            this.tpVentas.Controls.Add(this.lblFecha);
            this.tpVentas.Controls.Add(this.lblTipoDeFactura);
            this.tpVentas.Controls.Add(this.label1);
            this.tpVentas.Controls.Add(this.lstIDCliente);
            this.tpVentas.Controls.Add(this.lstNombreVenta);
            this.tpVentas.Controls.Add(this.lblNombreVenta);
            this.tpVentas.Location = new System.Drawing.Point(4, 22);
            this.tpVentas.Name = "tpVentas";
            this.tpVentas.Padding = new System.Windows.Forms.Padding(3);
            this.tpVentas.Size = new System.Drawing.Size(328, 308);
            this.tpVentas.TabIndex = 2;
            this.tpVentas.Text = "Ventas";
            this.tpVentas.UseVisualStyleBackColor = true;
            this.tpVentas.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(200, 213);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(121, 20);
            this.txtMonto.TabIndex = 18;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(16, 213);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(31, 13);
            this.lblMonto.TabIndex = 17;
            this.lblMonto.Text = "Valor";
            // 
            // cmdCargar1
            // 
            this.cmdCargar1.Location = new System.Drawing.Point(246, 279);
            this.cmdCargar1.Name = "cmdCargar1";
            this.cmdCargar1.Size = new System.Drawing.Size(75, 23);
            this.cmdCargar1.TabIndex = 16;
            this.cmdCargar1.Text = "Cargar";
            this.cmdCargar1.UseVisualStyleBackColor = true;
            this.cmdCargar1.Click += new System.EventHandler(this.cmdCargar1_Click);
            // 
            // txtNumeroDeFactura
            // 
            this.txtNumeroDeFactura.Location = new System.Drawing.Point(200, 129);
            this.txtNumeroDeFactura.Name = "txtNumeroDeFactura";
            this.txtNumeroDeFactura.Size = new System.Drawing.Size(121, 20);
            this.txtNumeroDeFactura.TabIndex = 15;
            // 
            // lblTipoFactura
            // 
            this.lblTipoFactura.AutoSize = true;
            this.lblTipoFactura.Location = new System.Drawing.Point(16, 129);
            this.lblTipoFactura.Name = "lblTipoFactura";
            this.lblTipoFactura.Size = new System.Drawing.Size(95, 13);
            this.lblTipoFactura.TabIndex = 14;
            this.lblTipoFactura.Text = "Numero de factura";
            // 
            // txtFacturaVentass
            // 
            this.txtFacturaVentass.Location = new System.Drawing.Point(201, 96);
            this.txtFacturaVentass.Name = "txtFacturaVentass";
            this.txtFacturaVentass.Size = new System.Drawing.Size(121, 20);
            this.txtFacturaVentass.TabIndex = 13;
            // 
            // dtpVenta
            // 
            this.dtpVenta.Location = new System.Drawing.Point(122, 168);
            this.dtpVenta.Name = "dtpVenta";
            this.dtpVenta.Size = new System.Drawing.Size(200, 20);
            this.dtpVenta.TabIndex = 12;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(15, 168);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(96, 13);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "Fecha de la venta:";
            // 
            // lblTipoDeFactura
            // 
            this.lblTipoDeFactura.AutoSize = true;
            this.lblTipoDeFactura.Location = new System.Drawing.Point(16, 96);
            this.lblTipoDeFactura.Name = "lblTipoDeFactura";
            this.lblTipoDeFactura.Size = new System.Drawing.Size(79, 13);
            this.lblTipoDeFactura.TabIndex = 10;
            this.lblTipoDeFactura.Text = "Tipo de factura";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID del Cliente";
            // 
            // lstIDCliente
            // 
            this.lstIDCliente.FormattingEnabled = true;
            this.lstIDCliente.Location = new System.Drawing.Point(200, 59);
            this.lstIDCliente.Name = "lstIDCliente";
            this.lstIDCliente.Size = new System.Drawing.Size(121, 21);
            this.lstIDCliente.TabIndex = 8;
            // 
            // lstNombreVenta
            // 
            this.lstNombreVenta.FormattingEnabled = true;
            this.lstNombreVenta.Location = new System.Drawing.Point(200, 13);
            this.lstNombreVenta.Name = "lstNombreVenta";
            this.lstNombreVenta.Size = new System.Drawing.Size(121, 21);
            this.lstNombreVenta.TabIndex = 7;
            this.lstNombreVenta.SelectedIndexChanged += new System.EventHandler(this.lstNombreVenta_SelectedIndexChanged);
            // 
            // lblNombreVenta
            // 
            this.lblNombreVenta.AutoSize = true;
            this.lblNombreVenta.Location = new System.Drawing.Point(16, 22);
            this.lblNombreVenta.Name = "lblNombreVenta";
            this.lblNombreVenta.Size = new System.Drawing.Size(84, 13);
            this.lblNombreVenta.TabIndex = 6;
            this.lblNombreVenta.Text = "ID del Vendedor";
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Location = new System.Drawing.Point(159, 387);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(179, 23);
            this.cmdConsultar.TabIndex = 4;
            this.cmdConsultar.Text = "Para consultar presione aquí";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Location = new System.Drawing.Point(16, 387);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(75, 23);
            this.cmdCerrar.TabIndex = 5;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.UseVisualStyleBackColor = true;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // frmCarga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 432);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.tcCarga);
            this.Name = "frmCarga";
            this.Text = "Registrar";
            this.Load += new System.EventHandler(this.frmCarga_Load);
            this.tcCarga.ResumeLayout(false);
            this.tpCliente.ResumeLayout(false);
            this.tpCliente.PerformLayout();
            this.tpVendedor.ResumeLayout(false);
            this.tpVendedor.PerformLayout();
            this.tpVentas.ResumeLayout(false);
            this.tpVentas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcCarga;
        private System.Windows.Forms.TabPage tpCliente;
        private System.Windows.Forms.TabPage tpVendedor;
        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblNumeroCliente;
        private System.Windows.Forms.Label lblCargarCliente;
        private System.Windows.Forms.TabPage tpVentas;
        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtNumeroCliente;
        private System.Windows.Forms.Button txtCargarVendedor;
        private System.Windows.Forms.TextBox txtNombreVendedor;
        private System.Windows.Forms.TextBox txtNumeroVendedor;
        private System.Windows.Forms.Label lblNombreVendedor;
        private System.Windows.Forms.Label lblNumeroVendedor;
        private System.Windows.Forms.Label txtCargueVendedor;
        private System.Windows.Forms.TextBox txtComision;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.TextBox txtNumeroDeFactura;
        private System.Windows.Forms.Label lblTipoFactura;
        private System.Windows.Forms.TextBox txtFacturaVentass;
        private System.Windows.Forms.DateTimePicker dtpVenta;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTipoDeFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox lstIDCliente;
        private System.Windows.Forms.ComboBox lstNombreVenta;
        private System.Windows.Forms.Label lblNombreVenta;
        private System.Windows.Forms.Button cmdCargar1;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Button cmdCerrar;
    }
}

