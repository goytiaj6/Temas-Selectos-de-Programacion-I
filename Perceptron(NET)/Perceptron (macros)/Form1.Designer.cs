
namespace Perceptron__macros_
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.patron4 = new System.Windows.Forms.Button();
            this.patron3 = new System.Windows.Forms.Button();
            this.patron2 = new System.Windows.Forms.Button();
            this.patron1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtD4 = new System.Windows.Forms.TextBox();
            this.txtD3 = new System.Windows.Forms.TextBox();
            this.txtD2 = new System.Windows.Forms.TextBox();
            this.txtD1 = new System.Windows.Forms.TextBox();
            this.txtX42 = new System.Windows.Forms.TextBox();
            this.txtX32 = new System.Windows.Forms.TextBox();
            this.txtX22 = new System.Windows.Forms.TextBox();
            this.txtX12 = new System.Windows.Forms.TextBox();
            this.txtX41 = new System.Windows.Forms.TextBox();
            this.txtX31 = new System.Windows.Forms.TextBox();
            this.txtX21 = new System.Windows.Forms.TextBox();
            this.txtX11 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Entrenamiento = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtBoxY = new System.Windows.Forms.TextBox();
            this.txtBoxD = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBoxFactor = new System.Windows.Forms.TextBox();
            this.txtBoxBias = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxSuma = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxW2 = new System.Windows.Forms.TextBox();
            this.txtBoxX2 = new System.Windows.Forms.TextBox();
            this.txtBoxW1 = new System.Windows.Forms.TextBox();
            this.txtBoxX1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Actualizar = new System.Windows.Forms.Button();
            this.txtNBias = new System.Windows.Forms.TextBox();
            this.txtNW2 = new System.Windows.Forms.TextBox();
            this.txtNW1 = new System.Windows.Forms.TextBox();
            this.txtDelta2 = new System.Windows.Forms.TextBox();
            this.txtDelta1 = new System.Windows.Forms.TextBox();
            this.txtError = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.patron4);
            this.groupBox1.Controls.Add(this.patron3);
            this.groupBox1.Controls.Add(this.patron2);
            this.groupBox1.Controls.Add(this.patron1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtD4);
            this.groupBox1.Controls.Add(this.txtD3);
            this.groupBox1.Controls.Add(this.txtD2);
            this.groupBox1.Controls.Add(this.txtD1);
            this.groupBox1.Controls.Add(this.txtX42);
            this.groupBox1.Controls.Add(this.txtX32);
            this.groupBox1.Controls.Add(this.txtX22);
            this.groupBox1.Controls.Add(this.txtX12);
            this.groupBox1.Controls.Add(this.txtX41);
            this.groupBox1.Controls.Add(this.txtX31);
            this.groupBox1.Controls.Add(this.txtX21);
            this.groupBox1.Controls.Add(this.txtX11);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // patron4
            // 
            this.patron4.Location = new System.Drawing.Point(161, 157);
            this.patron4.Name = "patron4";
            this.patron4.Size = new System.Drawing.Size(39, 23);
            this.patron4.TabIndex = 21;
            this.patron4.Text = "->";
            this.patron4.UseVisualStyleBackColor = true;
            this.patron4.Click += new System.EventHandler(this.Patron4_Click);
            // 
            // patron3
            // 
            this.patron3.Location = new System.Drawing.Point(161, 131);
            this.patron3.Name = "patron3";
            this.patron3.Size = new System.Drawing.Size(39, 23);
            this.patron3.TabIndex = 20;
            this.patron3.Text = "->";
            this.patron3.UseVisualStyleBackColor = true;
            this.patron3.Click += new System.EventHandler(this.Patron3_Click);
            // 
            // patron2
            // 
            this.patron2.Location = new System.Drawing.Point(161, 105);
            this.patron2.Name = "patron2";
            this.patron2.Size = new System.Drawing.Size(39, 23);
            this.patron2.TabIndex = 19;
            this.patron2.Text = "->";
            this.patron2.UseVisualStyleBackColor = true;
            this.patron2.Click += new System.EventHandler(this.Patron2_Click);
            // 
            // patron1
            // 
            this.patron1.Location = new System.Drawing.Point(161, 79);
            this.patron1.Name = "patron1";
            this.patron1.Size = new System.Drawing.Size(39, 23);
            this.patron1.TabIndex = 18;
            this.patron1.Text = "->";
            this.patron1.UseVisualStyleBackColor = true;
            this.patron1.Click += new System.EventHandler(this.Patron1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(129, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "D";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(62, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "X2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "X1";
            // 
            // txtD4
            // 
            this.txtD4.Location = new System.Drawing.Point(118, 159);
            this.txtD4.Name = "txtD4";
            this.txtD4.ReadOnly = true;
            this.txtD4.Size = new System.Drawing.Size(37, 20);
            this.txtD4.TabIndex = 14;
            this.txtD4.Text = "0";
            // 
            // txtD3
            // 
            this.txtD3.Location = new System.Drawing.Point(118, 133);
            this.txtD3.Name = "txtD3";
            this.txtD3.ReadOnly = true;
            this.txtD3.Size = new System.Drawing.Size(37, 20);
            this.txtD3.TabIndex = 13;
            this.txtD3.Text = "0";
            // 
            // txtD2
            // 
            this.txtD2.Location = new System.Drawing.Point(118, 107);
            this.txtD2.Name = "txtD2";
            this.txtD2.ReadOnly = true;
            this.txtD2.Size = new System.Drawing.Size(37, 20);
            this.txtD2.TabIndex = 12;
            this.txtD2.Text = "0";
            // 
            // txtD1
            // 
            this.txtD1.Location = new System.Drawing.Point(118, 81);
            this.txtD1.Name = "txtD1";
            this.txtD1.ReadOnly = true;
            this.txtD1.Size = new System.Drawing.Size(37, 20);
            this.txtD1.TabIndex = 11;
            this.txtD1.Text = "1";
            // 
            // txtX42
            // 
            this.txtX42.Location = new System.Drawing.Point(54, 159);
            this.txtX42.Name = "txtX42";
            this.txtX42.ReadOnly = true;
            this.txtX42.Size = new System.Drawing.Size(37, 20);
            this.txtX42.TabIndex = 10;
            this.txtX42.Text = "0";
            // 
            // txtX32
            // 
            this.txtX32.Location = new System.Drawing.Point(54, 133);
            this.txtX32.Name = "txtX32";
            this.txtX32.ReadOnly = true;
            this.txtX32.Size = new System.Drawing.Size(37, 20);
            this.txtX32.TabIndex = 9;
            this.txtX32.Text = "1";
            // 
            // txtX22
            // 
            this.txtX22.Location = new System.Drawing.Point(54, 107);
            this.txtX22.Name = "txtX22";
            this.txtX22.ReadOnly = true;
            this.txtX22.Size = new System.Drawing.Size(37, 20);
            this.txtX22.TabIndex = 8;
            this.txtX22.Text = "0";
            // 
            // txtX12
            // 
            this.txtX12.Location = new System.Drawing.Point(54, 81);
            this.txtX12.Name = "txtX12";
            this.txtX12.ReadOnly = true;
            this.txtX12.Size = new System.Drawing.Size(37, 20);
            this.txtX12.TabIndex = 7;
            this.txtX12.Text = "1";
            // 
            // txtX41
            // 
            this.txtX41.Location = new System.Drawing.Point(11, 159);
            this.txtX41.Name = "txtX41";
            this.txtX41.ReadOnly = true;
            this.txtX41.Size = new System.Drawing.Size(37, 20);
            this.txtX41.TabIndex = 6;
            this.txtX41.Text = "0";
            // 
            // txtX31
            // 
            this.txtX31.Location = new System.Drawing.Point(11, 133);
            this.txtX31.Name = "txtX31";
            this.txtX31.ReadOnly = true;
            this.txtX31.Size = new System.Drawing.Size(37, 20);
            this.txtX31.TabIndex = 5;
            this.txtX31.Text = "0";
            // 
            // txtX21
            // 
            this.txtX21.Location = new System.Drawing.Point(11, 107);
            this.txtX21.Name = "txtX21";
            this.txtX21.ReadOnly = true;
            this.txtX21.Size = new System.Drawing.Size(37, 20);
            this.txtX21.TabIndex = 4;
            this.txtX21.Text = "1";
            // 
            // txtX11
            // 
            this.txtX11.Location = new System.Drawing.Point(11, 81);
            this.txtX11.Name = "txtX11";
            this.txtX11.ReadOnly = true;
            this.txtX11.Size = new System.Drawing.Size(37, 20);
            this.txtX11.TabIndex = 3;
            this.txtX11.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SALIDA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ENTRADAS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "COMPUERTA AND";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Entrenamiento);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtBoxY);
            this.groupBox2.Controls.Add(this.txtBoxD);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtBoxFactor);
            this.groupBox2.Controls.Add(this.txtBoxBias);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtBoxSuma);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtBoxW2);
            this.groupBox2.Controls.Add(this.txtBoxX2);
            this.groupBox2.Controls.Add(this.txtBoxW1);
            this.groupBox2.Controls.Add(this.txtBoxX1);
            this.groupBox2.Location = new System.Drawing.Point(263, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 207);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Perceptron";
            this.groupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // Entrenamiento
            // 
            this.Entrenamiento.Location = new System.Drawing.Point(261, 178);
            this.Entrenamiento.Name = "Entrenamiento";
            this.Entrenamiento.Size = new System.Drawing.Size(85, 23);
            this.Entrenamiento.TabIndex = 26;
            this.Entrenamiento.Text = "Entrenamiento";
            this.Entrenamiento.UseVisualStyleBackColor = true;
            this.Entrenamiento.Click += new System.EventHandler(this.Entrenamiento_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(258, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Y";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(258, 68);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "D";
            // 
            // txtBoxY
            // 
            this.txtBoxY.Location = new System.Drawing.Point(284, 91);
            this.txtBoxY.Name = "txtBoxY";
            this.txtBoxY.ReadOnly = true;
            this.txtBoxY.Size = new System.Drawing.Size(37, 20);
            this.txtBoxY.TabIndex = 23;
            // 
            // txtBoxD
            // 
            this.txtBoxD.Location = new System.Drawing.Point(284, 65);
            this.txtBoxD.Name = "txtBoxD";
            this.txtBoxD.ReadOnly = true;
            this.txtBoxD.Size = new System.Drawing.Size(37, 20);
            this.txtBoxD.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(171, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "η";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(171, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "θ";
            // 
            // txtBoxFactor
            // 
            this.txtBoxFactor.Location = new System.Drawing.Point(169, 175);
            this.txtBoxFactor.Name = "txtBoxFactor";
            this.txtBoxFactor.ReadOnly = true;
            this.txtBoxFactor.Size = new System.Drawing.Size(37, 20);
            this.txtBoxFactor.TabIndex = 19;
            this.txtBoxFactor.Text = ".25";
            // 
            // txtBoxBias
            // 
            this.txtBoxBias.Location = new System.Drawing.Point(169, 136);
            this.txtBoxBias.Name = "txtBoxBias";
            this.txtBoxBias.ReadOnly = true;
            this.txtBoxBias.Size = new System.Drawing.Size(37, 20);
            this.txtBoxBias.TabIndex = 18;
            this.txtBoxBias.Text = ".24";
            this.txtBoxBias.TextChanged += new System.EventHandler(this.TxtBoxBias_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(166, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "F(x)";
            // 
            // txtBoxSuma
            // 
            this.txtBoxSuma.Location = new System.Drawing.Point(169, 81);
            this.txtBoxSuma.Name = "txtBoxSuma";
            this.txtBoxSuma.ReadOnly = true;
            this.txtBoxSuma.Size = new System.Drawing.Size(37, 20);
            this.txtBoxSuma.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "W2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "X2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "W1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "X1";
            // 
            // txtBoxW2
            // 
            this.txtBoxW2.Location = new System.Drawing.Point(84, 118);
            this.txtBoxW2.Name = "txtBoxW2";
            this.txtBoxW2.ReadOnly = true;
            this.txtBoxW2.Size = new System.Drawing.Size(37, 20);
            this.txtBoxW2.TabIndex = 11;
            this.txtBoxW2.Text = ".2";
            // 
            // txtBoxX2
            // 
            this.txtBoxX2.Location = new System.Drawing.Point(41, 118);
            this.txtBoxX2.Name = "txtBoxX2";
            this.txtBoxX2.ReadOnly = true;
            this.txtBoxX2.Size = new System.Drawing.Size(37, 20);
            this.txtBoxX2.TabIndex = 10;
            // 
            // txtBoxW1
            // 
            this.txtBoxW1.Location = new System.Drawing.Point(84, 55);
            this.txtBoxW1.Name = "txtBoxW1";
            this.txtBoxW1.ReadOnly = true;
            this.txtBoxW1.Size = new System.Drawing.Size(37, 20);
            this.txtBoxW1.TabIndex = 9;
            this.txtBoxW1.Text = ".5";
            // 
            // txtBoxX1
            // 
            this.txtBoxX1.Location = new System.Drawing.Point(41, 55);
            this.txtBoxX1.Name = "txtBoxX1";
            this.txtBoxX1.ReadOnly = true;
            this.txtBoxX1.Size = new System.Drawing.Size(37, 20);
            this.txtBoxX1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 251);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(702, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Actualizar);
            this.groupBox3.Controls.Add(this.txtNBias);
            this.groupBox3.Controls.Add(this.txtNW2);
            this.groupBox3.Controls.Add(this.txtNW1);
            this.groupBox3.Controls.Add(this.txtDelta2);
            this.groupBox3.Controls.Add(this.txtDelta1);
            this.groupBox3.Controls.Add(this.txtError);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Location = new System.Drawing.Point(651, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(193, 207);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Calculo errores";
            // 
            // Actualizar
            // 
            this.Actualizar.Location = new System.Drawing.Point(74, 178);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(75, 23);
            this.Actualizar.TabIndex = 12;
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.UseVisualStyleBackColor = true;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // txtNBias
            // 
            this.txtNBias.Location = new System.Drawing.Point(121, 146);
            this.txtNBias.Name = "txtNBias";
            this.txtNBias.ReadOnly = true;
            this.txtNBias.Size = new System.Drawing.Size(66, 20);
            this.txtNBias.TabIndex = 11;
            // 
            // txtNW2
            // 
            this.txtNW2.Location = new System.Drawing.Point(121, 120);
            this.txtNW2.Name = "txtNW2";
            this.txtNW2.ReadOnly = true;
            this.txtNW2.Size = new System.Drawing.Size(66, 20);
            this.txtNW2.TabIndex = 10;
            // 
            // txtNW1
            // 
            this.txtNW1.Location = new System.Drawing.Point(121, 94);
            this.txtNW1.Name = "txtNW1";
            this.txtNW1.ReadOnly = true;
            this.txtNW1.Size = new System.Drawing.Size(66, 20);
            this.txtNW1.TabIndex = 9;
            // 
            // txtDelta2
            // 
            this.txtDelta2.Location = new System.Drawing.Point(121, 68);
            this.txtDelta2.Name = "txtDelta2";
            this.txtDelta2.ReadOnly = true;
            this.txtDelta2.Size = new System.Drawing.Size(66, 20);
            this.txtDelta2.TabIndex = 8;
            // 
            // txtDelta1
            // 
            this.txtDelta1.Location = new System.Drawing.Point(121, 42);
            this.txtDelta1.Name = "txtDelta1";
            this.txtDelta1.ReadOnly = true;
            this.txtDelta1.Size = new System.Drawing.Size(66, 20);
            this.txtDelta1.TabIndex = 7;
            // 
            // txtError
            // 
            this.txtError.Location = new System.Drawing.Point(121, 16);
            this.txtError.Name = "txtError";
            this.txtError.ReadOnly = true;
            this.txtError.Size = new System.Drawing.Size(66, 20);
            this.txtError.TabIndex = 6;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(54, 149);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(61, 13);
            this.label21.TabIndex = 5;
            this.label21.Text = "θ = θ - ηδ =";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(59, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "δ = D - Y =";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(46, 71);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "Δ2  = ηδX2 =";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(28, 123);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(87, 13);
            this.label20.TabIndex = 4;
            this.label20.Text = "W2 = W2 + Δ2 =";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(46, 45);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Δ1  = ηδX1 =";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(28, 97);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(87, 13);
            this.label19.TabIndex = 3;
            this.label19.Text = "W1 = W1 + Δ1 =";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(769, 292);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Salir";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 327);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtD4;
        private System.Windows.Forms.TextBox txtD3;
        private System.Windows.Forms.TextBox txtD2;
        private System.Windows.Forms.TextBox txtD1;
        private System.Windows.Forms.TextBox txtX42;
        private System.Windows.Forms.TextBox txtX32;
        private System.Windows.Forms.TextBox txtX22;
        private System.Windows.Forms.TextBox txtX12;
        private System.Windows.Forms.TextBox txtX41;
        private System.Windows.Forms.TextBox txtX31;
        private System.Windows.Forms.TextBox txtX21;
        private System.Windows.Forms.TextBox txtX11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtBoxY;
        private System.Windows.Forms.TextBox txtBoxD;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBoxFactor;
        private System.Windows.Forms.TextBox txtBoxBias;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxSuma;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxW2;
        private System.Windows.Forms.TextBox txtBoxX2;
        private System.Windows.Forms.TextBox txtBoxW1;
        private System.Windows.Forms.TextBox txtBoxX1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNBias;
        private System.Windows.Forms.TextBox txtNW2;
        private System.Windows.Forms.TextBox txtNW1;
        private System.Windows.Forms.TextBox txtDelta2;
        private System.Windows.Forms.TextBox txtDelta1;
        private System.Windows.Forms.TextBox txtError;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button patron4;
        private System.Windows.Forms.Button patron3;
        private System.Windows.Forms.Button patron2;
        private System.Windows.Forms.Button patron1;
        private System.Windows.Forms.Button Entrenamiento;
        private System.Windows.Forms.Button Actualizar;
        private System.Windows.Forms.Button Exit;
    }
}

