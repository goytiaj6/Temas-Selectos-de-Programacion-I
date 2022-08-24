
namespace Practica3
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
            this.bttnConexion = new System.Windows.Forms.Button();
            this.bttnInsert = new System.Windows.Forms.Button();
            this.bttnExit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bttnTabla = new System.Windows.Forms.Button();
            this.txtResA = new System.Windows.Forms.TextBox();
            this.bttnDrop = new System.Windows.Forms.Button();
            this.bttnTruncate = new System.Windows.Forms.Button();
            this.txtResB = new System.Windows.Forms.TextBox();
            this.txtCapacitor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnConexion
            // 
            this.bttnConexion.Location = new System.Drawing.Point(12, 223);
            this.bttnConexion.Name = "bttnConexion";
            this.bttnConexion.Size = new System.Drawing.Size(75, 23);
            this.bttnConexion.TabIndex = 0;
            this.bttnConexion.Text = "Conectar";
            this.bttnConexion.UseVisualStyleBackColor = true;
            this.bttnConexion.Click += new System.EventHandler(this.BttnConexion_Click);
            // 
            // bttnInsert
            // 
            this.bttnInsert.Location = new System.Drawing.Point(258, 132);
            this.bttnInsert.Name = "bttnInsert";
            this.bttnInsert.Size = new System.Drawing.Size(91, 23);
            this.bttnInsert.TabIndex = 1;
            this.bttnInsert.Text = "Insertar";
            this.bttnInsert.UseVisualStyleBackColor = true;
            this.bttnInsert.Click += new System.EventHandler(this.BttnInsert_Click);
            // 
            // bttnExit
            // 
            this.bttnExit.Location = new System.Drawing.Point(174, 223);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(75, 23);
            this.bttnExit.TabIndex = 2;
            this.bttnExit.Text = "Salir";
            this.bttnExit.UseVisualStyleBackColor = true;
            this.bttnExit.Click += new System.EventHandler(this.BttnExit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(237, 205);
            this.dataGridView1.TabIndex = 3;
            // 
            // bttnTabla
            // 
            this.bttnTabla.Location = new System.Drawing.Point(93, 223);
            this.bttnTabla.Name = "bttnTabla";
            this.bttnTabla.Size = new System.Drawing.Size(75, 23);
            this.bttnTabla.TabIndex = 4;
            this.bttnTabla.Text = "Crear Tabla";
            this.bttnTabla.UseVisualStyleBackColor = true;
            this.bttnTabla.Click += new System.EventHandler(this.BttnTabla_Click);
            // 
            // txtResA
            // 
            this.txtResA.Location = new System.Drawing.Point(255, 28);
            this.txtResA.Name = "txtResA";
            this.txtResA.Size = new System.Drawing.Size(100, 20);
            this.txtResA.TabIndex = 5;
            // 
            // bttnDrop
            // 
            this.bttnDrop.Location = new System.Drawing.Point(258, 205);
            this.bttnDrop.Name = "bttnDrop";
            this.bttnDrop.Size = new System.Drawing.Size(91, 41);
            this.bttnDrop.TabIndex = 6;
            this.bttnDrop.Text = "BorrarTabla";
            this.bttnDrop.UseVisualStyleBackColor = true;
            this.bttnDrop.Click += new System.EventHandler(this.BttnDrop_Click);
            // 
            // bttnTruncate
            // 
            this.bttnTruncate.Location = new System.Drawing.Point(258, 158);
            this.bttnTruncate.Name = "bttnTruncate";
            this.bttnTruncate.Size = new System.Drawing.Size(91, 41);
            this.bttnTruncate.TabIndex = 7;
            this.bttnTruncate.Text = "Limpiar Tabla";
            this.bttnTruncate.UseVisualStyleBackColor = true;
            this.bttnTruncate.Click += new System.EventHandler(this.BttnTruncate_Click);
            // 
            // txtResB
            // 
            this.txtResB.Location = new System.Drawing.Point(255, 67);
            this.txtResB.Name = "txtResB";
            this.txtResB.Size = new System.Drawing.Size(100, 20);
            this.txtResB.TabIndex = 8;
            // 
            // txtCapacitor
            // 
            this.txtCapacitor.Location = new System.Drawing.Point(255, 106);
            this.txtCapacitor.Name = "txtCapacitor";
            this.txtCapacitor.Size = new System.Drawing.Size(100, 20);
            this.txtCapacitor.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Resistor A: [Ohms]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Resistor B:  [Ohms]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Capacitor:  [uF]";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(361, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 258);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCapacitor);
            this.Controls.Add(this.txtResB);
            this.Controls.Add(this.bttnTruncate);
            this.Controls.Add(this.bttnDrop);
            this.Controls.Add(this.txtResA);
            this.Controls.Add(this.bttnTabla);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bttnExit);
            this.Controls.Add(this.bttnInsert);
            this.Controls.Add(this.bttnConexion);
            this.Name = "Form1";
            this.Text = "Calculador de frecuencias para 555 astable";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnConexion;
        private System.Windows.Forms.Button bttnInsert;
        private System.Windows.Forms.Button bttnExit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bttnTabla;
        private System.Windows.Forms.TextBox txtResA;
        private System.Windows.Forms.Button bttnDrop;
        private System.Windows.Forms.Button bttnTruncate;
        private System.Windows.Forms.TextBox txtResB;
        private System.Windows.Forms.TextBox txtCapacitor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

