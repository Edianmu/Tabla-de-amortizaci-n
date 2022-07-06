namespace TablaAmortizacion
{
    partial class Formulario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textAval = new System.Windows.Forms.TextBox();
            this.lblAval = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblTotalCuotas = new System.Windows.Forms.Label();
            this.textPlazos = new System.Windows.Forms.TextBox();
            this.lblPlazos = new System.Windows.Forms.Label();
            this.textInteres = new System.Windows.Forms.TextBox();
            this.lblInteres = new System.Windows.Forms.Label();
            this.textMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.btnCalcularVar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorCuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intereses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abonoCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saldoFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsmMenu = new System.Windows.Forms.ToolStrip();
            this.tslRegistrar = new System.Windows.Forms.ToolStripLabel();
            this.tslConsultar = new System.Windows.Forms.ToolStripLabel();
            this.tslEliminar = new System.Windows.Forms.ToolStripLabel();
            this.tslSalir = new System.Windows.Forms.ToolStripLabel();
            this.tslAcercade = new System.Windows.Forms.ToolStripLabel();
            this.gbDatosCliente = new System.Windows.Forms.GroupBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.textIdentificacion = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.erpError = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tsmMenu.SuspendLayout();
            this.gbDatosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.textAval);
            this.groupBox1.Controls.Add(this.lblAval);
            this.groupBox1.Controls.Add(this.lblResultado);
            this.groupBox1.Controls.Add(this.lblTotalCuotas);
            this.groupBox1.Controls.Add(this.textPlazos);
            this.groupBox1.Controls.Add(this.lblPlazos);
            this.groupBox1.Controls.Add(this.textInteres);
            this.groupBox1.Controls.Add(this.lblInteres);
            this.groupBox1.Controls.Add(this.textMonto);
            this.groupBox1.Controls.Add(this.lblMonto);
            this.groupBox1.Location = new System.Drawing.Point(12, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Crédito";
            // 
            // textAval
            // 
            this.textAval.Location = new System.Drawing.Point(291, 28);
            this.textAval.Name = "textAval";
            this.textAval.Size = new System.Drawing.Size(100, 23);
            this.textAval.TabIndex = 9;
            // 
            // lblAval
            // 
            this.lblAval.AutoSize = true;
            this.lblAval.Location = new System.Drawing.Point(210, 31);
            this.lblAval.Name = "lblAval";
            this.lblAval.Size = new System.Drawing.Size(43, 15);
            this.lblAval.TabIndex = 8;
            this.lblAval.Text = "Aval %";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(291, 60);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(13, 15);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "0";
            // 
            // lblTotalCuotas
            // 
            this.lblTotalCuotas.AutoSize = true;
            this.lblTotalCuotas.Location = new System.Drawing.Point(210, 60);
            this.lblTotalCuotas.Name = "lblTotalCuotas";
            this.lblTotalCuotas.Size = new System.Drawing.Size(72, 15);
            this.lblTotalCuotas.TabIndex = 6;
            this.lblTotalCuotas.Text = "Total Cuotas";
            // 
            // textPlazos
            // 
            this.textPlazos.Location = new System.Drawing.Point(104, 86);
            this.textPlazos.Name = "textPlazos";
            this.textPlazos.Size = new System.Drawing.Size(100, 23);
            this.textPlazos.TabIndex = 5;
            // 
            // lblPlazos
            // 
            this.lblPlazos.AutoSize = true;
            this.lblPlazos.Location = new System.Drawing.Point(6, 89);
            this.lblPlazos.Name = "lblPlazos";
            this.lblPlazos.Size = new System.Drawing.Size(40, 15);
            this.lblPlazos.TabIndex = 4;
            this.lblPlazos.Text = "Plazos";
            // 
            // textInteres
            // 
            this.textInteres.Location = new System.Drawing.Point(104, 57);
            this.textInteres.Name = "textInteres";
            this.textInteres.Size = new System.Drawing.Size(100, 23);
            this.textInteres.TabIndex = 3;
            // 
            // lblInteres
            // 
            this.lblInteres.AutoSize = true;
            this.lblInteres.Location = new System.Drawing.Point(6, 60);
            this.lblInteres.Name = "lblInteres";
            this.lblInteres.Size = new System.Drawing.Size(96, 15);
            this.lblInteres.TabIndex = 2;
            this.lblInteres.Text = "Tasa de Interés %";
            // 
            // textMonto
            // 
            this.textMonto.Location = new System.Drawing.Point(104, 28);
            this.textMonto.Name = "textMonto";
            this.textMonto.Size = new System.Drawing.Size(100, 23);
            this.textMonto.TabIndex = 1;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(6, 31);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(43, 15);
            this.lblMonto.TabIndex = 0;
            this.lblMonto.Text = "Monto";
            // 
            // btnCalcularVar
            // 
            this.btnCalcularVar.Location = new System.Drawing.Point(460, 236);
            this.btnCalcularVar.Name = "btnCalcularVar";
            this.btnCalcularVar.Size = new System.Drawing.Size(126, 39);
            this.btnCalcularVar.TabIndex = 6;
            this.btnCalcularVar.Text = "Calcular Cuota Variable";
            this.btnCalcularVar.UseVisualStyleBackColor = true;
            this.btnCalcularVar.Click += new System.EventHandler(this.btnCalcularVar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(460, 190);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(126, 40);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular Cuota Fija";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.periodo,
            this.saldoInicial,
            this.valorCuota,
            this.intereses,
            this.abonoCap,
            this.aval,
            this.saldoFinal});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(12, 292);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(654, 281);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 1;
            // 
            // periodo
            // 
            this.periodo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.periodo.HeaderText = "Periodo";
            this.periodo.MaxInputLength = 999;
            this.periodo.Name = "periodo";
            this.periodo.ReadOnly = true;
            this.periodo.Width = 73;
            // 
            // saldoInicial
            // 
            this.saldoInicial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.saldoInicial.HeaderText = "Saldo Inicial";
            this.saldoInicial.Name = "saldoInicial";
            this.saldoInicial.ReadOnly = true;
            this.saldoInicial.Width = 88;
            // 
            // valorCuota
            // 
            this.valorCuota.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.valorCuota.HeaderText = "Cuota";
            this.valorCuota.Name = "valorCuota";
            this.valorCuota.ReadOnly = true;
            this.valorCuota.Width = 64;
            // 
            // intereses
            // 
            this.intereses.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.intereses.HeaderText = "Interes por periodo";
            this.intereses.Name = "intereses";
            this.intereses.ReadOnly = true;
            this.intereses.Width = 121;
            // 
            // abonoCap
            // 
            this.abonoCap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.abonoCap.HeaderText = "Abono a Capital";
            this.abonoCap.Name = "abonoCap";
            this.abonoCap.ReadOnly = true;
            this.abonoCap.Width = 107;
            // 
            // aval
            // 
            this.aval.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.aval.HeaderText = "Aval";
            this.aval.Name = "aval";
            this.aval.ReadOnly = true;
            this.aval.Width = 55;
            // 
            // saldoFinal
            // 
            this.saldoFinal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.saldoFinal.HeaderText = "Saldo Final";
            this.saldoFinal.Name = "saldoFinal";
            this.saldoFinal.ReadOnly = true;
            this.saldoFinal.Width = 82;
            // 
            // tsmMenu
            // 
            this.tsmMenu.Font = new System.Drawing.Font("Microsoft JhengHei Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tsmMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslRegistrar,
            this.tslConsultar,
            this.tslEliminar,
            this.tslSalir,
            this.tslAcercade});
            this.tsmMenu.Location = new System.Drawing.Point(0, 0);
            this.tsmMenu.Name = "tsmMenu";
            this.tsmMenu.Size = new System.Drawing.Size(676, 25);
            this.tsmMenu.TabIndex = 7;
            this.tsmMenu.Text = "toolStrip1";
            // 
            // tslRegistrar
            // 
            this.tslRegistrar.Name = "tslRegistrar";
            this.tslRegistrar.Size = new System.Drawing.Size(63, 22);
            this.tslRegistrar.Text = "Registrar";
            this.tslRegistrar.Click += new System.EventHandler(this.tslRegistrar_Click);
            // 
            // tslConsultar
            // 
            this.tslConsultar.Name = "tslConsultar";
            this.tslConsultar.Size = new System.Drawing.Size(67, 22);
            this.tslConsultar.Text = "Consultar";
            // 
            // tslEliminar
            // 
            this.tslEliminar.Name = "tslEliminar";
            this.tslEliminar.Size = new System.Drawing.Size(58, 22);
            this.tslEliminar.Text = "Eliminar";
            // 
            // tslSalir
            // 
            this.tslSalir.Name = "tslSalir";
            this.tslSalir.Size = new System.Drawing.Size(34, 22);
            this.tslSalir.Text = "Salir";
            // 
            // tslAcercade
            // 
            this.tslAcercade.Name = "tslAcercade";
            this.tslAcercade.Size = new System.Drawing.Size(83, 22);
            this.tslAcercade.Text = "Acerca de...";
            // 
            // gbDatosCliente
            // 
            this.gbDatosCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbDatosCliente.Controls.Add(this.dtpFecha);
            this.gbDatosCliente.Controls.Add(this.textIdentificacion);
            this.gbDatosCliente.Controls.Add(this.textNombre);
            this.gbDatosCliente.Controls.Add(this.lblFechaNacimiento);
            this.gbDatosCliente.Controls.Add(this.lblIdentificacion);
            this.gbDatosCliente.Controls.Add(this.lblNombre);
            this.gbDatosCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbDatosCliente.Location = new System.Drawing.Point(12, 37);
            this.gbDatosCliente.Name = "gbDatosCliente";
            this.gbDatosCliente.Size = new System.Drawing.Size(424, 123);
            this.gbDatosCliente.TabIndex = 8;
            this.gbDatosCliente.TabStop = false;
            this.gbDatosCliente.Text = "Datos Cliente";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(155, 82);
            this.dtpFecha.MaxDate = new System.DateTime(2016, 12, 31, 0, 0, 0, 0);
            this.dtpFecha.MinDate = new System.DateTime(1922, 7, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(79, 23);
            this.dtpFecha.TabIndex = 6;
            this.dtpFecha.Value = new System.DateTime(2000, 1, 31, 0, 0, 0, 0);
            // 
            // textIdentificacion
            // 
            this.textIdentificacion.Location = new System.Drawing.Point(155, 53);
            this.textIdentificacion.Name = "textIdentificacion";
            this.textIdentificacion.Size = new System.Drawing.Size(250, 23);
            this.textIdentificacion.TabIndex = 4;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(155, 24);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(250, 23);
            this.textNombre.TabIndex = 3;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(7, 88);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(119, 15);
            this.lblFechaNacimiento.TabIndex = 2;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Location = new System.Drawing.Point(7, 56);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(142, 15);
            this.lblIdentificacion.TabIndex = 1;
            this.lblIdentificacion.Text = "Número de Identificación";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(7, 27);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(107, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre Completo";
            // 
            // erpError
            // 
            this.erpError.ContainerControl = this;
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(676, 588);
            this.Controls.Add(this.gbDatosCliente);
            this.Controls.Add(this.tsmMenu);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnCalcularVar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Formulario";
            this.Text = "Tabla de Amortización";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tsmMenu.ResumeLayout(false);
            this.tsmMenu.PerformLayout();
            this.gbDatosCliente.ResumeLayout(false);
            this.gbDatosCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textPlazos;
        private System.Windows.Forms.Label lblPlazos;
        private System.Windows.Forms.TextBox textInteres;
        private System.Windows.Forms.Label lblInteres;
        private System.Windows.Forms.TextBox textMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnCalcularVar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblTotalCuotas;
        private System.Windows.Forms.TextBox textAval;
        private System.Windows.Forms.Label lblAval;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn intereses;
        private System.Windows.Forms.DataGridViewTextBoxColumn abonoCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn aval;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoFinal;
        private System.Windows.Forms.ToolStrip tsmMenu;
        private System.Windows.Forms.ToolStripLabel tslRegistrar;
        private System.Windows.Forms.ToolStripLabel tslConsultar;
        private System.Windows.Forms.ToolStripLabel tslEliminar;
        private System.Windows.Forms.ToolStripLabel tslSalir;
        private System.Windows.Forms.ToolStripLabel tslAcercade;
        private System.Windows.Forms.GroupBox gbDatosCliente;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox textIdentificacion;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ErrorProvider erpError;
    }
}
