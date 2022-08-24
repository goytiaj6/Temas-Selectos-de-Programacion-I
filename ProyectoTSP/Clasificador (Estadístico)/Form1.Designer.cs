
namespace Clasificador__Estadístico_
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
            this.label3 = new System.Windows.Forms.Label();
            this.Color = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTamaño = new System.Windows.Forms.TextBox();
            this.bttnExit = new System.Windows.Forms.Button();
            this.bttnConectarSerial = new System.Windows.Forms.Button();
            this.bttnDesconectarSerial = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtActualE = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMorados = new System.Windows.Forms.TextBox();
            this.txtNaranjas = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(270, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 110;
            this.label3.Text = "Etiquetado:";
            // 
            // Color
            // 
            this.Color.Location = new System.Drawing.Point(270, 28);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(70, 67);
            this.Color.TabIndex = 109;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 108;
            this.label2.Text = "Comunicación serial:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 107;
            this.label1.Text = "Tamaño (cm):";
            // 
            // txtTamaño
            // 
            this.txtTamaño.Location = new System.Drawing.Point(124, 187);
            this.txtTamaño.Name = "txtTamaño";
            this.txtTamaño.ReadOnly = true;
            this.txtTamaño.Size = new System.Drawing.Size(100, 20);
            this.txtTamaño.TabIndex = 106;
            // 
            // bttnExit
            // 
            this.bttnExit.Location = new System.Drawing.Point(257, 180);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(83, 27);
            this.bttnExit.TabIndex = 105;
            this.bttnExit.Text = "Salir";
            this.bttnExit.UseVisualStyleBackColor = true;
            this.bttnExit.Click += new System.EventHandler(this.BttnExit_Click);
            // 
            // bttnConectarSerial
            // 
            this.bttnConectarSerial.Location = new System.Drawing.Point(257, 114);
            this.bttnConectarSerial.Name = "bttnConectarSerial";
            this.bttnConectarSerial.Size = new System.Drawing.Size(83, 27);
            this.bttnConectarSerial.TabIndex = 104;
            this.bttnConectarSerial.Text = "Conectar";
            this.bttnConectarSerial.UseVisualStyleBackColor = true;
            this.bttnConectarSerial.Click += new System.EventHandler(this.BttnConectarSerial_Click);
            // 
            // bttnDesconectarSerial
            // 
            this.bttnDesconectarSerial.Location = new System.Drawing.Point(257, 147);
            this.bttnDesconectarSerial.Name = "bttnDesconectarSerial";
            this.bttnDesconectarSerial.Size = new System.Drawing.Size(83, 27);
            this.bttnDesconectarSerial.TabIndex = 103;
            this.bttnDesconectarSerial.Text = "Desconectar";
            this.bttnDesconectarSerial.UseVisualStyleBackColor = true;
            this.bttnDesconectarSerial.Click += new System.EventHandler(this.BttnDesconectarSerial_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 102;
            this.label5.Text = "ACTUAL";
            // 
            // txtActualE
            // 
            this.txtActualE.Location = new System.Drawing.Point(18, 187);
            this.txtActualE.Name = "txtActualE";
            this.txtActualE.ReadOnly = true;
            this.txtActualE.Size = new System.Drawing.Size(100, 20);
            this.txtActualE.TabIndex = 101;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 100;
            this.label9.Text = "Etiquetado:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(227, 16);
            this.label11.TabIndex = 99;
            this.label11.Text = "CLASIFICADOR DE PAQUETES";
            // 
            // txtMorados
            // 
            this.txtMorados.Location = new System.Drawing.Point(18, 129);
            this.txtMorados.Name = "txtMorados";
            this.txtMorados.ReadOnly = true;
            this.txtMorados.Size = new System.Drawing.Size(100, 20);
            this.txtMorados.TabIndex = 98;
            // 
            // txtNaranjas
            // 
            this.txtNaranjas.Location = new System.Drawing.Point(18, 87);
            this.txtNaranjas.Name = "txtNaranjas";
            this.txtNaranjas.ReadOnly = true;
            this.txtNaranjas.Size = new System.Drawing.Size(100, 20);
            this.txtNaranjas.TabIndex = 97;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(18, 45);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 96;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(17, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(186, 16);
            this.label13.TabIndex = 95;
            this.label13.Text = "Paquetes etiquetado morado:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(17, 68);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(184, 16);
            this.label14.TabIndex = 94;
            this.label14.Text = "Paquetes etiquetado naranja:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(17, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 16);
            this.label15.TabIndex = 93;
            this.label15.Text = "Paquetes totales:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 226);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Color);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTamaño);
            this.Controls.Add(this.bttnExit);
            this.Controls.Add(this.bttnConectarSerial);
            this.Controls.Add(this.bttnDesconectarSerial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtActualE);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtMorados);
            this.Controls.Add(this.txtNaranjas);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Color;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTamaño;
        private System.Windows.Forms.Button bttnExit;
        private System.Windows.Forms.Button bttnConectarSerial;
        private System.Windows.Forms.Button bttnDesconectarSerial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtActualE;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMorados;
        private System.Windows.Forms.TextBox txtNaranjas;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}

