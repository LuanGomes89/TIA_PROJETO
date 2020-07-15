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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            chart1.Series[0].Points.AddY(Convert.ToDouble(Graficos.Grafico.Gdados));
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Close();
        }
    }
}
