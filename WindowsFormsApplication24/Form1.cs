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
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void definirUnidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Definir_Unidade unidades = new Definir_Unidade();
            unidades.ShowDialog();

            
        }
    }
}
