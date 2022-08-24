
namespace Coulomb_2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label2 = new System.Windows.Forms.Label();
            this.bttnExit = new System.Windows.Forms.Button();
            this.bttnReset = new System.Windows.Forms.Button();
            this.bttnCalcular = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxQ1 = new System.Windows.Forms.TextBox();
            this.textBoxQ2 = new System.Windows.Forms.TextBox();
            this.textBoxQ3 = new System.Windows.Forms.TextBox();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.TextBoxFr = new System.Windows.Forms.TextBox();
            this.Resultado = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Ingrese los datos (cargas en uC y distancia en mm):";
            // 
            // bttnExit
            // 
            this.bttnExit.Location = new System.Drawing.Point(120, 296);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(75, 23);
            this.bttnExit.TabIndex = 32;
            this.bttnExit.Text = "Salir";
            this.bttnExit.UseVisualStyleBackColor = true;
            this.bttnExit.Click += new System.EventHandler(this.bttnExit_Click);
            // 
            // bttnReset
            // 
            this.bttnReset.Location = new System.Drawing.Point(190, 251);
            this.bttnReset.Name = "bttnReset";
            this.bttnReset.Size = new System.Drawing.Size(75, 23);
            this.bttnReset.TabIndex = 31;
            this.bttnReset.Text = "Reiniciar";
            this.bttnReset.UseVisualStyleBackColor = true;
            this.bttnReset.Click += new System.EventHandler(this.bttnReset_Click);
            // 
            // bttnCalcular
            // 
            this.bttnCalcular.Location = new System.Drawing.Point(53, 251);
            this.bttnCalcular.Name = "bttnCalcular";
            this.bttnCalcular.Size = new System.Drawing.Size(75, 23);
            this.bttnCalcular.TabIndex = 30;
            this.bttnCalcular.Text = "Calcular";
            this.bttnCalcular.UseVisualStyleBackColor = true;
            this.bttnCalcular.Click += new System.EventHandler(this.bttnCalcular_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(286, 53);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.MarkerSize = 15;
            series1.Name = "Carga q1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.MarkerSize = 15;
            series2.Name = "Carga q2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Legend = "Legend1";
            series3.MarkerSize = 15;
            series3.Name = "Carga q3";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(505, 300);
            this.chart1.TabIndex = 36;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Calculadora de fuerzas electroestáticas dadas dos distancias";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Carga q1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Carga q2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Carga q3:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Distancia entre q1 y q2 (d):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Distancia entre q1 y q3 (r):";
            // 
            // textBoxQ1
            // 
            this.textBoxQ1.Location = new System.Drawing.Point(152, 74);
            this.textBoxQ1.Name = "textBoxQ1";
            this.textBoxQ1.Size = new System.Drawing.Size(100, 20);
            this.textBoxQ1.TabIndex = 43;
            // 
            // textBoxQ2
            // 
            this.textBoxQ2.Location = new System.Drawing.Point(152, 100);
            this.textBoxQ2.Name = "textBoxQ2";
            this.textBoxQ2.Size = new System.Drawing.Size(100, 20);
            this.textBoxQ2.TabIndex = 44;
            // 
            // textBoxQ3
            // 
            this.textBoxQ3.Location = new System.Drawing.Point(152, 126);
            this.textBoxQ3.Name = "textBoxQ3";
            this.textBoxQ3.Size = new System.Drawing.Size(100, 20);
            this.textBoxQ3.TabIndex = 45;
            // 
            // textBoxD
            // 
            this.textBoxD.Location = new System.Drawing.Point(152, 152);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(100, 20);
            this.textBoxD.TabIndex = 46;
            // 
            // textBoxR
            // 
            this.textBoxR.Location = new System.Drawing.Point(152, 178);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(100, 20);
            this.textBoxR.TabIndex = 47;
            // 
            // TextBoxFr
            // 
            this.TextBoxFr.Enabled = false;
            this.TextBoxFr.Location = new System.Drawing.Point(152, 204);
            this.TextBoxFr.Name = "TextBoxFr";
            this.TextBoxFr.Size = new System.Drawing.Size(100, 20);
            this.TextBoxFr.TabIndex = 49;
            this.TextBoxFr.Visible = false;
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Location = new System.Drawing.Point(55, 207);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(91, 13);
            this.Resultado.TabIndex = 48;
            this.Resultado.Text = "Fuerza resultante:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "NOTA: Se emplean cargas de mismo signo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(258, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "[N]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 365);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TextBoxFr);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.textBoxD);
            this.Controls.Add(this.textBoxQ3);
            this.Controls.Add(this.textBoxQ2);
            this.Controls.Add(this.textBoxQ1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttnExit);
            this.Controls.Add(this.bttnReset);
            this.Controls.Add(this.bttnCalcular);
            this.Name = "Form1";
            this.Text = "Ley de Coulomb 2";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bttnExit;
        private System.Windows.Forms.Button bttnReset;
        private System.Windows.Forms.Button bttnCalcular;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxQ1;
        private System.Windows.Forms.TextBox textBoxQ2;
        private System.Windows.Forms.TextBox textBoxQ3;
        private System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.TextBox TextBoxFr;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

