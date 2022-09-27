namespace pryDemeterSP1EjPorResolver
{
    partial class frmConsultar
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
            this.dgvConsultaVentas = new System.Windows.Forms.DataGridView();
            this.columnaUno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaDos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaTres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaCuatro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaCinco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaSeis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdConsultarVenta = new System.Windows.Forms.Button();
            this.cmdCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultaVentas
            // 
            this.dgvConsultaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaUno,
            this.columnaDos,
            this.columnaTres,
            this.columnaCuatro,
            this.columnaCinco,
            this.columnaSeis});
            this.dgvConsultaVentas.Location = new System.Drawing.Point(11, 31);
            this.dgvConsultaVentas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvConsultaVentas.Name = "dgvConsultaVentas";
            this.dgvConsultaVentas.RowHeadersWidth = 51;
            this.dgvConsultaVentas.RowTemplate.Height = 24;
            this.dgvConsultaVentas.Size = new System.Drawing.Size(811, 242);
            this.dgvConsultaVentas.TabIndex = 1;
            // 
            // columnaUno
            // 
            this.columnaUno.HeaderText = "Factura Tipo";
            this.columnaUno.MinimumWidth = 6;
            this.columnaUno.Name = "columnaUno";
            this.columnaUno.ReadOnly = true;
            this.columnaUno.Width = 125;
            // 
            // columnaDos
            // 
            this.columnaDos.HeaderText = "Factura Numero";
            this.columnaDos.MinimumWidth = 6;
            this.columnaDos.Name = "columnaDos";
            this.columnaDos.ReadOnly = true;
            this.columnaDos.Width = 125;
            // 
            // columnaTres
            // 
            this.columnaTres.HeaderText = "Fecha";
            this.columnaTres.MinimumWidth = 6;
            this.columnaTres.Name = "columnaTres";
            this.columnaTres.ReadOnly = true;
            this.columnaTres.Width = 125;
            // 
            // columnaCuatro
            // 
            this.columnaCuatro.HeaderText = "Cliente Id";
            this.columnaCuatro.MinimumWidth = 6;
            this.columnaCuatro.Name = "columnaCuatro";
            this.columnaCuatro.ReadOnly = true;
            this.columnaCuatro.Width = 125;
            // 
            // columnaCinco
            // 
            this.columnaCinco.HeaderText = "VendedorId";
            this.columnaCinco.MinimumWidth = 6;
            this.columnaCinco.Name = "columnaCinco";
            this.columnaCinco.ReadOnly = true;
            this.columnaCinco.Width = 125;
            // 
            // columnaSeis
            // 
            this.columnaSeis.HeaderText = "Monto";
            this.columnaSeis.MinimumWidth = 6;
            this.columnaSeis.Name = "columnaSeis";
            this.columnaSeis.ReadOnly = true;
            this.columnaSeis.Width = 125;
            // 
            // cmdConsultarVenta
            // 
            this.cmdConsultarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdConsultarVenta.Location = new System.Drawing.Point(758, 306);
            this.cmdConsultarVenta.Margin = new System.Windows.Forms.Padding(2);
            this.cmdConsultarVenta.Name = "cmdConsultarVenta";
            this.cmdConsultarVenta.Size = new System.Drawing.Size(64, 27);
            this.cmdConsultarVenta.TabIndex = 2;
            this.cmdConsultarVenta.Text = "Listar";
            this.cmdConsultarVenta.UseVisualStyleBackColor = true;
            this.cmdConsultarVenta.Click += new System.EventHandler(this.cmdConsultarVenta_Click);
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Location = new System.Drawing.Point(11, 309);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(75, 23);
            this.cmdCerrar.TabIndex = 3;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.UseVisualStyleBackColor = true;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // frmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 359);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.cmdConsultarVenta);
            this.Controls.Add(this.dgvConsultaVentas);
            this.Name = "frmConsultar";
            this.Text = "Consultar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaUno;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaDos;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaTres;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCuatro;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCinco;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaSeis;
        private System.Windows.Forms.Button cmdConsultarVenta;
        private System.Windows.Forms.Button cmdCerrar;
    }
}