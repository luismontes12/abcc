namespace ET
{
    partial class Consultar
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
            this.btnsalir = new System.Windows.Forms.Button();
            this.dgvdep = new System.Windows.Forms.DataGridView();
            this.dgvclas = new System.Windows.Forms.DataGridView();
            this.dgvfam = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfam)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(744, 567);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 125;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // dgvdep
            // 
            this.dgvdep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdep.Location = new System.Drawing.Point(36, 34);
            this.dgvdep.Name = "dgvdep";
            this.dgvdep.Size = new System.Drawing.Size(243, 514);
            this.dgvdep.TabIndex = 126;
            // 
            // dgvclas
            // 
            this.dgvclas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvclas.Location = new System.Drawing.Point(302, 34);
            this.dgvclas.Name = "dgvclas";
            this.dgvclas.Size = new System.Drawing.Size(243, 514);
            this.dgvclas.TabIndex = 127;
            // 
            // dgvfam
            // 
            this.dgvfam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfam.Location = new System.Drawing.Point(565, 34);
            this.dgvfam.Name = "dgvfam";
            this.dgvfam.Size = new System.Drawing.Size(243, 514);
            this.dgvfam.TabIndex = 128;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 129;
            this.label12.Text = "Departamento";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(299, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 130;
            this.label13.Text = "Clase";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(571, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 13);
            this.label14.TabIndex = 131;
            this.label14.Text = "Familia";
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 600);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgvfam);
            this.Controls.Add(this.dgvclas);
            this.Controls.Add(this.dgvdep);
            this.Controls.Add(this.btnsalir);
            this.Name = "Consultar";
            this.Text = "Consultar";
            this.Load += new System.EventHandler(this.Consultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.DataGridView dgvdep;
        private System.Windows.Forms.DataGridView dgvclas;
        private System.Windows.Forms.DataGridView dgvfam;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}