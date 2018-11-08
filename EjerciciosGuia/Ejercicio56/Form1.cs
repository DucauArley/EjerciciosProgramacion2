using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ejercicio56
{
    public partial class Form1 : Form
    {
        private string ruta = null;

        public Form1()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "0 caracteres";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void ContadorDeLetras()
        {
            StringBuilder str = new StringBuilder();

            str.Append(richTextBox1.Text.Length + " caracteres");

            toolStripStatusLabel1.Text = str.ToString();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ruta = open.FileName;

                    StreamReader str = new StreamReader(ruta);
                    richTextBox1.Text = str.ReadToEnd();

                    str.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ruta != null)
            {
                StreamWriter file = new StreamWriter(ruta);
                file.WriteLine(richTextBox1.Text);
                file.Close();
            }
            else
            {
                guardarComoToolStripMenuItem_Click(sender, e);
            }
            
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            if(save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ruta = save.FileName;

                    StreamWriter str = new StreamWriter(ruta);
                    str.Write(richTextBox1.Text);
                    str.Close();
                }
                catch(Exception ex)
                {
                    throw ex;
                }
                
            }
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            ContadorDeLetras();
        }
    }
}
