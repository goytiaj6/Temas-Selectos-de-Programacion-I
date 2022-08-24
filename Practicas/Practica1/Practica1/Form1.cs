using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            button1.Text = "Hola mundo paralelo";
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Task<string> task = new Task<string>(Solicitud);
            task.Start();

            button1.Text = await task;
            
        }

        private string Solicitud()
        {
            Thread.Sleep(10000);
            MessageBox.Show("termine");
            return "Termine solicitud";
        }
    }
}
