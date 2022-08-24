
namespace Practica1__Entregable_
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxLargo = new System.Windows.Forms.TextBox();
            this.txtBoxAlto = new System.Windows.Forms.TextBox();
            this.txtBoxRad1 = new System.Windows.Forms.TextBox();
            this.txtBoxRad2 = new System.Windows.Forms.TextBox();
            this.bttnCalcular = new System.Windows.Forms.Button();
            this.bttnExit = new System.Windows.Forms.Button();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtShow2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(118, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(549, 359);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Largo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Radio verde:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Radio rosa:";
            // 
            // txtBoxLargo
            // 
            this.txtBoxLargo.Location = new System.Drawing.Point(12, 65);
            this.txtBoxLargo.Name = "txtBoxLargo";
            this.txtBoxLargo.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLargo.TabIndex = 6;
            // 
            // txtBoxAlto
            // 
            this.txtBoxAlto.Location = new System.Drawing.Point(12, 104);
            this.txtBoxAlto.Name = "txtBoxAlto";
            this.txtBoxAlto.Size = new System.Drawing.Size(100, 20);
            this.txtBoxAlto.TabIndex = 7;
            // 
            // txtBoxRad1
            // 
            this.txtBoxRad1.Location = new System.Drawing.Point(12, 143);
            this.txtBoxRad1.Name = "txtBoxRad1";
            this.txtBoxRad1.Size = new System.Drawing.Size(100, 20);
            this.txtBoxRad1.TabIndex = 9;
            // 
            // txtBoxRad2
            // 
            this.txtBoxRad2.Location = new System.Drawing.Point(12, 182);
            this.txtBoxRad2.Name = "txtBoxRad2";
            this.txtBoxRad2.Size = new System.Drawing.Size(100, 20);
            this.txtBoxRad2.TabIndex = 10;
            // 
            // bttnCalcular
            // 
            this.bttnCalcular.Location = new System.Drawing.Point(24, 239);
            this.bttnCalcular.Name = "bttnCalcular";
            this.bttnCalcular.Size = new System.Drawing.Size(75, 47);
            this.bttnCalcular.TabIndex = 11;
            this.bttnCalcular.Text = "Calcular";
            this.bttnCalcular.UseVisualStyleBackColor = true;
            this.bttnCalcular.Click += new System.EventHandler(this.BttnCalcular_Click);
            // 
            // bttnExit
            // 
            this.bttnExit.Location = new System.Drawing.Point(24, 292);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(75, 49);
            this.bttnExit.TabIndex = 13;
            this.bttnExit.Text = "Salir";
            this.bttnExit.UseVisualStyleBackColor = true;
            this.bttnExit.Click += new System.EventHandler(this.BttnExit_Click);
            // 
            // txtShow
            // 
            this.txtShow.AcceptsTab = true;
            this.txtShow.Location = new System.Drawing.Point(673, 12);
            this.txtShow.Multiline = true;
            this.txtShow.Name = "txtShow";
            this.txtShow.ReadOnly = true;
            this.txtShow.Size = new System.Drawing.Size(210, 167);
            this.txtShow.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Dimensiones";
            // 
            // txtShow2
            // 
            this.txtShow2.AcceptsTab = true;
            this.txtShow2.Location = new System.Drawing.Point(673, 203);
            this.txtShow2.Multiline = true;
            this.txtShow2.Name = "txtShow2";
            this.txtShow2.ReadOnly = true;
            this.txtShow2.Size = new System.Drawing.Size(210, 167);
            this.txtShow2.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Largo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(213, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Largo - Alto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(639, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Alto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(273, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Radio verde";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(433, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Radio rosa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 382);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtShow2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.bttnExit);
            this.Controls.Add(this.bttnCalcular);
            this.Controls.Add(this.txtBoxRad2);
            this.Controls.Add(this.txtBoxRad1);
            this.Controls.Add(this.txtBoxAlto);
            this.Controls.Add(this.txtBoxLargo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Calculadora de centroides";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxLargo;
        private System.Windows.Forms.TextBox txtBoxAlto;
        private System.Windows.Forms.TextBox txtBoxRad1;
        private System.Windows.Forms.TextBox txtBoxRad2;
        private System.Windows.Forms.Button bttnCalcular;
        private System.Windows.Forms.Button bttnExit;
        private System.Windows.Forms.TextBox txtShow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtShow2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

