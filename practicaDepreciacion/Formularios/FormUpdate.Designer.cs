namespace practicaDepreciacion
{
    partial class FormUpdate
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
            this.Nombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.txtVResidual = new System.Windows.Forms.TextBox();
            this.txtVutil = new System.Windows.Forms.TextBox();
            this.btnActu = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(32, 67);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 6;
            this.Nombre.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valor residual";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Vida util";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(108, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(108, 105);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 20);
            this.txtvalor.TabIndex = 11;
            // 
            // txtVResidual
            // 
            this.txtVResidual.Location = new System.Drawing.Point(108, 137);
            this.txtVResidual.Name = "txtVResidual";
            this.txtVResidual.Size = new System.Drawing.Size(100, 20);
            this.txtVResidual.TabIndex = 12;
            // 
            // txtVutil
            // 
            this.txtVutil.Location = new System.Drawing.Point(108, 172);
            this.txtVutil.Name = "txtVutil";
            this.txtVutil.Size = new System.Drawing.Size(100, 20);
            this.txtVutil.TabIndex = 13;
            // 
            // btnActu
            // 
            this.btnActu.Location = new System.Drawing.Point(261, 67);
            this.btnActu.Name = "btnActu";
            this.btnActu.Size = new System.Drawing.Size(75, 23);
            this.btnActu.TabIndex = 14;
            this.btnActu.Text = "Actualizar";
            this.btnActu.UseVisualStyleBackColor = true;
            this.btnActu.Click += new System.EventHandler(this.Btnsi_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(261, 105);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 15;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.Btncancel_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(120, 29);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(26, 13);
            this.lblId.TabIndex = 16;
            this.lblId.Text = "lblId";
            // 
            // FormUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 214);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnActu);
            this.Controls.Add(this.txtVutil);
            this.Controls.Add(this.txtVResidual);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nombre);
            this.Name = "FormUpdate";
            this.Text = "FormUpdate";
            this.Load += new System.EventHandler(this.FormUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnActu;
        private System.Windows.Forms.Button btnRegresar;
        public System.Windows.Forms.Label Nombre;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtvalor;
        public System.Windows.Forms.TextBox txtVResidual;
        public System.Windows.Forms.TextBox txtVutil;
        public System.Windows.Forms.Label lblId;
    }
}