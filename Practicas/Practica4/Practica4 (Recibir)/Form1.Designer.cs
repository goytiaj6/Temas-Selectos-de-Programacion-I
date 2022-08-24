
namespace Practica4__Recibir_
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxR = new System.Windows.Forms.TextBox();
            this.txtBoxG = new System.Windows.Forms.TextBox();
            this.txtBoxB = new System.Windows.Forms.TextBox();
            this.bttnConectar = new System.Windows.Forms.Button();
            this.bttnDesconectar = new System.Windows.Forms.Button();
            this.bttnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valores que envia arduino de un sensor RGB:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "R:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "G:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "B:";
            // 
            // txtBoxR
            // 
            this.txtBoxR.Location = new System.Drawing.Point(70, 40);
            this.txtBoxR.Name = "txtBoxR";
            this.txtBoxR.ReadOnly = true;
            this.txtBoxR.Size = new System.Drawing.Size(100, 20);
            this.txtBoxR.TabIndex = 4;
            // 
            // txtBoxG
            // 
            this.txtBoxG.Location = new System.Drawing.Point(70, 66);
            this.txtBoxG.Name = "txtBoxG";
            this.txtBoxG.ReadOnly = true;
            this.txtBoxG.Size = new System.Drawing.Size(100, 20);
            this.txtBoxG.TabIndex = 5;
            // 
            // txtBoxB
            // 
            this.txtBoxB.Location = new System.Drawing.Point(70, 92);
            this.txtBoxB.Name = "txtBoxB";
            this.txtBoxB.ReadOnly = true;
            this.txtBoxB.Size = new System.Drawing.Size(100, 20);
            this.txtBoxB.TabIndex = 6;
            // 
            // bttnConectar
            // 
            this.bttnConectar.Location = new System.Drawing.Point(12, 121);
            this.bttnConectar.Name = "bttnConectar";
            this.bttnConectar.Size = new System.Drawing.Size(75, 23);
            this.bttnConectar.TabIndex = 7;
            this.bttnConectar.Text = "Conectar";
            this.bttnConectar.UseVisualStyleBackColor = true;
            this.bttnConectar.Click += new System.EventHandler(this.BttnConectar_Click);
            // 
            // bttnDesconectar
            // 
            this.bttnDesconectar.Location = new System.Drawing.Point(116, 121);
            this.bttnDesconectar.Name = "bttnDesconectar";
            this.bttnDesconectar.Size = new System.Drawing.Size(75, 23);
            this.bttnDesconectar.TabIndex = 8;
            this.bttnDesconectar.Text = "Desconectar";
            this.bttnDesconectar.UseVisualStyleBackColor = true;
            this.bttnDesconectar.Click += new System.EventHandler(this.BttnDesconectar_Click);
            // 
            // bttnExit
            // 
            this.bttnExit.Location = new System.Drawing.Point(225, 121);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(75, 23);
            this.bttnExit.TabIndex = 9;
            this.bttnExit.Text = "Salir";
            this.bttnExit.UseVisualStyleBackColor = true;
            this.bttnExit.Click += new System.EventHandler(this.BttnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 156);
            this.Controls.Add(this.bttnExit);
            this.Controls.Add(this.bttnDesconectar);
            this.Controls.Add(this.bttnConectar);
            this.Controls.Add(this.txtBoxB);
            this.Controls.Add(this.txtBoxG);
            this.Controls.Add(this.txtBoxR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Comunicacion Serial (RGB)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxR;
        private System.Windows.Forms.TextBox txtBoxG;
        private System.Windows.Forms.TextBox txtBoxB;
        private System.Windows.Forms.Button bttnConectar;
        private System.Windows.Forms.Button bttnDesconectar;
        private System.Windows.Forms.Button bttnExit;
    }
}

