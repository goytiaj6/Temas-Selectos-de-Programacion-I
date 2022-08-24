
namespace Coulomb___Curva_Error_y_pendiente
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bttnCalcular = new System.Windows.Forms.Button();
            this.bttnClear = new System.Windows.Forms.Button();
            this.bttnExit = new System.Windows.Forms.Button();
            this.txtBoxQ1 = new System.Windows.Forms.TextBox();
            this.txtBoxQ2 = new System.Windows.Forms.TextBox();
            this.txtBoxQ3 = new System.Windows.Forms.TextBox();
            this.txtBoxDeseado = new System.Windows.Forms.TextBox();
            this.txtBoxD = new System.Windows.Forms.TextBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barrido de cargas electroestáticas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Carga Q1 (uC):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Carga Q2 (uC):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Carga Q3 (uC):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Valor deseado (N):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Distancia entre Q1 y Q2 (m):";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(264, 12);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.MarkerColor = System.Drawing.Color.Red;
            series1.Name = "ECM";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(391, 224);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            // 
            // bttnCalcular
            // 
            this.bttnCalcular.Location = new System.Drawing.Point(102, 262);
            this.bttnCalcular.Name = "bttnCalcular";
            this.bttnCalcular.Size = new System.Drawing.Size(75, 23);
            this.bttnCalcular.TabIndex = 12;
            this.bttnCalcular.Text = "Calcular";
            this.bttnCalcular.UseVisualStyleBackColor = true;
            this.bttnCalcular.Click += new System.EventHandler(this.BttnCalcular_Click);
            // 
            // bttnClear
            // 
            this.bttnClear.Location = new System.Drawing.Point(102, 291);
            this.bttnClear.Name = "bttnClear";
            this.bttnClear.Size = new System.Drawing.Size(75, 23);
            this.bttnClear.TabIndex = 13;
            this.bttnClear.Text = "Limpiar";
            this.bttnClear.UseVisualStyleBackColor = true;
            this.bttnClear.Click += new System.EventHandler(this.BttnClear_Click);
            // 
            // bttnExit
            // 
            this.bttnExit.Location = new System.Drawing.Point(102, 320);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(75, 23);
            this.bttnExit.TabIndex = 14;
            this.bttnExit.Text = "Salir";
            this.bttnExit.UseVisualStyleBackColor = true;
            this.bttnExit.Click += new System.EventHandler(this.BttnExit_Click);
            // 
            // txtBoxQ1
            // 
            this.txtBoxQ1.Location = new System.Drawing.Point(158, 112);
            this.txtBoxQ1.Name = "txtBoxQ1";
            this.txtBoxQ1.Size = new System.Drawing.Size(100, 20);
            this.txtBoxQ1.TabIndex = 15;
            // 
            // txtBoxQ2
            // 
            this.txtBoxQ2.Location = new System.Drawing.Point(158, 138);
            this.txtBoxQ2.Name = "txtBoxQ2";
            this.txtBoxQ2.Size = new System.Drawing.Size(100, 20);
            this.txtBoxQ2.TabIndex = 16;
            // 
            // txtBoxQ3
            // 
            this.txtBoxQ3.Location = new System.Drawing.Point(158, 164);
            this.txtBoxQ3.Name = "txtBoxQ3";
            this.txtBoxQ3.Size = new System.Drawing.Size(100, 20);
            this.txtBoxQ3.TabIndex = 17;
            // 
            // txtBoxDeseado
            // 
            this.txtBoxDeseado.Location = new System.Drawing.Point(158, 190);
            this.txtBoxDeseado.Name = "txtBoxDeseado";
            this.txtBoxDeseado.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDeseado.TabIndex = 18;
            // 
            // txtBoxD
            // 
            this.txtBoxD.Location = new System.Drawing.Point(158, 216);
            this.txtBoxD.Name = "txtBoxD";
            this.txtBoxD.Size = new System.Drawing.Size(100, 20);
            this.txtBoxD.TabIndex = 19;
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(264, 242);
            this.chart2.Name = "chart2";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Blue;
            series2.Legend = "Legend1";
            series2.MarkerColor = System.Drawing.Color.Red;
            series2.Name = "Pendiente";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(391, 224);
            this.chart2.TabIndex = 20;
            this.chart2.Text = "chart2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 478);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.txtBoxD);
            this.Controls.Add(this.txtBoxDeseado);
            this.Controls.Add(this.txtBoxQ3);
            this.Controls.Add(this.txtBoxQ2);
            this.Controls.Add(this.txtBoxQ1);
            this.Controls.Add(this.bttnExit);
            this.Controls.Add(this.bttnClear);
            this.Controls.Add(this.bttnCalcular);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button bttnCalcular;
        private System.Windows.Forms.Button bttnClear;
        private System.Windows.Forms.Button bttnExit;
        private System.Windows.Forms.TextBox txtBoxQ1;
        private System.Windows.Forms.TextBox txtBoxQ2;
        private System.Windows.Forms.TextBox txtBoxQ3;
        private System.Windows.Forms.TextBox txtBoxDeseado;
        private System.Windows.Forms.TextBox txtBoxD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}