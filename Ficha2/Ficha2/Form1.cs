using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha2
{
    public partial class Form1 : Form
    {
        private DateTime contadorTempo;
        public Form1()
        {
            InitializeComponent();
            contadorTempo = new DateTime(0);
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelHora.Text = DateTime.Now.ToLongTimeString();
            contadorTempo = contadorTempo.Add(new TimeSpan(0, 0, 0, 0, 10));
            toolStripStatusLabelContador.Text = contadorTempo.ToString("HH:mm:ss:fff");
        }

        private void buttonIniciarParar(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            if (timer1.Enabled)
            {
                buttonInciarParar.Text = "Parar";
            }
            else
            {
                buttonInciarParar.Text = "Iniciar";
            }
        }

        private void reset(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                contadorTempo = new DateTime(0);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string horaAtual = toolStripStatusLabelHora.Text;
            string contadorAtual = toolStripStatusLabelContador.Text;
            string item = $"{horaAtual} @ {contadorAtual}";
            listBox1.Items.Add(item);
        }
    }
}
