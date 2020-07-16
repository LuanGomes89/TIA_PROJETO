namespace WindowsFormsApplication24
{
    partial class Form1
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.interfaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intervaloDeArmazenamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fundoDeEscalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.portaDeComunicaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testeDeComunicaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calibraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coeficientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.definirUnidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = global::WindowsFormsApplication24.Properties.Resources.imagemT2;
            this.pictureBox2.Location = new System.Drawing.Point(12, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(205, 61);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::WindowsFormsApplication24.Properties.Resources.Imagem1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 167);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 424);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(574, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Teste Simples";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(769, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = "Teste Múltiplo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(574, 265);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(355, 32);
            this.button3.TabIndex = 4;
            this.button3.Text = "Fundo de Escala";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(574, 318);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(355, 32);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(574, 559);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(355, 32);
            this.button5.TabIndex = 6;
            this.button5.Text = "Sair";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("3DS Fonticon", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(359, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(570, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "SISTEMA DE AQUISIÇÃO DE SINAIS - TIA";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(574, 417);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(160, 25);
            this.button6.TabIndex = 8;
            this.button6.Text = "Testar";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(740, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Teste de comunicação";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.interfaceToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(962, 25);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // interfaceToolStripMenuItem
            // 
            this.interfaceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.intervaloDeArmazenamentoToolStripMenuItem,
            this.fundoDeEscalaToolStripMenuItem,
            this.portaDeComunicaçãoToolStripMenuItem,
            this.manutençãoToolStripMenuItem});
            this.interfaceToolStripMenuItem.Name = "interfaceToolStripMenuItem";
            this.interfaceToolStripMenuItem.Size = new System.Drawing.Size(73, 21);
            this.interfaceToolStripMenuItem.Text = "Interface";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // intervaloDeArmazenamentoToolStripMenuItem
            // 
            this.intervaloDeArmazenamentoToolStripMenuItem.Name = "intervaloDeArmazenamentoToolStripMenuItem";
            this.intervaloDeArmazenamentoToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.intervaloDeArmazenamentoToolStripMenuItem.Text = "Intervalo de Armazenamento";
            // 
            // fundoDeEscalaToolStripMenuItem
            // 
            this.fundoDeEscalaToolStripMenuItem.Name = "fundoDeEscalaToolStripMenuItem";
            this.fundoDeEscalaToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.fundoDeEscalaToolStripMenuItem.Text = "Fundo de Escala";
            // 
            // portaDeComunicaçãoToolStripMenuItem
            // 
            this.portaDeComunicaçãoToolStripMenuItem.Name = "portaDeComunicaçãoToolStripMenuItem";
            this.portaDeComunicaçãoToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.portaDeComunicaçãoToolStripMenuItem.Text = "Porta de Comunicação";
            this.portaDeComunicaçãoToolStripMenuItem.Click += new System.EventHandler(this.portaDeComunicaçãoToolStripMenuItem_Click);
            // 
            // manutençãoToolStripMenuItem
            // 
            this.manutençãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testeDeComunicaçãoToolStripMenuItem,
            this.calibraçãoToolStripMenuItem,
            this.coeficientesToolStripMenuItem,
            this.definirUnidadesToolStripMenuItem});
            this.manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
            this.manutençãoToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.manutençãoToolStripMenuItem.Text = "Manutenção";
            // 
            // testeDeComunicaçãoToolStripMenuItem
            // 
            this.testeDeComunicaçãoToolStripMenuItem.Name = "testeDeComunicaçãoToolStripMenuItem";
            this.testeDeComunicaçãoToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.testeDeComunicaçãoToolStripMenuItem.Text = "Teste de Comunicação";
            // 
            // calibraçãoToolStripMenuItem
            // 
            this.calibraçãoToolStripMenuItem.Name = "calibraçãoToolStripMenuItem";
            this.calibraçãoToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.calibraçãoToolStripMenuItem.Text = "Calibração";
            // 
            // coeficientesToolStripMenuItem
            // 
            this.coeficientesToolStripMenuItem.Name = "coeficientesToolStripMenuItem";
            this.coeficientesToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.coeficientesToolStripMenuItem.Text = "Coeficientes";
            // 
            // definirUnidadesToolStripMenuItem
            // 
            this.definirUnidadesToolStripMenuItem.Name = "definirUnidadesToolStripMenuItem";
            this.definirUnidadesToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.definirUnidadesToolStripMenuItem.Text = "Definir unidades";
            this.definirUnidadesToolStripMenuItem.Click += new System.EventHandler(this.definirUnidadesToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(574, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(354, 21);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Registros";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 620);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem interfaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intervaloDeArmazenamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fundoDeEscalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem portaDeComunicaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutençãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testeDeComunicaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calibraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coeficientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem definirUnidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
    }
}