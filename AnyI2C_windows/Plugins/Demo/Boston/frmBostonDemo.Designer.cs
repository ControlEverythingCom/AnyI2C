namespace BostonDemo
{
    partial class frmBostonDemo
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.numAddress = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.lbPCA9685_1_C4 = new System.Windows.Forms.Label();
            this.scrollBarPCA9685_1_C4 = new System.Windows.Forms.HScrollBar();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.lbPCA9685_1_C3 = new System.Windows.Forms.Label();
            this.scrollBarPCA9685_1_C3 = new System.Windows.Forms.HScrollBar();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lbPCA9685_1_C2 = new System.Windows.Forms.Label();
            this.scrollBarPCA9685_1_C2 = new System.Windows.Forms.HScrollBar();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lbPCA9685_1_C1 = new System.Windows.Forms.Label();
            this.scrollBarPCA9685_1_C1 = new System.Windows.Forms.HScrollBar();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbHum = new System.Windows.Forms.Label();
            this.lbTemperature = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddress)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.numPort);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(197, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(120, 68);
            this.groupBox3.TabIndex = 651;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Port";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(372, 84);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 52);
            this.groupBox4.TabIndex = 487;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "GroupBox2";
            // 
            // numPort
            // 
            this.numPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPort.Location = new System.Drawing.Point(11, 21);
            this.numPort.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(82, 35);
            this.numPort.TabIndex = 490;
            this.numPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numPort.ValueChanged += new System.EventHandler(this.numPort_ValueChanged);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.GroupBox2);
            this.GroupBox1.Controls.Add(this.numAddress);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(172, 68);
            this.GroupBox1.TabIndex = 646;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Hardware Address";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Location = new System.Drawing.Point(372, 84);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(200, 52);
            this.GroupBox2.TabIndex = 487;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "GroupBox2";
            // 
            // numAddress
            // 
            this.numAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAddress.Location = new System.Drawing.Point(11, 21);
            this.numAddress.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numAddress.Name = "numAddress";
            this.numAddress.Size = new System.Drawing.Size(82, 35);
            this.numAddress.TabIndex = 490;
            this.numAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numAddress.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox10);
            this.groupBox5.Controls.Add(this.groupBox9);
            this.groupBox5.Controls.Add(this.groupBox8);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Location = new System.Drawing.Point(12, 97);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(382, 325);
            this.groupBox5.TabIndex = 658;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "PCA 9685 PWM";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.lbPCA9685_1_C4);
            this.groupBox10.Controls.Add(this.scrollBarPCA9685_1_C4);
            this.groupBox10.Location = new System.Drawing.Point(28, 243);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(327, 62);
            this.groupBox10.TabIndex = 0;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Channel 4";
            // 
            // lbPCA9685_1_C4
            // 
            this.lbPCA9685_1_C4.AutoSize = true;
            this.lbPCA9685_1_C4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPCA9685_1_C4.Location = new System.Drawing.Point(281, 30);
            this.lbPCA9685_1_C4.Name = "lbPCA9685_1_C4";
            this.lbPCA9685_1_C4.Size = new System.Drawing.Size(15, 15);
            this.lbPCA9685_1_C4.TabIndex = 654;
            this.lbPCA9685_1_C4.Text = "0";
            // 
            // scrollBarPCA9685_1_C4
            // 
            this.scrollBarPCA9685_1_C4.LargeChange = 1;
            this.scrollBarPCA9685_1_C4.Location = new System.Drawing.Point(15, 20);
            this.scrollBarPCA9685_1_C4.Maximum = 15;
            this.scrollBarPCA9685_1_C4.Name = "scrollBarPCA9685_1_C4";
            this.scrollBarPCA9685_1_C4.Size = new System.Drawing.Size(224, 27);
            this.scrollBarPCA9685_1_C4.TabIndex = 652;
            this.scrollBarPCA9685_1_C4.Value = 1;
            this.scrollBarPCA9685_1_C4.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollBarPCA9685_1_C4_Scroll);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.lbPCA9685_1_C3);
            this.groupBox9.Controls.Add(this.scrollBarPCA9685_1_C3);
            this.groupBox9.Location = new System.Drawing.Point(28, 173);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(327, 62);
            this.groupBox9.TabIndex = 0;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Channel 3";
            // 
            // lbPCA9685_1_C3
            // 
            this.lbPCA9685_1_C3.AutoSize = true;
            this.lbPCA9685_1_C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPCA9685_1_C3.Location = new System.Drawing.Point(281, 30);
            this.lbPCA9685_1_C3.Name = "lbPCA9685_1_C3";
            this.lbPCA9685_1_C3.Size = new System.Drawing.Size(15, 15);
            this.lbPCA9685_1_C3.TabIndex = 654;
            this.lbPCA9685_1_C3.Text = "0";
            // 
            // scrollBarPCA9685_1_C3
            // 
            this.scrollBarPCA9685_1_C3.LargeChange = 1;
            this.scrollBarPCA9685_1_C3.Location = new System.Drawing.Point(15, 20);
            this.scrollBarPCA9685_1_C3.Maximum = 15;
            this.scrollBarPCA9685_1_C3.Name = "scrollBarPCA9685_1_C3";
            this.scrollBarPCA9685_1_C3.Size = new System.Drawing.Size(224, 27);
            this.scrollBarPCA9685_1_C3.TabIndex = 652;
            this.scrollBarPCA9685_1_C3.Value = 1;
            this.scrollBarPCA9685_1_C3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollBarPCA9685_1_C3_Scroll);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lbPCA9685_1_C2);
            this.groupBox8.Controls.Add(this.scrollBarPCA9685_1_C2);
            this.groupBox8.Location = new System.Drawing.Point(28, 105);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(327, 62);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Channel 2";
            // 
            // lbPCA9685_1_C2
            // 
            this.lbPCA9685_1_C2.AutoSize = true;
            this.lbPCA9685_1_C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPCA9685_1_C2.Location = new System.Drawing.Point(281, 30);
            this.lbPCA9685_1_C2.Name = "lbPCA9685_1_C2";
            this.lbPCA9685_1_C2.Size = new System.Drawing.Size(15, 15);
            this.lbPCA9685_1_C2.TabIndex = 654;
            this.lbPCA9685_1_C2.Text = "0";
            // 
            // scrollBarPCA9685_1_C2
            // 
            this.scrollBarPCA9685_1_C2.LargeChange = 1;
            this.scrollBarPCA9685_1_C2.Location = new System.Drawing.Point(15, 20);
            this.scrollBarPCA9685_1_C2.Maximum = 15;
            this.scrollBarPCA9685_1_C2.Name = "scrollBarPCA9685_1_C2";
            this.scrollBarPCA9685_1_C2.Size = new System.Drawing.Size(224, 27);
            this.scrollBarPCA9685_1_C2.TabIndex = 652;
            this.scrollBarPCA9685_1_C2.Value = 1;
            this.scrollBarPCA9685_1_C2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollBarPCA9685_1_C2_Scroll);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lbPCA9685_1_C1);
            this.groupBox6.Controls.Add(this.scrollBarPCA9685_1_C1);
            this.groupBox6.Location = new System.Drawing.Point(28, 37);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(327, 62);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Channel 1";
            // 
            // lbPCA9685_1_C1
            // 
            this.lbPCA9685_1_C1.AutoSize = true;
            this.lbPCA9685_1_C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPCA9685_1_C1.Location = new System.Drawing.Point(281, 30);
            this.lbPCA9685_1_C1.Name = "lbPCA9685_1_C1";
            this.lbPCA9685_1_C1.Size = new System.Drawing.Size(15, 15);
            this.lbPCA9685_1_C1.TabIndex = 654;
            this.lbPCA9685_1_C1.Text = "0";
            // 
            // scrollBarPCA9685_1_C1
            // 
            this.scrollBarPCA9685_1_C1.LargeChange = 1;
            this.scrollBarPCA9685_1_C1.Location = new System.Drawing.Point(15, 20);
            this.scrollBarPCA9685_1_C1.Maximum = 15;
            this.scrollBarPCA9685_1_C1.Name = "scrollBarPCA9685_1_C1";
            this.scrollBarPCA9685_1_C1.Size = new System.Drawing.Size(224, 27);
            this.scrollBarPCA9685_1_C1.TabIndex = 652;
            this.scrollBarPCA9685_1_C1.Value = 1;
            this.scrollBarPCA9685_1_C1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollBarPCA9685_1_C1_Scroll);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lbTemperature);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.lbHum);
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Location = new System.Drawing.Point(15, 442);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(378, 253);
            this.groupBox7.TabIndex = 659;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "SHT25";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Humidity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Temperature";
            // 
            // lbHum
            // 
            this.lbHum.AutoSize = true;
            this.lbHum.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHum.Location = new System.Drawing.Point(82, 71);
            this.lbHum.Name = "lbHum";
            this.lbHum.Size = new System.Drawing.Size(110, 37);
            this.lbHum.TabIndex = 0;
            this.lbHum.Text = "lbHum";
            // 
            // lbTemperature
            // 
            this.lbTemperature.AutoSize = true;
            this.lbTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTemperature.Location = new System.Drawing.Point(77, 199);
            this.lbTemperature.Name = "lbTemperature";
            this.lbTemperature.Size = new System.Drawing.Size(225, 37);
            this.lbTemperature.TabIndex = 1;
            this.lbTemperature.Text = "lbTemperature";
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmBostonDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1664, 1103);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.GroupBox1);
            this.Name = "frmBostonDemo";
            this.Text = "Demo ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmI2CS_FormClosing);
            this.Load += new System.EventHandler(this.frmI2CS_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numAddress)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.NumericUpDown numPort;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.NumericUpDown numAddress;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lbPCA9685_1_C1;
        private System.Windows.Forms.HScrollBar scrollBarPCA9685_1_C1;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label lbPCA9685_1_C4;
        private System.Windows.Forms.HScrollBar scrollBarPCA9685_1_C4;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label lbPCA9685_1_C3;
        private System.Windows.Forms.HScrollBar scrollBarPCA9685_1_C3;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label lbPCA9685_1_C2;
        private System.Windows.Forms.HScrollBar scrollBarPCA9685_1_C2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lbTemperature;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbHum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}