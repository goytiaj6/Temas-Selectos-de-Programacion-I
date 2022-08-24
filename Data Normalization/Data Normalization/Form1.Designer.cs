
namespace Data_Normalization
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bttnShowXLXS = new System.Windows.Forms.Button();
            this.bttnSearchXLSX = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pathXLSX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bttnTesting = new System.Windows.Forms.Button();
            this.ClassPredicted = new System.Windows.Forms.TextBox();
            this.PW = new System.Windows.Forms.TextBox();
            this.PL = new System.Windows.Forms.TextBox();
            this.SW = new System.Windows.Forms.TextBox();
            this.SP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bttnNormalize = new System.Windows.Forms.Button();
            this.bttnSearchOCSV = new System.Windows.Forms.Button();
            this.bttnSearchNCSV = new System.Windows.Forms.Button();
            this.bttnTrain = new System.Windows.Forms.Button();
            this.pathNCSV = new System.Windows.Forms.TextBox();
            this.pathOCSV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bttnExit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(11, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(611, 391);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bttnShowXLXS);
            this.tabPage1.Controls.Add(this.bttnSearchXLSX);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.pathXLSX);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(603, 365);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Original Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bttnShowXLXS
            // 
            this.bttnShowXLXS.Location = new System.Drawing.Point(400, 177);
            this.bttnShowXLXS.Margin = new System.Windows.Forms.Padding(2);
            this.bttnShowXLXS.Name = "bttnShowXLXS";
            this.bttnShowXLXS.Size = new System.Drawing.Size(93, 24);
            this.bttnShowXLXS.TabIndex = 4;
            this.bttnShowXLXS.Text = "Show data";
            this.bttnShowXLXS.UseVisualStyleBackColor = true;
            this.bttnShowXLXS.Click += new System.EventHandler(this.BttnShowXLXS_Click);
            // 
            // bttnSearchXLSX
            // 
            this.bttnSearchXLSX.Location = new System.Drawing.Point(400, 7);
            this.bttnSearchXLSX.Margin = new System.Windows.Forms.Padding(2);
            this.bttnSearchXLSX.Name = "bttnSearchXLSX";
            this.bttnSearchXLSX.Size = new System.Drawing.Size(93, 24);
            this.bttnSearchXLSX.TabIndex = 3;
            this.bttnSearchXLSX.Text = "Search file";
            this.bttnSearchXLSX.UseVisualStyleBackColor = true;
            this.bttnSearchXLSX.Click += new System.EventHandler(this.BttnSearchXLSX_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 34);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(386, 327);
            this.dataGridView1.TabIndex = 2;
            // 
            // pathXLSX
            // 
            this.pathXLSX.Location = new System.Drawing.Point(96, 10);
            this.pathXLSX.Margin = new System.Windows.Forms.Padding(2);
            this.pathXLSX.Name = "pathXLSX";
            this.pathXLSX.ReadOnly = true;
            this.pathXLSX.Size = new System.Drawing.Size(300, 20);
            this.pathXLSX.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PATH (xlsx file): ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bttnExit);
            this.tabPage2.Controls.Add(this.bttnTesting);
            this.tabPage2.Controls.Add(this.ClassPredicted);
            this.tabPage2.Controls.Add(this.PW);
            this.tabPage2.Controls.Add(this.PL);
            this.tabPage2.Controls.Add(this.SW);
            this.tabPage2.Controls.Add(this.SP);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.bttnNormalize);
            this.tabPage2.Controls.Add(this.bttnSearchOCSV);
            this.tabPage2.Controls.Add(this.bttnSearchNCSV);
            this.tabPage2.Controls.Add(this.bttnTrain);
            this.tabPage2.Controls.Add(this.pathNCSV);
            this.tabPage2.Controls.Add(this.pathOCSV);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(603, 365);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Data normalization, training and testing";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bttnTesting
            // 
            this.bttnTesting.Location = new System.Drawing.Point(261, 276);
            this.bttnTesting.Name = "bttnTesting";
            this.bttnTesting.Size = new System.Drawing.Size(82, 38);
            this.bttnTesting.TabIndex = 29;
            this.bttnTesting.Text = "Test";
            this.bttnTesting.UseVisualStyleBackColor = true;
            this.bttnTesting.Click += new System.EventHandler(this.BttnTesting_Click);
            // 
            // ClassPredicted
            // 
            this.ClassPredicted.Location = new System.Drawing.Point(432, 205);
            this.ClassPredicted.Name = "ClassPredicted";
            this.ClassPredicted.ReadOnly = true;
            this.ClassPredicted.Size = new System.Drawing.Size(100, 20);
            this.ClassPredicted.TabIndex = 28;
            // 
            // PW
            // 
            this.PW.Location = new System.Drawing.Point(326, 205);
            this.PW.Name = "PW";
            this.PW.Size = new System.Drawing.Size(100, 20);
            this.PW.TabIndex = 27;
            // 
            // PL
            // 
            this.PL.Location = new System.Drawing.Point(220, 205);
            this.PL.Name = "PL";
            this.PL.Size = new System.Drawing.Size(100, 20);
            this.PL.TabIndex = 26;
            // 
            // SW
            // 
            this.SW.Location = new System.Drawing.Point(114, 205);
            this.SW.Name = "SW";
            this.SW.Size = new System.Drawing.Size(100, 20);
            this.SW.TabIndex = 25;
            // 
            // SP
            // 
            this.SP.Location = new System.Drawing.Point(8, 205);
            this.SP.Name = "SP";
            this.SP.Size = new System.Drawing.Size(100, 20);
            this.SP.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(500, 228);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Class";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Petal Width";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 228);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Petal Lenght ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 228);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Sepal Width";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 228);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Sepal Lenght ";
            // 
            // bttnNormalize
            // 
            this.bttnNormalize.Location = new System.Drawing.Point(194, 87);
            this.bttnNormalize.Margin = new System.Windows.Forms.Padding(2);
            this.bttnNormalize.Name = "bttnNormalize";
            this.bttnNormalize.Size = new System.Drawing.Size(93, 34);
            this.bttnNormalize.TabIndex = 12;
            this.bttnNormalize.Text = "Normalize data";
            this.bttnNormalize.UseVisualStyleBackColor = true;
            this.bttnNormalize.Click += new System.EventHandler(this.BttnNormalize_Click);
            // 
            // bttnSearchOCSV
            // 
            this.bttnSearchOCSV.Location = new System.Drawing.Point(467, 4);
            this.bttnSearchOCSV.Margin = new System.Windows.Forms.Padding(2);
            this.bttnSearchOCSV.Name = "bttnSearchOCSV";
            this.bttnSearchOCSV.Size = new System.Drawing.Size(93, 24);
            this.bttnSearchOCSV.TabIndex = 10;
            this.bttnSearchOCSV.Text = "Search file";
            this.bttnSearchOCSV.UseVisualStyleBackColor = true;
            this.bttnSearchOCSV.Click += new System.EventHandler(this.BttnSearchOCSV_Click);
            // 
            // bttnSearchNCSV
            // 
            this.bttnSearchNCSV.Location = new System.Drawing.Point(467, 32);
            this.bttnSearchNCSV.Margin = new System.Windows.Forms.Padding(2);
            this.bttnSearchNCSV.Name = "bttnSearchNCSV";
            this.bttnSearchNCSV.Size = new System.Drawing.Size(93, 24);
            this.bttnSearchNCSV.TabIndex = 9;
            this.bttnSearchNCSV.Text = "Search file";
            this.bttnSearchNCSV.UseVisualStyleBackColor = true;
            this.bttnSearchNCSV.Click += new System.EventHandler(this.BttnSearchNCSV_Click);
            // 
            // bttnTrain
            // 
            this.bttnTrain.Location = new System.Drawing.Point(333, 87);
            this.bttnTrain.Margin = new System.Windows.Forms.Padding(2);
            this.bttnTrain.Name = "bttnTrain";
            this.bttnTrain.Size = new System.Drawing.Size(93, 34);
            this.bttnTrain.TabIndex = 8;
            this.bttnTrain.Text = "Train network";
            this.bttnTrain.UseVisualStyleBackColor = true;
            this.bttnTrain.Click += new System.EventHandler(this.BttnTrain_Click);
            // 
            // pathNCSV
            // 
            this.pathNCSV.Location = new System.Drawing.Point(152, 35);
            this.pathNCSV.Margin = new System.Windows.Forms.Padding(2);
            this.pathNCSV.Name = "pathNCSV";
            this.pathNCSV.ReadOnly = true;
            this.pathNCSV.Size = new System.Drawing.Size(311, 20);
            this.pathNCSV.TabIndex = 5;
            // 
            // pathOCSV
            // 
            this.pathOCSV.Location = new System.Drawing.Point(152, 7);
            this.pathOCSV.Margin = new System.Windows.Forms.Padding(2);
            this.pathOCSV.Name = "pathOCSV";
            this.pathOCSV.ReadOnly = true;
            this.pathOCSV.Size = new System.Drawing.Size(311, 20);
            this.pathOCSV.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "PATH Normalized (CSV file): ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "PATH Oiginal (CSV file): ";
            // 
            // bttnExit
            // 
            this.bttnExit.Location = new System.Drawing.Point(523, 337);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(75, 23);
            this.bttnExit.TabIndex = 30;
            this.bttnExit.Text = "Exit";
            this.bttnExit.UseVisualStyleBackColor = true;
            this.bttnExit.Click += new System.EventHandler(this.BttnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 406);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button bttnShowXLXS;
        private System.Windows.Forms.Button bttnSearchXLSX;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox pathXLSX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bttnNormalize;
        private System.Windows.Forms.Button bttnSearchOCSV;
        private System.Windows.Forms.Button bttnSearchNCSV;
        private System.Windows.Forms.Button bttnTrain;
        private System.Windows.Forms.TextBox pathNCSV;
        private System.Windows.Forms.TextBox pathOCSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ClassPredicted;
        private System.Windows.Forms.TextBox PW;
        private System.Windows.Forms.TextBox PL;
        private System.Windows.Forms.TextBox SW;
        private System.Windows.Forms.TextBox SP;
        private System.Windows.Forms.Button bttnTesting;
        private System.Windows.Forms.Button bttnExit;
    }
}

