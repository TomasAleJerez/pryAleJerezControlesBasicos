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
            this.chkPollo = new System.Windows.Forms.CheckBox();
            this.chkMostaza = new System.Windows.Forms.CheckBox();
            this.chkArroz = new System.Windows.Forms.CheckBox();
            this.lblSeleccionar = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCaja
            // 
            this.txtCaja.Location = new System.Drawing.Point(39, 55);
            this.txtCaja.Name = "txtCaja";
            this.txtCaja.Size = new System.Drawing.Size(363, 20);
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
            this.btnAsignar.Location = new System.Drawing.Point(271, 114);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(75, 23);
            this.btnAsignar.TabIndex = 4;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // chkPollo
            // 
            this.chkPollo.AutoSize = true;
            this.chkPollo.Location = new System.Drawing.Point(6, 54);
            this.chkPollo.Name = "chkPollo";
            this.chkPollo.Size = new System.Drawing.Size(49, 17);
            this.chkPollo.TabIndex = 5;
            this.chkPollo.Text = "Pollo";
            this.chkPollo.UseVisualStyleBackColor = true;
            // 
            // chkMostaza
            // 
            this.chkMostaza.AutoSize = true;
            this.chkMostaza.Location = new System.Drawing.Point(6, 31);
            this.chkMostaza.Name = "chkMostaza";
            this.chkMostaza.Size = new System.Drawing.Size(66, 17);
            this.chkMostaza.TabIndex = 6;
            this.chkMostaza.Text = "Mostaza";
            this.chkMostaza.UseVisualStyleBackColor = true;
            // 
            // chkArroz
            // 
            this.chkArroz.AutoSize = true;
            this.chkArroz.Location = new System.Drawing.Point(6, 77);
            this.chkArroz.Name = "chkArroz";
            this.chkArroz.Size = new System.Drawing.Size(50, 17);
            this.chkArroz.TabIndex = 7;
            this.chkArroz.Text = "Arroz";
            this.chkArroz.UseVisualStyleBackColor = true;
            // 
            // lblSeleccionar
            // 
            this.lblSeleccionar.AutoSize = true;
            this.lblSeleccionar.Location = new System.Drawing.Point(168, 35);
            this.lblSeleccionar.Name = "lblSeleccionar";
            this.lblSeleccionar.Size = new System.Drawing.Size(35, 13);
            this.lblSeleccionar.TabIndex = 8;
            this.lblSeleccionar.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSeleccionar);
            this.groupBox1.Controls.Add(this.chkPollo);
            this.groupBox1.Controls.Add(this.lblSeleccionar);
            this.groupBox1.Controls.Add(this.chkMostaza);
            this.groupBox1.Controls.Add(this.chkArroz);
            this.groupBox1.Location = new System.Drawing.Point(39, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 119);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(171, 71);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 9;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // frmCajaDeTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.optAzul);
            this.Controls.Add(this.optRojo);
            this.Controls.Add(this.lblCopiar);
            this.Controls.Add(this.txtCaja);
            this.Name = "frmCajaDeTexto";
            this.Text = "CajaDeTexto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCaja;
        private System.Windows.Forms.Label lblCopiar;
        private System.Windows.Forms.RadioButton optRojo;
        private System.Windows.Forms.RadioButton optAzul;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.CheckBox chkPollo;
        private System.Windows.Forms.CheckBox chkMostaza;
        private System.Windows.Forms.CheckBox chkArroz;
        private System.Windows.Forms.Label lblSeleccionar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSeleccionar;
    }
}