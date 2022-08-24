
namespace ProyectoTSP_Encog_
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageDatos = new System.Windows.Forms.TabPage();
            this.bttnVisualizar = new System.Windows.Forms.Button();
            this.bttnExaminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBoxPATH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageEyN = new System.Windows.Forms.TabPage();
            this.bttnExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
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
            this.bttnNormalizar = new System.Windows.Forms.Button();
            this.bttnExaminar2 = new System.Windows.Forms.Button();
            this.bttnExaminar3 = new System.Windows.Forms.Button();
            this.bttnEntrenar = new System.Windows.Forms.Button();
            this.textBoxPATHCSVn = new System.Windows.Forms.TextBox();
            this.textBoxPATHCSVo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTamaño = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageEyN.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageDatos);
            this.tabControl1.Controls.Add(this.tabPageEyN);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(619, 373);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageDatos
            // 
            this.tabPageDatos.Controls.Add(this.bttnVisualizar);
            this.tabPageDatos.Controls.Add(this.bttnExaminar);
            this.tabPageDatos.Controls.Add(this.dataGridView1);
            this.tabPageDatos.Controls.Add(this.txtBoxPATH);
            this.tabPageDatos.Controls.Add(this.label1);
            this.tabPageDatos.Location = new System.Drawing.Point(4, 22);
            this.tabPageDatos.Name = "tabPageDatos";
            this.tabPageDatos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDatos.Size = new System.Drawing.Size(611, 347);
            this.tabPageDatos.TabIndex = 0;
            this.tabPageDatos.Text = "Datos";
            this.tabPageDatos.UseVisualStyleBackColor = true;
            // 
            // bttnVisualizar
            // 
            this.bttnVisualizar.Location = new System.Drawing.Point(382, 162);
            this.bttnVisualizar.Margin = new System.Windows.Forms.Padding(2);
            this.bttnVisualizar.Name = "bttnVisualizar";
            this.bttnVisualizar.Size = new System.Drawing.Size(93, 24);
            this.bttnVisualizar.TabIndex = 14;
            this.bttnVisualizar.Text = "Visualizar datos";
            this.bttnVisualizar.UseVisualStyleBackColor = true;
            this.bttnVisualizar.Click += new System.EventHandler(this.BttnVisualizar_Click);
            // 
            // bttnExaminar
            // 
            this.bttnExaminar.Location = new System.Drawing.Point(382, 5);
            this.bttnExaminar.Margin = new System.Windows.Forms.Padding(2);
            this.bttnExaminar.Name = "bttnExaminar";
            this.bttnExaminar.Size = new System.Drawing.Size(93, 24);
            this.bttnExaminar.TabIndex = 13;
            this.bttnExaminar.Text = "Examinar ";
            this.bttnExaminar.UseVisualStyleBackColor = true;
            this.bttnExaminar.Click += new System.EventHandler(this.BttnExaminar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 44);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(373, 298);
            this.dataGridView1.TabIndex = 12;
            // 
            // txtBoxPATH
            // 
            this.txtBoxPATH.Location = new System.Drawing.Point(78, 8);
            this.txtBoxPATH.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxPATH.Name = "txtBoxPATH";
            this.txtBoxPATH.ReadOnly = true;
            this.txtBoxPATH.Size = new System.Drawing.Size(300, 20);
            this.txtBoxPATH.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "PATH (xlsx): ";
            // 
            // tabPageEyN
            // 
            this.tabPageEyN.Controls.Add(this.txtTamaño);
            this.tabPageEyN.Controls.Add(this.label6);
            this.tabPageEyN.Controls.Add(this.bttnExit);
            this.tabPageEyN.Controls.Add(this.label4);
            this.tabPageEyN.Controls.Add(this.bttnConectarSerial);
            this.tabPageEyN.Controls.Add(this.bttnDesconectarSerial);
            this.tabPageEyN.Controls.Add(this.label5);
            this.tabPageEyN.Controls.Add(this.txtActualE);
            this.tabPageEyN.Controls.Add(this.label9);
            this.tabPageEyN.Controls.Add(this.label11);
            this.tabPageEyN.Controls.Add(this.txtMorados);
            this.tabPageEyN.Controls.Add(this.txtNaranjas);
            this.tabPageEyN.Controls.Add(this.txtTotal);
            this.tabPageEyN.Controls.Add(this.label13);
            this.tabPageEyN.Controls.Add(this.label14);
            this.tabPageEyN.Controls.Add(this.label15);
            this.tabPageEyN.Controls.Add(this.bttnNormalizar);
            this.tabPageEyN.Controls.Add(this.bttnExaminar2);
            this.tabPageEyN.Controls.Add(this.bttnExaminar3);
            this.tabPageEyN.Controls.Add(this.bttnEntrenar);
            this.tabPageEyN.Controls.Add(this.textBoxPATHCSVn);
            this.tabPageEyN.Controls.Add(this.textBoxPATHCSVo);
            this.tabPageEyN.Controls.Add(this.label3);
            this.tabPageEyN.Controls.Add(this.label2);
            this.tabPageEyN.Location = new System.Drawing.Point(4, 22);
            this.tabPageEyN.Name = "tabPageEyN";
            this.tabPageEyN.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEyN.Size = new System.Drawing.Size(611, 347);
            this.tabPageEyN.TabIndex = 1;
            this.tabPageEyN.Text = "Entrenar-Normalizar-Clasificador";
            this.tabPageEyN.UseVisualStyleBackColor = true;
            // 
            // bttnExit
            // 
            this.bttnExit.Location = new System.Drawing.Point(365, 274);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(83, 27);
            this.bttnExit.TabIndex = 54;
            this.bttnExit.Text = "Salir";
            this.bttnExit.UseVisualStyleBackColor = true;
            this.bttnExit.Click += new System.EventHandler(this.BttnExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Comunicación serial:";
            // 
            // bttnConectarSerial
            // 
            this.bttnConectarSerial.Location = new System.Drawing.Point(365, 208);
            this.bttnConectarSerial.Name = "bttnConectarSerial";
            this.bttnConectarSerial.Size = new System.Drawing.Size(83, 27);
            this.bttnConectarSerial.TabIndex = 52;
            this.bttnConectarSerial.Text = "Conectar";
            this.bttnConectarSerial.UseVisualStyleBackColor = true;
            this.bttnConectarSerial.Click += new System.EventHandler(this.BttnConectarSerial_Click);
            // 
            // bttnDesconectarSerial
            // 
            this.bttnDesconectarSerial.Location = new System.Drawing.Point(365, 241);
            this.bttnDesconectarSerial.Name = "bttnDesconectarSerial";
            this.bttnDesconectarSerial.Size = new System.Drawing.Size(83, 27);
            this.bttnDesconectarSerial.TabIndex = 51;
            this.bttnDesconectarSerial.Text = "Desconectar";
            this.bttnDesconectarSerial.UseVisualStyleBackColor = true;
            this.bttnDesconectarSerial.Click += new System.EventHandler(this.BttnDesconectarSerial_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 50;
            this.label5.Text = "ACTUAL";
            // 
            // txtActualE
            // 
            this.txtActualE.Location = new System.Drawing.Point(9, 270);
            this.txtActualE.Name = "txtActualE";
            this.txtActualE.ReadOnly = true;
            this.txtActualE.Size = new System.Drawing.Size(100, 20);
            this.txtActualE.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 48;
            this.label9.Text = "Etiquetado:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(227, 16);
            this.label11.TabIndex = 46;
            this.label11.Text = "CLASIFICADOR DE PAQUETES";
            // 
            // txtMorados
            // 
            this.txtMorados.Location = new System.Drawing.Point(9, 212);
            this.txtMorados.Name = "txtMorados";
            this.txtMorados.ReadOnly = true;
            this.txtMorados.Size = new System.Drawing.Size(100, 20);
            this.txtMorados.TabIndex = 45;
            // 
            // txtNaranjas
            // 
            this.txtNaranjas.Location = new System.Drawing.Point(9, 170);
            this.txtNaranjas.Name = "txtNaranjas";
            this.txtNaranjas.ReadOnly = true;
            this.txtNaranjas.Size = new System.Drawing.Size(100, 20);
            this.txtNaranjas.TabIndex = 44;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(9, 128);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 43;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 193);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(186, 16);
            this.label13.TabIndex = 42;
            this.label13.Text = "Paquetes etiquetado morado:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 151);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(184, 16);
            this.label14.TabIndex = 41;
            this.label14.Text = "Paquetes etiquetado naranja:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(8, 109);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 16);
            this.label15.TabIndex = 40;
            this.label15.Text = "Paquetes totales:";
            // 
            // bttnNormalizar
            // 
            this.bttnNormalizar.Location = new System.Drawing.Point(385, 83);
            this.bttnNormalizar.Margin = new System.Windows.Forms.Padding(2);
            this.bttnNormalizar.Name = "bttnNormalizar";
            this.bttnNormalizar.Size = new System.Drawing.Size(93, 34);
            this.bttnNormalizar.TabIndex = 30;
            this.bttnNormalizar.Text = "Normalizar Datos";
            this.bttnNormalizar.UseVisualStyleBackColor = true;
            this.bttnNormalizar.Click += new System.EventHandler(this.BttnNormalizar_Click);
            // 
            // bttnExaminar2
            // 
            this.bttnExaminar2.Location = new System.Drawing.Point(506, 5);
            this.bttnExaminar2.Margin = new System.Windows.Forms.Padding(2);
            this.bttnExaminar2.Name = "bttnExaminar2";
            this.bttnExaminar2.Size = new System.Drawing.Size(93, 24);
            this.bttnExaminar2.TabIndex = 29;
            this.bttnExaminar2.Text = "Examinar ";
            this.bttnExaminar2.UseVisualStyleBackColor = true;
            this.bttnExaminar2.Click += new System.EventHandler(this.BttnExaminar2_Click);
            // 
            // bttnExaminar3
            // 
            this.bttnExaminar3.Location = new System.Drawing.Point(506, 43);
            this.bttnExaminar3.Margin = new System.Windows.Forms.Padding(2);
            this.bttnExaminar3.Name = "bttnExaminar3";
            this.bttnExaminar3.Size = new System.Drawing.Size(93, 24);
            this.bttnExaminar3.TabIndex = 28;
            this.bttnExaminar3.Text = "Examinar ";
            this.bttnExaminar3.UseVisualStyleBackColor = true;
            this.bttnExaminar3.Click += new System.EventHandler(this.BttnExaminar3_Click);
            // 
            // bttnEntrenar
            // 
            this.bttnEntrenar.Location = new System.Drawing.Point(494, 83);
            this.bttnEntrenar.Margin = new System.Windows.Forms.Padding(2);
            this.bttnEntrenar.Name = "bttnEntrenar";
            this.bttnEntrenar.Size = new System.Drawing.Size(93, 34);
            this.bttnEntrenar.TabIndex = 27;
            this.bttnEntrenar.Text = "Entrenar Red";
            this.bttnEntrenar.UseVisualStyleBackColor = true;
            this.bttnEntrenar.Click += new System.EventHandler(this.BttnEntrenar_Click);
            // 
            // textBoxPATHCSVn
            // 
            this.textBoxPATHCSVn.Location = new System.Drawing.Point(147, 46);
            this.textBoxPATHCSVn.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPATHCSVn.Name = "textBoxPATHCSVn";
            this.textBoxPATHCSVn.ReadOnly = true;
            this.textBoxPATHCSVn.Size = new System.Drawing.Size(355, 20);
            this.textBoxPATHCSVn.TabIndex = 25;
            // 
            // textBoxPATHCSVo
            // 
            this.textBoxPATHCSVo.Location = new System.Drawing.Point(148, 8);
            this.textBoxPATHCSVo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPATHCSVo.Name = "textBoxPATHCSVo";
            this.textBoxPATHCSVo.ReadOnly = true;
            this.textBoxPATHCSVo.Size = new System.Drawing.Size(354, 20);
            this.textBoxPATHCSVo.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "PATH Normalizados (CSV): ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "PATH Oiginal (CSV): ";
            // 
            // txtTamaño
            // 
            this.txtTamaño.Location = new System.Drawing.Point(115, 270);
            this.txtTamaño.Name = "txtTamaño";
            this.txtTamaño.ReadOnly = true;
            this.txtTamaño.Size = new System.Drawing.Size(100, 20);
            this.txtTamaño.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(112, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 55;
            this.label6.Text = "Tamaño (cm):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 397);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageDatos.ResumeLayout(false);
            this.tabPageDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageEyN.ResumeLayout(false);
            this.tabPageEyN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageDatos;
        private System.Windows.Forms.TabPage tabPageEyN;
        private System.Windows.Forms.Button bttnVisualizar;
        private System.Windows.Forms.Button bttnExaminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBoxPATH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttnNormalizar;
        private System.Windows.Forms.Button bttnExaminar2;
        private System.Windows.Forms.Button bttnExaminar3;
        private System.Windows.Forms.Button bttnEntrenar;
        private System.Windows.Forms.TextBox textBoxPATHCSVn;
        private System.Windows.Forms.TextBox textBoxPATHCSVo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.Button bttnExit;
        private System.Windows.Forms.TextBox txtTamaño;
        private System.Windows.Forms.Label label6;
    }
}

