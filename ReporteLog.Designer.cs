﻿namespace Proyecto_almacen
{
    partial class ReporteLog
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
            this.textoTabla = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textoFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textoIdUsuario = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.reportesLog = new System.Windows.Forms.DataGridView();
            this.label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.datoNombreU = new System.Windows.Forms.TextBox();
            this.datoHora = new System.Windows.Forms.TextBox();
            this.datoOperacion = new System.Windows.Forms.TextBox();
            this.datoFecha = new System.Windows.Forms.TextBox();
            this.datoTabla = new System.Windows.Forms.TextBox();
            this.datoOperacionLog = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.reportesLog)).BeginInit();
            this.SuspendLayout();
            // 
            // textoTabla
            // 
            this.textoTabla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textoTabla.FormattingEnabled = true;
            this.textoTabla.Items.AddRange(new object[] {
            "Usuario"});
            this.textoTabla.Location = new System.Drawing.Point(498, 65);
            this.textoTabla.Name = "textoTabla";
            this.textoTabla.Size = new System.Drawing.Size(185, 24);
            this.textoTabla.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tabla:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(549, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reporte Logs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(762, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha:";
            // 
            // textoFecha
            // 
            this.textoFecha.Location = new System.Drawing.Point(848, 65);
            this.textoFecha.Name = "textoFecha";
            this.textoFecha.Size = new System.Drawing.Size(245, 22);
            this.textoFecha.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Id de Usuario:";
            // 
            // textoIdUsuario
            // 
            this.textoIdUsuario.Location = new System.Drawing.Point(175, 65);
            this.textoIdUsuario.Name = "textoIdUsuario";
            this.textoIdUsuario.Size = new System.Drawing.Size(193, 22);
            this.textoIdUsuario.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1018, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AccionBuscar);
            // 
            // reportesLog
            // 
            this.reportesLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportesLog.Location = new System.Drawing.Point(49, 180);
            this.reportesLog.Name = "reportesLog";
            this.reportesLog.ReadOnly = true;
            this.reportesLog.RowHeadersWidth = 51;
            this.reportesLog.RowTemplate.Height = 24;
            this.reportesLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reportesLog.Size = new System.Drawing.Size(1044, 170);
            this.reportesLog.TabIndex = 8;
            this.reportesLog.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ObtenerDatosFila);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(555, 398);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(48, 16);
            this.label.TabIndex = 9;
            this.label.Text = "Fecha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 455);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hora:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(555, 455);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tabla:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 508);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Operacion:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 561);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Operacion Log:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 398);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Nombre de Usuario:";
            // 
            // datoNombreU
            // 
            this.datoNombreU.Location = new System.Drawing.Point(246, 395);
            this.datoNombreU.Name = "datoNombreU";
            this.datoNombreU.ReadOnly = true;
            this.datoNombreU.Size = new System.Drawing.Size(193, 22);
            this.datoNombreU.TabIndex = 15;
            // 
            // datoHora
            // 
            this.datoHora.Location = new System.Drawing.Point(246, 449);
            this.datoHora.Name = "datoHora";
            this.datoHora.ReadOnly = true;
            this.datoHora.Size = new System.Drawing.Size(193, 22);
            this.datoHora.TabIndex = 16;
            // 
            // datoOperacion
            // 
            this.datoOperacion.Location = new System.Drawing.Point(246, 505);
            this.datoOperacion.Name = "datoOperacion";
            this.datoOperacion.ReadOnly = true;
            this.datoOperacion.Size = new System.Drawing.Size(193, 22);
            this.datoOperacion.TabIndex = 17;
            // 
            // datoFecha
            // 
            this.datoFecha.Location = new System.Drawing.Point(705, 395);
            this.datoFecha.Name = "datoFecha";
            this.datoFecha.ReadOnly = true;
            this.datoFecha.Size = new System.Drawing.Size(193, 22);
            this.datoFecha.TabIndex = 18;
            // 
            // datoTabla
            // 
            this.datoTabla.Location = new System.Drawing.Point(705, 449);
            this.datoTabla.Name = "datoTabla";
            this.datoTabla.ReadOnly = true;
            this.datoTabla.Size = new System.Drawing.Size(193, 22);
            this.datoTabla.TabIndex = 19;
            // 
            // datoOperacionLog
            // 
            this.datoOperacionLog.Location = new System.Drawing.Point(246, 561);
            this.datoOperacionLog.Name = "datoOperacionLog";
            this.datoOperacionLog.ReadOnly = true;
            this.datoOperacionLog.Size = new System.Drawing.Size(847, 22);
            this.datoOperacionLog.TabIndex = 20;
            // 
            // ReporteLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 629);
            this.Controls.Add(this.datoOperacionLog);
            this.Controls.Add(this.datoTabla);
            this.Controls.Add(this.datoFecha);
            this.Controls.Add(this.datoOperacion);
            this.Controls.Add(this.datoHora);
            this.Controls.Add(this.datoNombreU);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label);
            this.Controls.Add(this.reportesLog);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textoIdUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textoFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textoTabla);
            this.Name = "ReporteLog";
            this.Text = "ReporteLog";
            ((System.ComponentModel.ISupportInitialize)(this.reportesLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox textoTabla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker textoFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textoIdUsuario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView reportesLog;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox datoNombreU;
        private System.Windows.Forms.TextBox datoHora;
        private System.Windows.Forms.TextBox datoOperacion;
        private System.Windows.Forms.TextBox datoFecha;
        private System.Windows.Forms.TextBox datoTabla;
        private System.Windows.Forms.TextBox datoOperacionLog;
    }
}