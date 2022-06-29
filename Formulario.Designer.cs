﻿namespace TablaAmortizacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.saldoFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblResultado);
            this.groupBox1.Controls.Add(this.lblTotalCuotas);
            this.groupBox1.Controls.Add(this.textPlazos);
            this.groupBox1.Controls.Add(this.lblPlazos);
            this.groupBox1.Controls.Add(this.textInteres);
            this.groupBox1.Controls.Add(this.lblInteres);
            this.groupBox1.Controls.Add(this.textMonto);
            this.groupBox1.Controls.Add(this.lblMonto);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Crédito";
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
            this.textPlazos.Location = new System.Drawing.Point(95, 86);
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
            this.textInteres.Location = new System.Drawing.Point(95, 57);
            this.textInteres.Name = "textInteres";
            this.textInteres.Size = new System.Drawing.Size(100, 23);
            this.textInteres.TabIndex = 3;
            // 
            // lblInteres
            // 
            this.lblInteres.AutoSize = true;
            this.lblInteres.Location = new System.Drawing.Point(6, 60);
            this.lblInteres.Name = "lblInteres";
            this.lblInteres.Size = new System.Drawing.Size(83, 15);
            this.lblInteres.TabIndex = 2;
            this.lblInteres.Text = "Tasa de Interés";
            // 
            // textMonto
            // 
            this.textMonto.Location = new System.Drawing.Point(95, 28);
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
            this.btnCalcularVar.Location = new System.Drawing.Point(442, 77);
            this.btnCalcularVar.Name = "btnCalcularVar";
            this.btnCalcularVar.Size = new System.Drawing.Size(126, 39);
            this.btnCalcularVar.TabIndex = 6;
            this.btnCalcularVar.Text = "Calcular Cuota Variable";
            this.btnCalcularVar.UseVisualStyleBackColor = true;
            this.btnCalcularVar.Click += new System.EventHandler(this.btnCalcularVar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(442, 31);
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
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.periodo,
            this.saldoInicial,
            this.valorCuota,
            this.intereses,
            this.abonoCap,
            this.saldoFinal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(16, 138);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(552, 501);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 1;
            // 
            // periodo
            // 
            this.periodo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.periodo.HeaderText = "Periodo";
            this.periodo.MaxInputLength = 999;
            this.periodo.Name = "periodo";
            this.periodo.Width = 73;
            // 
            // saldoInicial
            // 
            this.saldoInicial.HeaderText = "Saldo Inicial";
            this.saldoInicial.Name = "saldoInicial";
            this.saldoInicial.Width = 88;
            // 
            // valorCuota
            // 
            this.valorCuota.HeaderText = "Cuota";
            this.valorCuota.Name = "valorCuota";
            this.valorCuota.Width = 64;
            // 
            // intereses
            // 
            this.intereses.HeaderText = "Intereses";
            this.intereses.Name = "intereses";
            this.intereses.Width = 78;
            // 
            // abonoCap
            // 
            this.abonoCap.HeaderText = "Abono a Capital";
            this.abonoCap.Name = "abonoCap";
            this.abonoCap.Width = 107;
            // 
            // saldoFinal
            // 
            this.saldoFinal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.saldoFinal.HeaderText = "Saldo Final";
            this.saldoFinal.Name = "saldoFinal";
            this.saldoFinal.Width = 82;
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 663);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnCalcularVar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Formulario";
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridViewTextBoxColumn periodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorCuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn intereses;
        private System.Windows.Forms.DataGridViewTextBoxColumn abonoCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn saldoFinal;
    }
}
