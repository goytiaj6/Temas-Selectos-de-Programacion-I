
namespace Coulomb1
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
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.q1 = new System.Windows.Forms.Label();
            this.q2 = new System.Windows.Forms.Label();
            this.q3 = new System.Windows.Forms.Label();
            this.Resultado = new System.Windows.Forms.Label();
            this.bttnCalcular = new System.Windows.Forms.Button();
            this.bttnReset = new System.Windows.Forms.Button();
            this.bttnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtboxq1 = new System.Windows.Forms.TextBox();
            this.txtboxq2 = new System.Windows.Forms.TextBox();
            this.txtboxq3 = new System.Windows.Forms.TextBox();
            this.txtboxdist = new System.Windows.Forms.TextBox();
            this.txtboxFr = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora de fuerzas electroestáticas equidistantes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(267, 49);
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
            this.chart1.Size = new System.Drawing.Size(445, 256);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // q1
            // 
            this.q1.AutoSize = true;
            this.q1.Location = new System.Drawing.Point(68, 82);
            this.q1.Name = "q1";
            this.q1.Size = new System.Drawing.Size(53, 13);
            this.q1.TabIndex = 10;
            this.q1.Text = "Carga q1:";
            // 
            // q2
            // 
            this.q2.AutoSize = true;
            this.q2.Location = new System.Drawing.Point(68, 108);
            this.q2.Name = "q2";
            this.q2.Size = new System.Drawing.Size(53, 13);
            this.q2.TabIndex = 11;
            this.q2.Text = "Carga q2:";
            // 
            // q3
            // 
            this.q3.AutoSize = true;
            this.q3.Location = new System.Drawing.Point(68, 134);
            this.q3.Name = "q3";
            this.q3.Size = new System.Drawing.Size(53, 13);
            this.q3.TabIndex = 12;
            this.q3.Text = "Carga q3:";
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Location = new System.Drawing.Point(30, 187);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(91, 13);
            this.Resultado.TabIndex = 13;
            this.Resultado.Text = "Fuerza resultante:";
            // 
            // bttnCalcular
            // 
            this.bttnCalcular.Location = new System.Drawing.Point(32, 229);
            this.bttnCalcular.Name = "bttnCalcular";
            this.bttnCalcular.Size = new System.Drawing.Size(75, 23);
            this.bttnCalcular.TabIndex = 15;
            this.bttnCalcular.Text = "Calcular";
            this.bttnCalcular.UseVisualStyleBackColor = true;
            this.bttnCalcular.Click += new System.EventHandler(this.bttnCalcular_Click);
            // 
            // bttnReset
            // 
            this.bttnReset.Location = new System.Drawing.Point(169, 229);
            this.bttnReset.Name = "bttnReset";
            this.bttnReset.Size = new System.Drawing.Size(75, 23);
            this.bttnReset.TabIndex = 16;
            this.bttnReset.Text = "Reiniciar";
            this.bttnReset.UseVisualStyleBackColor = true;
            this.bttnReset.Click += new System.EventHandler(this.bttnReset_Click);
            // 
            // bttnExit
            // 
            this.bttnExit.Location = new System.Drawing.Point(99, 274);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(75, 23);
            this.bttnExit.TabIndex = 17;
            this.bttnExit.Text = "Salir";
            this.bttnExit.UseVisualStyleBackColor = true;
            this.bttnExit.Click += new System.EventHandler(this.bttnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ingrese los datos (cargas en uC y distancia en mm):";
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Location = new System.Drawing.Point(68, 160);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(54, 13);
            this.d.TabIndex = 20;
            this.d.Text = "Distancia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "NOTA: Se emplean cargas de mismo signo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(233, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "[N]";
            // 
            // txtboxq1
            // 
            this.txtboxq1.Location = new System.Drawing.Point(127, 79);
            this.txtboxq1.Name = "txtboxq1";
            this.txtboxq1.Size = new System.Drawing.Size(100, 20);
            this.txtboxq1.TabIndex = 53;
            // 
            // txtboxq2
            // 
            this.txtboxq2.Location = new System.Drawing.Point(127, 105);
            this.txtboxq2.Name = "txtboxq2";
            this.txtboxq2.Size = new System.Drawing.Size(100, 20);
            this.txtboxq2.TabIndex = 54;
            // 
            // txtboxq3
            // 
            this.txtboxq3.Location = new System.Drawing.Point(127, 131);
            this.txtboxq3.Name = "txtboxq3";
            this.txtboxq3.Size = new System.Drawing.Size(100, 20);
            this.txtboxq3.TabIndex = 55;
            // 
            // txtboxdist
            // 
            this.txtboxdist.Location = new System.Drawing.Point(127, 157);
            this.txtboxdist.Name = "txtboxdist";
            this.txtboxdist.Size = new System.Drawing.Size(100, 20);
            this.txtboxdist.TabIndex = 56;
            // 
            // txtboxFr
            // 
            this.txtboxFr.Location = new System.Drawing.Point(127, 184);
            this.txtboxFr.Name = "txtboxFr";
            this.txtboxFr.ReadOnly = true;
            this.txtboxFr.Size = new System.Drawing.Size(100, 20);
            this.txtboxFr.TabIndex = 57;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 335);
            this.Controls.Add(this.txtboxFr);
            this.Controls.Add(this.txtboxdist);
            this.Controls.Add(this.txtboxq3);
            this.Controls.Add(this.txtboxq2);
            this.Controls.Add(this.txtboxq1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.d);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttnExit);
            this.Controls.Add(this.bttnReset);
            this.Controls.Add(this.bttnCalcular);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.q3);
            this.Controls.Add(this.q2);
            this.Controls.Add(this.q1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ley de Coulomb 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label q1;
        private System.Windows.Forms.Label q2;
        private System.Windows.Forms.Label q3;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.Button bttnCalcular;
        private System.Windows.Forms.Button bttnReset;
        private System.Windows.Forms.Button bttnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtboxq1;
        private System.Windows.Forms.TextBox txtboxq2;
        private System.Windows.Forms.TextBox txtboxq3;
        private System.Windows.Forms.TextBox txtboxdist;
        private System.Windows.Forms.TextBox txtboxFr;
    }
}

