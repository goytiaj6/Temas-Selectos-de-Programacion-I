
namespace WS_Cliente_
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBoxVs = new System.Windows.Forms.TextBox();
            this.txtBoxRF = new System.Windows.Forms.TextBox();
            this.txtBoxVe = new System.Windows.Forms.TextBox();
            this.txtBoxR1 = new System.Windows.Forms.TextBox();
            this.bttnExit = new System.Windows.Forms.Button();
            this.bttnCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora de amplificador no inversor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(376, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBoxVs);
            this.groupBox1.Controls.Add(this.txtBoxRF);
            this.groupBox1.Controls.Add(this.txtBoxVe);
            this.groupBox1.Controls.Add(this.txtBoxR1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(59, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 276);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Amplificador";
            // 
            // txtBoxVs
            // 
            this.txtBoxVs.Location = new System.Drawing.Point(268, 212);
            this.txtBoxVs.Name = "txtBoxVs";
            this.txtBoxVs.ReadOnly = true;
            this.txtBoxVs.Size = new System.Drawing.Size(100, 20);
            this.txtBoxVs.TabIndex = 5;
            // 
            // txtBoxRF
            // 
            this.txtBoxRF.Location = new System.Drawing.Point(268, 19);
            this.txtBoxRF.Name = "txtBoxRF";
            this.txtBoxRF.Size = new System.Drawing.Size(100, 20);
            this.txtBoxRF.TabIndex = 4;
            // 
            // txtBoxVe
            // 
            this.txtBoxVe.Location = new System.Drawing.Point(34, 225);
            this.txtBoxVe.Name = "txtBoxVe";
            this.txtBoxVe.Size = new System.Drawing.Size(100, 20);
            this.txtBoxVe.TabIndex = 3;
            // 
            // txtBoxR1
            // 
            this.txtBoxR1.Location = new System.Drawing.Point(34, 67);
            this.txtBoxR1.Name = "txtBoxR1";
            this.txtBoxR1.Size = new System.Drawing.Size(100, 20);
            this.txtBoxR1.TabIndex = 2;
            // 
            // bttnExit
            // 
            this.bttnExit.Location = new System.Drawing.Point(453, 278);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(75, 23);
            this.bttnExit.TabIndex = 3;
            this.bttnExit.Text = "Salir";
            this.bttnExit.UseVisualStyleBackColor = true;
            this.bttnExit.Click += new System.EventHandler(this.BttnExit_Click);
            // 
            // bttnCalcular
            // 
            this.bttnCalcular.Location = new System.Drawing.Point(453, 12);
            this.bttnCalcular.Name = "bttnCalcular";
            this.bttnCalcular.Size = new System.Drawing.Size(75, 51);
            this.bttnCalcular.TabIndex = 4;
            this.bttnCalcular.Text = "Calcular Salida de Voltaje";
            this.bttnCalcular.UseVisualStyleBackColor = true;
            this.bttnCalcular.Click += new System.EventHandler(this.BttnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 313);
            this.Controls.Add(this.bttnCalcular);
            this.Controls.Add(this.bttnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bttnExit;
        private System.Windows.Forms.Button bttnCalcular;
        private System.Windows.Forms.TextBox txtBoxVs;
        private System.Windows.Forms.TextBox txtBoxRF;
        private System.Windows.Forms.TextBox txtBoxVe;
        private System.Windows.Forms.TextBox txtBoxR1;
    }
}

