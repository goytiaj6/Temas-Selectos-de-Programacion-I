
namespace DistribucionNormal
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtEspaciado = new System.Windows.Forms.TextBox();
            this.bttnGrafica = new System.Windows.Forms.Button();
            this.bttnClear = new System.Windows.Forms.Button();
            this.bttnExit = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLikelihood = new System.Windows.Forms.TextBox();
            this.bttnLikelihood = new System.Windows.Forms.Button();
            this.txtLike2 = new System.Windows.Forms.TextBox();
            this.txtLike1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Espaciado de los datos: ";
            // 
            // txtEspaciado
            // 
            this.txtEspaciado.Location = new System.Drawing.Point(135, 46);
            this.txtEspaciado.Name = "txtEspaciado";
            this.txtEspaciado.Size = new System.Drawing.Size(100, 20);
            this.txtEspaciado.TabIndex = 5;
            // 
            // bttnGrafica
            // 
            this.bttnGrafica.Location = new System.Drawing.Point(12, 88);
            this.bttnGrafica.Name = "bttnGrafica";
            this.bttnGrafica.Size = new System.Drawing.Size(117, 96);
            this.bttnGrafica.TabIndex = 6;
            this.bttnGrafica.Text = "Graficar distribución";
            this.bttnGrafica.UseVisualStyleBackColor = true;
            this.bttnGrafica.Click += new System.EventHandler(this.BttnGrafica_Click);
            // 
            // bttnClear
            // 
            this.bttnClear.Location = new System.Drawing.Point(135, 88);
            this.bttnClear.Name = "bttnClear";
            this.bttnClear.Size = new System.Drawing.Size(100, 45);
            this.bttnClear.TabIndex = 7;
            this.bttnClear.Text = "Limpiar campos";
            this.bttnClear.UseVisualStyleBackColor = true;
            this.bttnClear.Click += new System.EventHandler(this.BttnClear_Click);
            // 
            // bttnExit
            // 
            this.bttnExit.Location = new System.Drawing.Point(135, 139);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(100, 45);
            this.bttnExit.TabIndex = 8;
            this.bttnExit.Text = "Salir";
            this.bttnExit.UseVisualStyleBackColor = true;
            this.bttnExit.Click += new System.EventHandler(this.BttnExit_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(241, 12);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.MarkerColor = System.Drawing.Color.White;
            series1.Name = "F1(x)";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Blue;
            series2.Legend = "Legend1";
            series2.Name = "F2(x)";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(733, 292);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Likelihood de un valor: ";
            // 
            // txtLikelihood
            // 
            this.txtLikelihood.Location = new System.Drawing.Point(135, 214);
            this.txtLikelihood.Name = "txtLikelihood";
            this.txtLikelihood.Size = new System.Drawing.Size(100, 20);
            this.txtLikelihood.TabIndex = 11;
            // 
            // bttnLikelihood
            // 
            this.bttnLikelihood.Location = new System.Drawing.Point(15, 260);
            this.bttnLikelihood.Name = "bttnLikelihood";
            this.bttnLikelihood.Size = new System.Drawing.Size(100, 27);
            this.bttnLikelihood.TabIndex = 12;
            this.bttnLikelihood.Text = "Likelihood";
            this.bttnLikelihood.UseVisualStyleBackColor = true;
            this.bttnLikelihood.Click += new System.EventHandler(this.BttnLikelihood_Click);
            // 
            // txtLike2
            // 
            this.txtLike2.Location = new System.Drawing.Point(135, 277);
            this.txtLike2.Name = "txtLike2";
            this.txtLike2.ReadOnly = true;
            this.txtLike2.Size = new System.Drawing.Size(100, 20);
            this.txtLike2.TabIndex = 14;
            // 
            // txtLike1
            // 
            this.txtLike1.Location = new System.Drawing.Point(135, 251);
            this.txtLike1.Name = "txtLike1";
            this.txtLike1.ReadOnly = true;
            this.txtLike1.Size = new System.Drawing.Size(100, 20);
            this.txtLike1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 310);
            this.Controls.Add(this.txtLike1);
            this.Controls.Add(this.txtLike2);
            this.Controls.Add(this.bttnLikelihood);
            this.Controls.Add(this.txtLikelihood);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.bttnExit);
            this.Controls.Add(this.bttnClear);
            this.Controls.Add(this.bttnGrafica);
            this.Controls.Add(this.txtEspaciado);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Distribucion Normal";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEspaciado;
        private System.Windows.Forms.Button bttnGrafica;
        private System.Windows.Forms.Button bttnClear;
        private System.Windows.Forms.Button bttnExit;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLikelihood;
        private System.Windows.Forms.Button bttnLikelihood;
        private System.Windows.Forms.TextBox txtLike2;
        private System.Windows.Forms.TextBox txtLike1;
    }
}

