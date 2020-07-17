using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication24
{
    public static class dados
    {
        public static string porta;
        public static double baud;
        public static byte bits;
        public static string paridade;
        public static int stop;

    }

    public partial class Form1 : Form
    {
        


        public Form1()
        {
            InitializeComponent();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Graficos multiplos = new Graficos();
            multiplos.ShowDialog();
        }

        private void portaDeComunicaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Comunicação = new Form2();
            Comunicação.ShowDialog();

            dados.porta = Comunicação.cbPorta.Text;
            dados.baud = Convert.ToInt32(Comunicação.cbBaud.Text);
            dados.bits = Convert.ToByte(Comunicação.Cbdata.Text);
            dados.paridade = Comunicação.cdParity.Text;
            dados.stop = Convert.ToInt16(Comunicação.Cbstop.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            Application.Exit();
        }

        private void definirUnidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Definir_Unidade unidades = new Definir_Unidade();
            unidades.ShowDialog();

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 escala = new Form4();
            escala.ShowDialog();
        }

        private void fundoDeEscalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 escala = new Form4();
            escala.ShowDialog();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            Application.Exit();
        }
    }
}
