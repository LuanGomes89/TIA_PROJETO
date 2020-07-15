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
    public partial class Definir_Unidade : Form
    {
        string salvar = "";

        public Definir_Unidade()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (salvar == "Salvo")
            {
                if (check1.Checked) valores.valor[0] = lbentrada1.Text;
                else valores.valor[0] = null;
                if (check2.Checked) valores.valor[1] = lbentrada2.Text;
                else valores.valor[1] = null;
                if (check3.Checked) valores.valor[2] = lbentrada3.Text;
                else valores.valor[2] = null;
                if (check4.Checked) valores.valor[3] = lbentrada4.Text;
                else valores.valor[3] = null;
                if (check5.Checked) valores.valor[4] = lbentrada5.Text;
                else valores.valor[4] = null;
                if (check6.Checked) valores.valor[5] = lbentrada6.Text;
                else valores.valor[5] = null;
                if (check7.Checked) valores.valor[6] = lbentrada7.Text;
                else valores.valor[6] = null;
                if (check8.Checked) valores.valor[7] = lbentrada8.Text;
                else valores.valor[7] = null;

                Close();
            }
            else
            {
                Funcaolimpar();
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            salvar = "Salvo";
            lbSalvar.Text = "Dados Salvos";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Funcaolimpar();
            Close();

        }


        private void button1_Click_1(object sender, EventArgs e)
        {

            lbSalvar.Text = "Dados não Salvos";
            salvar = "";

            switch (cbEntrada.Text)
            {
                case "1":
                    lbentrada1.Text = cbUnidade.Text;
                    check1.Checked = true;
                    break;
                case "2":
                    lbentrada2.Text = cbUnidade.Text;
                    check2.Checked = true;
                    break;
                case "3":
                    lbentrada3.Text = cbUnidade.Text;
                    check3.Checked = true;
                    break;
                case "4":
                    lbentrada4.Text = cbUnidade.Text;
                    check4.Checked = true;
                    break;
                case "5":
                    lbentrada5.Text = cbUnidade.Text;
                    check5.Checked = true;
                    break;
                case "6":
                    lbentrada6.Text = cbUnidade.Text;
                    check6.Checked = true;
                    break;
                case "7":
                    lbentrada7.Text = cbUnidade.Text;
                    check7.Checked = true;
                    break;
                case "8":
                    lbentrada8.Text = cbUnidade.Text;
                    check8.Checked = true;
                    break;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Funcaolimpar();
        }


        // função para limpar dados-----------------------//

        public void Funcaolimpar()
        {

            string[] words = { "1", "2", "3", "4", "5", "6", "7", "8" };
            //string[] words = new string[8];

            for (int i = 0; i < 8; i++)
            {
                groupBox2.Controls["lbentrada" + words[i]].Text = "";
            }

            timer1.Enabled = false;

            check1.Checked = false;
            check2.Checked = false;
            check3.Checked = false;
            check4.Checked = false;
            check5.Checked = false;
            check6.Checked = false;
            check7.Checked = false;
            check8.Checked = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkAll.Checked)
            {
                string[] words = { "1", "2", "3", "4", "5", "6", "7", "8" };
                //string[] words = new string[8];

                for (int i = 0; i < 8; i++)
                {
                    groupBox2.Controls["lbentrada" + words[i]].Text = cbUnidade.Text;
                }

                check1.Checked = true;
                check2.Checked = true;
                check3.Checked = true;
                check4.Checked = true;
                check5.Checked = true;
                check6.Checked = true;
                check7.Checked = true;
                check8.Checked = true;
            }
                                             
            else
            {
                timer1.Enabled = false;
            }
       }


        private void checkAll_CheckedChanged(object sender, EventArgs e)
        {
          timer1.Enabled = true;
        }

        //------------------------------------------------//
    }

    public static class valores
    {
        public static string[] valor = new string[8];

    }
}



