using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO.Ports;
using Modbus.Device;



namespace WindowsFormsApplication24
{
    public partial class Graficos : Form
    {
        Form2 form = new Form2();

        SerialPort ports = new SerialPort();

        public static class Grafico
        {
            public static string Gdados;
        }

       string[] dado = new string[8]; //string dado1; string dado2; string dado3; string dado4; string dado5; string dado6; string dado7; string dado8;

        public Graficos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                
                if (ports.IsOpen == true)
                {
                    ports.Close();
                    btnConect.Text = "Desconected";
                    timer1.Enabled = false;
                  
                }
                else
                {
                    ports.Open();
                    btnConect.Text = "Conected";
                    timer1.Enabled = true;
            }
            }catch (Exception)
            {
                MessageBox.Show("Error porta COM!!");
            }

        }

        private void comunicaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form.ShowDialog();
           

            ports.PortName = form.cbPorta.Text;
            ports.BaudRate = Convert.ToInt32(form.cbBaud.Text);
            ports.DataBits = Convert.ToByte(form.Cbdata.Text);
            ports.Parity = (Parity)Enum.Parse(typeof(Parity), form.cdParity.Text);
            ports.StopBits = (StopBits)Enum.Parse(typeof(StopBits), form.Cbstop.Text);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // inicia modbus
            try
            {
                IModbusSerialMaster master = ModbusSerialMaster.CreateRtu(ports);
                byte slaveId = Convert.ToByte(cbSlave.Text);

                ushort[] dado1 = master.ReadHoldingRegisters(slaveId, 0, 8);


                //  bool[] teste = master.ReadCoils(2, 269, 1);
                //   textBox1.Text = Convert.ToString(teste);


                this.dado[0] = (dado1[0]).ToString();
                this.dado[1] = (dado1[1]).ToString();
                this.dado[2] = (dado1[2]).ToString();
                this.dado[3] = (dado1[3]).ToString();
                this.dado[4] = (dado1[4]).ToString();
                this.dado[5] = (dado1[5]).ToString();
                this.dado[6] = (dado1[6]).ToString();
                this.dado[7] = (dado1[7]).ToString();

                Grafico.Gdados = dado[0];

            }catch (Exception)
            {
                
                btnConect.Text = "Desconected";
                ports.Close();
                timer1.Enabled = false;
                MessageBox.Show("Slave Id Error");

            }                                    

            {

                if (ch1.Checked == true)
                    chGrafico1.Series[0].Enabled = true;
                else
                    chGrafico1.Series[0].Enabled = false;

                if (ch2.Checked == true)
                    chGrafico1.Series[1].Enabled = true;
                else
                    chGrafico1.Series[1].Enabled = false;

                if (ch3.Checked == true)
                    chGrafico1.Series[2].Enabled = true;
                else
                    chGrafico1.Series[2].Enabled = false;

                if (ch4.Checked == true)
                    chGrafico1.Series[3].Enabled = true;
                else
                    chGrafico1.Series[3].Enabled = false;

                if (ch5.Checked == true)
                    chGrafico1.Series[4].Enabled = true;
                else
                    chGrafico1.Series[4].Enabled = false;

                if (ch6.Checked == true)
                    chGrafico1.Series[5].Enabled = true;
                else
                    chGrafico1.Series[5].Enabled = false;

                if (ch7.Checked == true)
                    chGrafico1.Series[6].Enabled = true;
                else
                    chGrafico1.Series[6].Enabled = false;

                if (ch8.Checked == true)
                    chGrafico1.Series[7].Enabled = true;
                else
                    chGrafico1.Series[7].Enabled = false;

            }

            if (chGrafico1.Series[0].Points.Count > 20 )
            {
                chGrafico1.Series[0].Points.RemoveAt(0);
                chGrafico1.Update();
            }
            if (chGrafico1.Series[1].Points.Count > 20)
            {
                chGrafico1.Series[1].Points.RemoveAt(0);
                chGrafico1.Update();
            }
            if (chGrafico1.Series[2].Points.Count > 20)
            {
                chGrafico1.Series[2].Points.RemoveAt(0);
                chGrafico1.Update();
            }
            if (chGrafico1.Series[3].Points.Count > 20)
            {
                chGrafico1.Series[3].Points.RemoveAt(0);
                chGrafico1.Update();
            }
            if (chGrafico1.Series[4].Points.Count > 20)
            {
                chGrafico1.Series[4].Points.RemoveAt(0);
                chGrafico1.Update();
            }
            if (chGrafico1.Series[5].Points.Count > 20)
            {
                chGrafico1.Series[5].Points.RemoveAt(0);
                chGrafico1.Update();
            }
            if (chGrafico1.Series[6].Points.Count > 20)
            {
                chGrafico1.Series[6].Points.RemoveAt(0);
                chGrafico1.Update();
            }
            if (chGrafico1.Series[7].Points.Count > 20)
            {
                chGrafico1.Series[7].Points.RemoveAt(0);
                chGrafico1.Update();
            }


            {
                  chGrafico1.Series[0].Points.AddY(Convert.ToDouble(this.dado[0]));
                  chGrafico1.Series[1].Points.AddY(Convert.ToDouble(this.dado[1]));
                  chGrafico1.Series[2].Points.AddY(Convert.ToDouble(this.dado[2]));
                  chGrafico1.Series[3].Points.AddY(Convert.ToDouble(this.dado[3]));
                  chGrafico1.Series[4].Points.AddY(Convert.ToDouble(this.dado[4]));
                  chGrafico1.Series[5].Points.AddY(Convert.ToDouble(this.dado[5]));
                  chGrafico1.Series[6].Points.AddY(Convert.ToDouble(this.dado[6]));
                  chGrafico1.Series[7].Points.AddY(Convert.ToDouble(this.dado[7]));
            }

          lbsenso1.Text = this.dado[0]; lbsenso2.Text = this.dado[1]; lbsenso3.Text = this.dado[2];
            lbsenso4.Text = this.dado[3]; lbsenso5.Text = this.dado[4]; lbsenso6.Text = this.dado[5];
            lbsenso7.Text = this.dado[6]; lbsenso8.Text = this.dado[7];

        }

        private void Graficos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(timer1.Enabled == true)
            {
                timer1.Enabled = false;
                button1.Text = "Play";
            }else
            {
                timer1.Enabled = true;
                button1.Text = "Stop";
            }
        }

        private void gráficoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void definirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Definir_Unidade Dunidade = new Definir_Unidade();
            Dunidade.ShowDialog();

            string[] word = { "1", "2", "3", "4", "5", "6", "7", "8" };

            for (int i = 0; i < 8; i++)
            {
                groupBox1.Controls["textBox" + word[i]].Text = valores.valor[i];
                
            }

               /* textBox1.Text = valores.valor[0];
                textBox2.Text = valores.valor[1];
                textBox3.Text = valores.valor[2];
                textBox4.Text = valores.valor[3];
                textBox5.Text = valores.valor[4];
                textBox6.Text = valores.valor[5];
                textBox7.Text = valores.valor[6];
                textBox8.Text = valores.valor[7];*/
            
        }
    }
}


