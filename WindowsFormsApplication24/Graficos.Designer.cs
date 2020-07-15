namespace WindowsFormsApplication24
{
    partial class Graficos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series41 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series42 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series43 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series44 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series45 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series46 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series47 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series48 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnConect = new System.Windows.Forms.Button();
            this.txtsensor1 = new System.Windows.Forms.Label();
            this.chGrafico1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbsenso1 = new System.Windows.Forms.Label();
            this.lbsenso2 = new System.Windows.Forms.Label();
            this.txtsensor2 = new System.Windows.Forms.Label();
            this.lbsenso3 = new System.Windows.Forms.Label();
            this.txtsensor3 = new System.Windows.Forms.Label();
            this.lbsenso4 = new System.Windows.Forms.Label();
            this.txtsensor4 = new System.Windows.Forms.Label();
            this.lbsenso5 = new System.Windows.Forms.Label();
            this.txtsensor5 = new System.Windows.Forms.Label();
            this.lbsenso6 = new System.Windows.Forms.Label();
            this.txtsensor6 = new System.Windows.Forms.Label();
            this.lbsenso7 = new System.Windows.Forms.Label();
            this.txtsensor7 = new System.Windows.Forms.Label();
            this.lbsenso8 = new System.Windows.Forms.Label();
            this.txtsensor8 = new System.Windows.Forms.Label();
            this.ch1 = new System.Windows.Forms.CheckBox();
            this.ch2 = new System.Windows.Forms.CheckBox();
            this.ch3 = new System.Windows.Forms.CheckBox();
            this.ch4 = new System.Windows.Forms.CheckBox();
            this.ch5 = new System.Windows.Forms.CheckBox();
            this.ch6 = new System.Windows.Forms.CheckBox();
            this.ch7 = new System.Windows.Forms.CheckBox();
            this.ch8 = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comunicaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtSlave = new System.Windows.Forms.Label();
            this.cbSlave = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gráficoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.definirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.chGrafico1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConect
            // 
            this.btnConect.Location = new System.Drawing.Point(583, 42);
            this.btnConect.Name = "btnConect";
            this.btnConect.Size = new System.Drawing.Size(105, 23);
            this.btnConect.TabIndex = 0;
            this.btnConect.Text = "Desconected";
            this.btnConect.UseVisualStyleBackColor = true;
            this.btnConect.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtsensor1
            // 
            this.txtsensor1.AutoSize = true;
            this.txtsensor1.Location = new System.Drawing.Point(12, 42);
            this.txtsensor1.Name = "txtsensor1";
            this.txtsensor1.Size = new System.Drawing.Size(49, 13);
            this.txtsensor1.TabIndex = 1;
            this.txtsensor1.Text = "Sensor 1";
            // 
            // chGrafico1
            // 
            chartArea6.Name = "ChartArea1";
            this.chGrafico1.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chGrafico1.Legends.Add(legend6);
            this.chGrafico1.Location = new System.Drawing.Point(12, 87);
            this.chGrafico1.Name = "chGrafico1";
            series41.ChartArea = "ChartArea1";
            series41.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series41.Legend = "Legend1";
            series41.Name = "Series1";
            series42.ChartArea = "ChartArea1";
            series42.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series42.Legend = "Legend1";
            series42.Name = "Series2";
            series43.ChartArea = "ChartArea1";
            series43.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series43.Legend = "Legend1";
            series43.Name = "Series3";
            series44.ChartArea = "ChartArea1";
            series44.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series44.Legend = "Legend1";
            series44.Name = "Series4";
            series45.ChartArea = "ChartArea1";
            series45.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series45.Legend = "Legend1";
            series45.Name = "Series5";
            series46.ChartArea = "ChartArea1";
            series46.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series46.Legend = "Legend1";
            series46.Name = "Series6";
            series47.ChartArea = "ChartArea1";
            series47.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series47.Legend = "Legend1";
            series47.Name = "Series7";
            series48.ChartArea = "ChartArea1";
            series48.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series48.Legend = "Legend1";
            series48.Name = "Series8";
            this.chGrafico1.Series.Add(series41);
            this.chGrafico1.Series.Add(series42);
            this.chGrafico1.Series.Add(series43);
            this.chGrafico1.Series.Add(series44);
            this.chGrafico1.Series.Add(series45);
            this.chGrafico1.Series.Add(series46);
            this.chGrafico1.Series.Add(series47);
            this.chGrafico1.Series.Add(series48);
            this.chGrafico1.Size = new System.Drawing.Size(676, 254);
            this.chGrafico1.TabIndex = 2;
            this.chGrafico1.Text = "chart1";
            // 
            // lbsenso1
            // 
            this.lbsenso1.AutoSize = true;
            this.lbsenso1.Location = new System.Drawing.Point(12, 55);
            this.lbsenso1.Name = "lbsenso1";
            this.lbsenso1.Size = new System.Drawing.Size(31, 13);
            this.lbsenso1.TabIndex = 3;
            this.lbsenso1.Text = "0000";
            // 
            // lbsenso2
            // 
            this.lbsenso2.AutoSize = true;
            this.lbsenso2.Location = new System.Drawing.Point(76, 55);
            this.lbsenso2.Name = "lbsenso2";
            this.lbsenso2.Size = new System.Drawing.Size(31, 13);
            this.lbsenso2.TabIndex = 5;
            this.lbsenso2.Text = "0000";
            // 
            // txtsensor2
            // 
            this.txtsensor2.AutoSize = true;
            this.txtsensor2.Location = new System.Drawing.Point(76, 42);
            this.txtsensor2.Name = "txtsensor2";
            this.txtsensor2.Size = new System.Drawing.Size(49, 13);
            this.txtsensor2.TabIndex = 4;
            this.txtsensor2.Text = "Sensor 2";
            // 
            // lbsenso3
            // 
            this.lbsenso3.AutoSize = true;
            this.lbsenso3.Location = new System.Drawing.Point(140, 55);
            this.lbsenso3.Name = "lbsenso3";
            this.lbsenso3.Size = new System.Drawing.Size(31, 13);
            this.lbsenso3.TabIndex = 7;
            this.lbsenso3.Text = "0000";
            // 
            // txtsensor3
            // 
            this.txtsensor3.AutoSize = true;
            this.txtsensor3.Location = new System.Drawing.Point(140, 42);
            this.txtsensor3.Name = "txtsensor3";
            this.txtsensor3.Size = new System.Drawing.Size(49, 13);
            this.txtsensor3.TabIndex = 6;
            this.txtsensor3.Text = "Sensor 3";
            // 
            // lbsenso4
            // 
            this.lbsenso4.AutoSize = true;
            this.lbsenso4.Location = new System.Drawing.Point(208, 55);
            this.lbsenso4.Name = "lbsenso4";
            this.lbsenso4.Size = new System.Drawing.Size(31, 13);
            this.lbsenso4.TabIndex = 9;
            this.lbsenso4.Text = "0000";
            // 
            // txtsensor4
            // 
            this.txtsensor4.AutoSize = true;
            this.txtsensor4.Location = new System.Drawing.Point(208, 42);
            this.txtsensor4.Name = "txtsensor4";
            this.txtsensor4.Size = new System.Drawing.Size(49, 13);
            this.txtsensor4.TabIndex = 8;
            this.txtsensor4.Text = "Sensor 4";
            // 
            // lbsenso5
            // 
            this.lbsenso5.AutoSize = true;
            this.lbsenso5.Location = new System.Drawing.Point(277, 55);
            this.lbsenso5.Name = "lbsenso5";
            this.lbsenso5.Size = new System.Drawing.Size(31, 13);
            this.lbsenso5.TabIndex = 11;
            this.lbsenso5.Text = "0000";
            // 
            // txtsensor5
            // 
            this.txtsensor5.AutoSize = true;
            this.txtsensor5.Location = new System.Drawing.Point(277, 42);
            this.txtsensor5.Name = "txtsensor5";
            this.txtsensor5.Size = new System.Drawing.Size(49, 13);
            this.txtsensor5.TabIndex = 10;
            this.txtsensor5.Text = "Sensor 5";
            // 
            // lbsenso6
            // 
            this.lbsenso6.AutoSize = true;
            this.lbsenso6.Location = new System.Drawing.Point(348, 55);
            this.lbsenso6.Name = "lbsenso6";
            this.lbsenso6.Size = new System.Drawing.Size(31, 13);
            this.lbsenso6.TabIndex = 13;
            this.lbsenso6.Text = "0000";
            // 
            // txtsensor6
            // 
            this.txtsensor6.AutoSize = true;
            this.txtsensor6.Location = new System.Drawing.Point(348, 42);
            this.txtsensor6.Name = "txtsensor6";
            this.txtsensor6.Size = new System.Drawing.Size(49, 13);
            this.txtsensor6.TabIndex = 12;
            this.txtsensor6.Text = "Sensor 6";
            // 
            // lbsenso7
            // 
            this.lbsenso7.AutoSize = true;
            this.lbsenso7.Location = new System.Drawing.Point(416, 55);
            this.lbsenso7.Name = "lbsenso7";
            this.lbsenso7.Size = new System.Drawing.Size(31, 13);
            this.lbsenso7.TabIndex = 15;
            this.lbsenso7.Text = "0000";
            // 
            // txtsensor7
            // 
            this.txtsensor7.AutoSize = true;
            this.txtsensor7.Location = new System.Drawing.Point(416, 42);
            this.txtsensor7.Name = "txtsensor7";
            this.txtsensor7.Size = new System.Drawing.Size(49, 13);
            this.txtsensor7.TabIndex = 14;
            this.txtsensor7.Text = "Sensor 7";
            // 
            // lbsenso8
            // 
            this.lbsenso8.AutoSize = true;
            this.lbsenso8.Location = new System.Drawing.Point(487, 55);
            this.lbsenso8.Name = "lbsenso8";
            this.lbsenso8.Size = new System.Drawing.Size(31, 13);
            this.lbsenso8.TabIndex = 17;
            this.lbsenso8.Text = "0000";
            // 
            // txtsensor8
            // 
            this.txtsensor8.AutoSize = true;
            this.txtsensor8.Location = new System.Drawing.Point(487, 42);
            this.txtsensor8.Name = "txtsensor8";
            this.txtsensor8.Size = new System.Drawing.Size(49, 13);
            this.txtsensor8.TabIndex = 16;
            this.txtsensor8.Text = "Sensor 8";
            // 
            // ch1
            // 
            this.ch1.AutoSize = true;
            this.ch1.Location = new System.Drawing.Point(12, 358);
            this.ch1.Name = "ch1";
            this.ch1.Size = new System.Drawing.Size(59, 17);
            this.ch1.TabIndex = 18;
            this.ch1.Text = "Série 1";
            this.ch1.UseVisualStyleBackColor = true;
            // 
            // ch2
            // 
            this.ch2.AutoSize = true;
            this.ch2.Location = new System.Drawing.Point(12, 381);
            this.ch2.Name = "ch2";
            this.ch2.Size = new System.Drawing.Size(59, 17);
            this.ch2.TabIndex = 19;
            this.ch2.Text = "Série 2";
            this.ch2.UseVisualStyleBackColor = true;
            // 
            // ch3
            // 
            this.ch3.AutoSize = true;
            this.ch3.Location = new System.Drawing.Point(109, 358);
            this.ch3.Name = "ch3";
            this.ch3.Size = new System.Drawing.Size(59, 17);
            this.ch3.TabIndex = 20;
            this.ch3.Text = "Série 3";
            this.ch3.UseVisualStyleBackColor = true;
            // 
            // ch4
            // 
            this.ch4.AutoSize = true;
            this.ch4.Location = new System.Drawing.Point(109, 381);
            this.ch4.Name = "ch4";
            this.ch4.Size = new System.Drawing.Size(59, 17);
            this.ch4.TabIndex = 21;
            this.ch4.Text = "Série 4";
            this.ch4.UseVisualStyleBackColor = true;
            // 
            // ch5
            // 
            this.ch5.AutoSize = true;
            this.ch5.Location = new System.Drawing.Point(211, 358);
            this.ch5.Name = "ch5";
            this.ch5.Size = new System.Drawing.Size(59, 17);
            this.ch5.TabIndex = 22;
            this.ch5.Text = "Série 5";
            this.ch5.UseVisualStyleBackColor = true;
            // 
            // ch6
            // 
            this.ch6.AutoSize = true;
            this.ch6.Location = new System.Drawing.Point(211, 381);
            this.ch6.Name = "ch6";
            this.ch6.Size = new System.Drawing.Size(59, 17);
            this.ch6.TabIndex = 23;
            this.ch6.Text = "Série 6";
            this.ch6.UseVisualStyleBackColor = true;
            // 
            // ch7
            // 
            this.ch7.AutoSize = true;
            this.ch7.Location = new System.Drawing.Point(317, 358);
            this.ch7.Name = "ch7";
            this.ch7.Size = new System.Drawing.Size(59, 17);
            this.ch7.TabIndex = 24;
            this.ch7.Text = "Série 7";
            this.ch7.UseVisualStyleBackColor = true;
            // 
            // ch8
            // 
            this.ch8.AutoSize = true;
            this.ch8.Location = new System.Drawing.Point(317, 381);
            this.ch8.Name = "ch8";
            this.ch8.Size = new System.Drawing.Size(59, 17);
            this.ch8.TabIndex = 25;
            this.ch8.Text = "Série 8";
            this.ch8.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(796, 24);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comunicaçãoToolStripMenuItem,
            this.gráficoToolStripMenuItem,
            this.toolStripSeparator1,
            this.definirToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // comunicaçãoToolStripMenuItem
            // 
            this.comunicaçãoToolStripMenuItem.Name = "comunicaçãoToolStripMenuItem";
            this.comunicaçãoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.comunicaçãoToolStripMenuItem.Text = "Comunicação";
            this.comunicaçãoToolStripMenuItem.Click += new System.EventHandler(this.comunicaçãoToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtSlave
            // 
            this.txtSlave.AutoSize = true;
            this.txtSlave.Location = new System.Drawing.Point(537, 371);
            this.txtSlave.Name = "txtSlave";
            this.txtSlave.Size = new System.Drawing.Size(49, 13);
            this.txtSlave.TabIndex = 28;
            this.txtSlave.Text = "Slave Id:";
            // 
            // cbSlave
            // 
            this.cbSlave.Location = new System.Drawing.Point(589, 364);
            this.cbSlave.Name = "cbSlave";
            this.cbSlave.Size = new System.Drawing.Size(100, 20);
            this.cbSlave.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // gráficoToolStripMenuItem
            // 
            this.gráficoToolStripMenuItem.Name = "gráficoToolStripMenuItem";
            this.gráficoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gráficoToolStripMenuItem.Text = "Gráfico";
            this.gráficoToolStripMenuItem.Click += new System.EventHandler(this.gráficoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // definirToolStripMenuItem
            // 
            this.definirToolStripMenuItem.Name = "definirToolStripMenuItem";
            this.definirToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.definirToolStripMenuItem.Text = "Definir Unidade";
            this.definirToolStripMenuItem.Click += new System.EventHandler(this.definirToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(73, 20);
            this.textBox1.TabIndex = 31;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(73, 20);
            this.textBox2.TabIndex = 32;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 80);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(73, 20);
            this.textBox3.TabIndex = 33;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 106);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(73, 20);
            this.textBox4.TabIndex = 34;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(6, 132);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(73, 20);
            this.textBox5.TabIndex = 35;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(6, 158);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(73, 20);
            this.textBox6.TabIndex = 36;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(6, 184);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(73, 20);
            this.textBox7.TabIndex = 37;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(6, 210);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(73, 20);
            this.textBox8.TabIndex = 38;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Location = new System.Drawing.Point(698, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(86, 254);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Graficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 435);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbSlave);
            this.Controls.Add(this.txtSlave);
            this.Controls.Add(this.ch8);
            this.Controls.Add(this.ch7);
            this.Controls.Add(this.ch6);
            this.Controls.Add(this.ch5);
            this.Controls.Add(this.ch4);
            this.Controls.Add(this.ch3);
            this.Controls.Add(this.ch2);
            this.Controls.Add(this.ch1);
            this.Controls.Add(this.lbsenso8);
            this.Controls.Add(this.txtsensor8);
            this.Controls.Add(this.lbsenso7);
            this.Controls.Add(this.txtsensor7);
            this.Controls.Add(this.lbsenso6);
            this.Controls.Add(this.txtsensor6);
            this.Controls.Add(this.lbsenso5);
            this.Controls.Add(this.txtsensor5);
            this.Controls.Add(this.lbsenso4);
            this.Controls.Add(this.txtsensor4);
            this.Controls.Add(this.lbsenso3);
            this.Controls.Add(this.txtsensor3);
            this.Controls.Add(this.lbsenso2);
            this.Controls.Add(this.txtsensor2);
            this.Controls.Add(this.lbsenso1);
            this.Controls.Add(this.chGrafico1);
            this.Controls.Add(this.txtsensor1);
            this.Controls.Add(this.btnConect);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Graficos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Graficos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chGrafico1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConect;
        private System.Windows.Forms.Label txtsensor1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chGrafico1;
        private System.Windows.Forms.Label lbsenso1;
        private System.Windows.Forms.Label lbsenso2;
        private System.Windows.Forms.Label txtsensor2;
        private System.Windows.Forms.Label lbsenso3;
        private System.Windows.Forms.Label txtsensor3;
        private System.Windows.Forms.Label lbsenso4;
        private System.Windows.Forms.Label txtsensor4;
        private System.Windows.Forms.Label lbsenso5;
        private System.Windows.Forms.Label txtsensor5;
        private System.Windows.Forms.Label lbsenso6;
        private System.Windows.Forms.Label txtsensor6;
        private System.Windows.Forms.Label lbsenso7;
        private System.Windows.Forms.Label txtsensor7;
        private System.Windows.Forms.Label lbsenso8;
        private System.Windows.Forms.Label txtsensor8;
        private System.Windows.Forms.CheckBox ch1;
        private System.Windows.Forms.CheckBox ch2;
        private System.Windows.Forms.CheckBox ch3;
        private System.Windows.Forms.CheckBox ch4;
        private System.Windows.Forms.CheckBox ch5;
        private System.Windows.Forms.CheckBox ch6;
        private System.Windows.Forms.CheckBox ch7;
        private System.Windows.Forms.CheckBox ch8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comunicaçãoToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label txtSlave;
        private System.Windows.Forms.TextBox cbSlave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem gráficoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem definirToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

