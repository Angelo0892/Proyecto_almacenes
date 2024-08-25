namespace Proyecto_almacen
{
    partial class GestionUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textoNombre = new System.Windows.Forms.TextBox();
            this.textoApellido = new System.Windows.Forms.TextBox();
            this.textoCelular = new System.Windows.Forms.TextBox();
            this.botonCrear = new System.Windows.Forms.Button();
            this.botonModificar = new System.Windows.Forms.Button();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.textoEstado = new System.Windows.Forms.ComboBox();
            this.textoRol = new System.Windows.Forms.ComboBox();
            this.datosUsuarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datosUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Celular:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rol:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Estado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Usuarios";
            // 
            // textoNombre
            // 
            this.textoNombre.Location = new System.Drawing.Point(192, 50);
            this.textoNombre.Name = "textoNombre";
            this.textoNombre.Size = new System.Drawing.Size(120, 22);
            this.textoNombre.TabIndex = 6;
            // 
            // textoApellido
            // 
            this.textoApellido.Location = new System.Drawing.Point(192, 89);
            this.textoApellido.Name = "textoApellido";
            this.textoApellido.Size = new System.Drawing.Size(120, 22);
            this.textoApellido.TabIndex = 7;
            // 
            // textoCelular
            // 
            this.textoCelular.Location = new System.Drawing.Point(192, 130);
            this.textoCelular.Name = "textoCelular";
            this.textoCelular.Size = new System.Drawing.Size(120, 22);
            this.textoCelular.TabIndex = 8;
            // 
            // botonCrear
            // 
            this.botonCrear.Location = new System.Drawing.Point(757, 274);
            this.botonCrear.Name = "botonCrear";
            this.botonCrear.Size = new System.Drawing.Size(75, 23);
            this.botonCrear.TabIndex = 11;
            this.botonCrear.Text = "Crear";
            this.botonCrear.UseVisualStyleBackColor = true;
            this.botonCrear.Click += new System.EventHandler(this.AccionCrear);
            // 
            // botonModificar
            // 
            this.botonModificar.Location = new System.Drawing.Point(666, 274);
            this.botonModificar.Name = "botonModificar";
            this.botonModificar.Size = new System.Drawing.Size(75, 23);
            this.botonModificar.TabIndex = 12;
            this.botonModificar.Text = "Modificar";
            this.botonModificar.UseVisualStyleBackColor = true;
            this.botonModificar.Click += new System.EventHandler(this.AccionModificar);
            // 
            // botonEliminar
            // 
            this.botonEliminar.Location = new System.Drawing.Point(571, 274);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(75, 23);
            this.botonEliminar.TabIndex = 13;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.AccionEliminar);
            // 
            // textoEstado
            // 
            this.textoEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textoEstado.FormattingEnabled = true;
            this.textoEstado.Items.AddRange(new object[] {
            "Abilitado",
            "Baja"});
            this.textoEstado.Location = new System.Drawing.Point(192, 212);
            this.textoEstado.Name = "textoEstado";
            this.textoEstado.Size = new System.Drawing.Size(120, 24);
            this.textoEstado.TabIndex = 15;
            // 
            // textoRol
            // 
            this.textoRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textoRol.FormattingEnabled = true;
            this.textoRol.Items.AddRange(new object[] {
            "Administrador",
            "Empleado"});
            this.textoRol.Location = new System.Drawing.Point(192, 170);
            this.textoRol.Name = "textoRol";
            this.textoRol.Size = new System.Drawing.Size(120, 24);
            this.textoRol.TabIndex = 16;
            // 
            // datosUsuarios
            // 
            this.datosUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosUsuarios.Location = new System.Drawing.Point(60, 335);
            this.datosUsuarios.Name = "datosUsuarios";
            this.datosUsuarios.ReadOnly = true;
            this.datosUsuarios.RowHeadersWidth = 51;
            this.datosUsuarios.RowTemplate.Height = 24;
            this.datosUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datosUsuarios.Size = new System.Drawing.Size(772, 271);
            this.datosUsuarios.TabIndex = 17;
            this.datosUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ObtenerDatosFila);
            // 
            // GestionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 649);
            this.Controls.Add(this.datosUsuarios);
            this.Controls.Add(this.textoRol);
            this.Controls.Add(this.textoEstado);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.botonModificar);
            this.Controls.Add(this.botonCrear);
            this.Controls.Add(this.textoCelular);
            this.Controls.Add(this.textoApellido);
            this.Controls.Add(this.textoNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GestionUsuario";
            this.Text = "Gestión de usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.datosUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textoNombre;
        private System.Windows.Forms.TextBox textoApellido;
        private System.Windows.Forms.TextBox textoCelular;
        private System.Windows.Forms.Button botonCrear;
        private System.Windows.Forms.Button botonModificar;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.ComboBox textoEstado;
        private System.Windows.Forms.ComboBox textoRol;
        private System.Windows.Forms.DataGridView datosUsuarios;
    }
}

