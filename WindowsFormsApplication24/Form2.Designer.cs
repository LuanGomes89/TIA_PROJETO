namespace WindowsFormsApplication24
{
    partial class Form2
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
            this.cbPorta = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbBaud = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Cbstop = new System.Windows.Forms.ComboBox();
            this.cdParity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Cbdata = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbPorta
            // 
            this.cbPorta.FormattingEnabled = true;
            this.cbPorta.Location = new System.Drawing.Point(67, 19);
            this.cbPorta.Name = "cbPorta";
            this.cbPorta.Size = new System.Drawing.Size(75, 21);
            this.cbPorta.TabIndex = 0;
            this.cbPorta.Text = "COM1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbBaud);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbPorta);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info Port:";
            // 
            // cbBaud
            // 
            this.cbBaud.FormattingEnabled = true;
            this.cbBaud.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.cbBaud.Location = new System.Drawing.Point(67, 46);
            this.cbBaud.Name = "cbBaud";
            this.cbBaud.Size = new System.Drawing.Size(75, 21);
            this.cbBaud.TabIndex = 3;
            this.cbBaud.Text = "9600";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "BaudRate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port COM:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Cbstop);
            this.groupBox2.Controls.Add(this.cdParity);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Cbdata);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(156, 114);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Info Dados:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Stop Bit:";
            // 
            // Cbstop
            // 
            this.Cbstop.FormattingEnabled = true;
            this.Cbstop.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.Cbstop.Location = new System.Drawing.Point(67, 73);
            this.Cbstop.Name = "Cbstop";
            this.Cbstop.Size = new System.Drawing.Size(75, 21);
            this.Cbstop.TabIndex = 5;
            this.Cbstop.Text = "1";
            // 
            // cdParity
            // 
            this.cdParity.FormattingEnabled = true;
            this.cdParity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Over"});
            this.cdParity.Location = new System.Drawing.Point(67, 46);
            this.cdParity.Name = "cdParity";
            this.cdParity.Size = new System.Drawing.Size(75, 21);
            this.cdParity.TabIndex = 4;
            this.cdParity.Text = "None";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Parity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Data Bit:";
            // 
            // Cbdata
            // 
            this.Cbdata.FormattingEnabled = true;
            this.Cbdata.Items.AddRange(new object[] {
            "7",
            "8",
            "9"});
            this.Cbdata.Location = new System.Drawing.Point(67, 19);
            this.Cbdata.Name = "Cbdata";
            this.Cbdata.Size = new System.Drawing.Size(75, 21);
            this.Cbdata.TabIndex = 0;
            this.Cbdata.Text = "8";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 270);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox cbPorta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbBaud;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox Cbstop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox Cbdata;
        public System.Windows.Forms.ComboBox cdParity;
    }
}