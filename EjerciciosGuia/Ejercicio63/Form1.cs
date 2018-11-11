using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Ejercicio63
{
    public partial class Form1 : Form
    {
        private Thread t;

        public Form1()
        {
            t = new Thread(Contador);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t.Start();
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            Contador();
        }

        private void Contador()
        {
            while (true)
            {
                if (this.label1.InvokeRequired)
                {
                    this.label1.BeginInvoke((MethodInvoker)delegate ()
                    {
                        label1.Text = DateTime.Now.ToString();
                    }
                    );
                }
                else
                {
                    label1.Text = DateTime.Now.ToString();
                }

                Thread.Sleep(1000);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Abort();
        }

    }

}
