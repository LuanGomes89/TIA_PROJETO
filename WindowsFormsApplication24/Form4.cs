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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
            string[] word2 = { "9", "10", "11", "12", "13", "14", "15", "16" };

            for (int i = 0; i < 8; i++)
            {
                groupBox3.Controls["lbentrada" + word2[i]].Text = valores.valor[i];
            }
        }
    }
}
