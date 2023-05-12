namespace pryAleJerezControlesBasicos
{
    partial class frmCajaDeTexto
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
            this.txtCaja = new System.Windows.Forms.TextBox();
            this.lblCopiar = new System.Windows.Forms.Label();
            this.optRojo = new System.Windows.Forms.RadioButton();
            this.optAzul = new System.Windows.Forms.RadioButton();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCaja
            // 
            this.txtCaja.Location = new System.Drawing.Point(63, 55);
            this.txtCaja.Name = "txtCaja";
            this.txtCaja.Size = new System.Drawing.Size(100, 20);
            this.txtCaja.TabIndex = 0;
            this.txtCaja.TextChanged += new System.EventHandler(this.txtCaja_TextChanged);
            // 
            // lblCopiar
            // 
            this.lblCopiar.AutoSize = true;
            this.lblCopiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopiar.Location = new System.Drawing.Point(34, 174);
            this.lblCopiar.Name = "lblCopiar";
            this.lblCopiar.Size = new System.Drawing.Size(0, 25);
            this.lblCopiar.TabIndex = 1;
            // 
            // optRojo
            // 
            this.optRojo.AutoSize = true;
            this.optRojo.Location = new System.Drawing.Point(39, 117);
            this.optRojo.Name = "optRojo";
            this.optRojo.Size = new System.Drawing.Size(47, 17);
            this.optRojo.TabIndex = 2;
            this.optRojo.TabStop = true;
            this.optRojo.Text = "Rojo";
            this.optRojo.UseVisualStyleBackColor = true;
            // 
            // optAzul
            // 
            this.optAzul.AutoSize = true;
            this.optAzul.Location = new System.Drawing.Point(153, 117);
            this.optAzul.Name = "optAzul";
            this.optAzul.Size = new System.Drawing.Size(45, 17);
            this.optAzul.TabIndex = 3;
            this.optAzul.TabStop = true;
            this.optAzul.Text = "Azul";
            this.optAzul.UseVisualStyleBackColor = true;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(271, 117);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(75, 23);
            this.btnAsignar.TabIndex = 4;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // frmCajaDeTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.optAzul);
            this.Controls.Add(this.optRojo);
            this.Controls.Add(this.lblCopiar);
            this.Controls.Add(this.txtCaja);
            this.Name = "frmCajaDeTexto";
            this.Text = "CajaDeTexto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCaja;
        private System.Windows.Forms.Label lblCopiar;
        private System.Windows.Forms.RadioButton optRojo;
        private System.Windows.Forms.RadioButton optAzul;
        private System.Windows.Forms.Button btnAsignar;
    }
}