namespace ET
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnbaja = new System.Windows.Forms.Button();
            this.lblcon = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.dtpbaja = new System.Windows.Forms.DateTimePicker();
            this.dtpalta = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.cbfamilia = new System.Windows.Forms.ComboBox();
            this.cbclase = new System.Windows.Forms.ComboBox();
            this.cbdepartamento = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtarticulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chbdes = new System.Windows.Forms.CheckBox();
            this.txtsku = new System.Windows.Forms.TextBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnalta = new System.Windows.Forms.Button();
            this.btncambiar = new System.Windows.Forms.Button();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnbaja
            // 
            this.btnbaja.Enabled = false;
            this.btnbaja.Location = new System.Drawing.Point(225, 354);
            this.btnbaja.Name = "btnbaja";
            this.btnbaja.Size = new System.Drawing.Size(75, 23);
            this.btnbaja.TabIndex = 102;
            this.btnbaja.Text = "Baja";
            this.btnbaja.UseVisualStyleBackColor = true;
            this.btnbaja.Visible = false;
            this.btnbaja.Click += new System.EventHandler(this.btnbaja_Click);
            // 
            // lblcon
            // 
            this.lblcon.AutoSize = true;
            this.lblcon.Location = new System.Drawing.Point(222, 323);
            this.lblcon.Name = "lblcon";
            this.lblcon.Size = new System.Drawing.Size(75, 13);
            this.lblcon.TabIndex = 101;
            this.lblcon.Text = "Confirmar Baja";
            this.lblcon.Visible = false;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(145, 397);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 100;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // dtpbaja
            // 
            this.dtpbaja.CustomFormat = "DD/MM/YY";
            this.dtpbaja.Enabled = false;
            this.dtpbaja.Location = new System.Drawing.Point(265, 230);
            this.dtpbaja.Name = "dtpbaja";
            this.dtpbaja.Size = new System.Drawing.Size(101, 20);
            this.dtpbaja.TabIndex = 99;
            // 
            // dtpalta
            // 
            this.dtpalta.CustomFormat = "DD/MM/YY";
            this.dtpalta.Enabled = false;
            this.dtpalta.Location = new System.Drawing.Point(101, 230);
            this.dtpalta.Name = "dtpalta";
            this.dtpalta.Size = new System.Drawing.Size(101, 20);
            this.dtpalta.TabIndex = 98;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(208, 230);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 97;
            this.label11.Text = "Fecha Baja:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 96;
            this.label10.Text = "Fecha Alta:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(208, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 95;
            this.label9.Text = "Cantidad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 94;
            this.label8.Text = "Stock:";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Enabled = false;
            this.txtcantidad.Location = new System.Drawing.Point(265, 199);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(101, 20);
            this.txtcantidad.TabIndex = 93;
            this.txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidad_KeyPress);
            // 
            // txtstock
            // 
            this.txtstock.Enabled = false;
            this.txtstock.Location = new System.Drawing.Point(101, 199);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(101, 20);
            this.txtstock.TabIndex = 92;
            // 
            // cbfamilia
            // 
            this.cbfamilia.Enabled = false;
            this.cbfamilia.FormattingEnabled = true;
            this.cbfamilia.Location = new System.Drawing.Point(101, 172);
            this.cbfamilia.Name = "cbfamilia";
            this.cbfamilia.Size = new System.Drawing.Size(265, 21);
            this.cbfamilia.TabIndex = 91;
            // 
            // cbclase
            // 
            this.cbclase.Enabled = false;
            this.cbclase.FormattingEnabled = true;
            this.cbclase.Location = new System.Drawing.Point(101, 145);
            this.cbclase.Name = "cbclase";
            this.cbclase.Size = new System.Drawing.Size(265, 21);
            this.cbclase.TabIndex = 90;
            // 
            // cbdepartamento
            // 
            this.cbdepartamento.Enabled = false;
            this.cbdepartamento.FormattingEnabled = true;
            this.cbdepartamento.Location = new System.Drawing.Point(101, 118);
            this.cbdepartamento.Name = "cbdepartamento";
            this.cbdepartamento.Size = new System.Drawing.Size(265, 21);
            this.cbdepartamento.TabIndex = 89;
            this.cbdepartamento.SelectedIndexChanged += new System.EventHandler(this.cbdepartamento_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 88;
            this.label7.Text = "Familia:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 87;
            this.label6.Text = "Clase:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 86;
            this.label5.Text = "Departamento:";
            // 
            // txtmodelo
            // 
            this.txtmodelo.Enabled = false;
            this.txtmodelo.Location = new System.Drawing.Point(101, 89);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(265, 20);
            this.txtmodelo.TabIndex = 85;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 84;
            this.label4.Text = "Modelo:";
            // 
            // txtmarca
            // 
            this.txtmarca.Enabled = false;
            this.txtmarca.Location = new System.Drawing.Point(101, 63);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(265, 20);
            this.txtmarca.TabIndex = 83;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 82;
            this.label3.Text = "Marca:";
            // 
            // txtarticulo
            // 
            this.txtarticulo.Enabled = false;
            this.txtarticulo.Location = new System.Drawing.Point(101, 37);
            this.txtarticulo.Name = "txtarticulo";
            this.txtarticulo.Size = new System.Drawing.Size(265, 20);
            this.txtarticulo.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "Articulo:";
            // 
            // chbdes
            // 
            this.chbdes.AutoSize = true;
            this.chbdes.CausesValidation = false;
            this.chbdes.Checked = true;
            this.chbdes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbdes.Location = new System.Drawing.Point(268, 17);
            this.chbdes.Name = "chbdes";
            this.chbdes.Size = new System.Drawing.Size(98, 17);
            this.chbdes.TabIndex = 79;
            this.chbdes.Text = "Descontinuado";
            this.chbdes.UseVisualStyleBackColor = true;
            // 
            // txtsku
            // 
            this.txtsku.Location = new System.Drawing.Point(101, 11);
            this.txtsku.Name = "txtsku";
            this.txtsku.Size = new System.Drawing.Size(101, 20);
            this.txtsku.TabIndex = 78;
            this.txtsku.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsku_KeyPress);
            // 
            // btneliminar
            // 
            this.btneliminar.Enabled = false;
            this.btneliminar.Location = new System.Drawing.Point(225, 297);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 77;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Visible = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 76;
            this.label1.Text = "sku:";
            // 
            // btnalta
            // 
            this.btnalta.Enabled = false;
            this.btnalta.Location = new System.Drawing.Point(30, 297);
            this.btnalta.Name = "btnalta";
            this.btnalta.Size = new System.Drawing.Size(75, 23);
            this.btnalta.TabIndex = 103;
            this.btnalta.Text = "Dar Alta";
            this.btnalta.UseVisualStyleBackColor = true;
            this.btnalta.Visible = false;
            this.btnalta.Click += new System.EventHandler(this.btnalta_Click);
            // 
            // btncambiar
            // 
            this.btncambiar.Enabled = false;
            this.btncambiar.Location = new System.Drawing.Point(115, 297);
            this.btncambiar.Name = "btncambiar";
            this.btncambiar.Size = new System.Drawing.Size(75, 23);
            this.btncambiar.TabIndex = 104;
            this.btncambiar.Text = "Cambio";
            this.btncambiar.UseVisualStyleBackColor = true;
            this.btncambiar.Visible = false;
            this.btncambiar.Click += new System.EventHandler(this.btncambiar_Click);
            // 
            // btnconsultar
            // 
            this.btnconsultar.Enabled = false;
            this.btnconsultar.Location = new System.Drawing.Point(30, 341);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(160, 36);
            this.btnconsultar.TabIndex = 105;
            this.btnconsultar.Text = "Consultar DEP/CLS/FAM";
            this.btnconsultar.UseVisualStyleBackColor = true;
            this.btnconsultar.Visible = false;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 423);
            this.Controls.Add(this.btnconsultar);
            this.Controls.Add(this.btncambiar);
            this.Controls.Add(this.btnalta);
            this.Controls.Add(this.btnbaja);
            this.Controls.Add(this.lblcon);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.dtpbaja);
            this.Controls.Add(this.dtpalta);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.txtstock);
            this.Controls.Add(this.cbfamilia);
            this.Controls.Add(this.cbclase);
            this.Controls.Add(this.cbdepartamento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtmodelo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtarticulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chbdes);
            this.Controls.Add(this.txtsku);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ABCC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbaja;
        private System.Windows.Forms.Label lblcon;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.DateTimePicker dtpbaja;
        private System.Windows.Forms.DateTimePicker dtpalta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.ComboBox cbfamilia;
        private System.Windows.Forms.ComboBox cbclase;
        private System.Windows.Forms.ComboBox cbdepartamento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtarticulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chbdes;
        private System.Windows.Forms.TextBox txtsku;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnalta;
        private System.Windows.Forms.Button btncambiar;
        private System.Windows.Forms.Button btnconsultar;


    }
}

