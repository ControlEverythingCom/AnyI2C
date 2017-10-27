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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.numAddress = new System.Windows.Forms.NumericUpDown();
            this.scrollbarFreq = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lbFreq = new System.Windows.Forms.Label();
            this.groupPWM1 = new System.Windows.Forms.GroupBox();
            this.scrollbarOn = new System.Windows.Forms.HScrollBar();
            this.lbOn = new System.Windows.Forms.Label();
            this.scrollBarOff = new System.Windows.Forms.HScrollBar();
            this.lbOff = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbLed = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.scrollBarPCA9685_1_C1 = new System.Windows.Forms.HScrollBar();
            this.lbPCA9685_1_C1 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lbPCA9685_1_PWM = new System.Windows.Forms.Label();
            this.scrollBarPCA9685_1PWM = new System.Windows.Forms.HScrollBar();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lbPCA9685_1_C2 = new System.Windows.Forms.Label();
            this.scrollBarPCA9685_1_C2 = new System.Windows.Forms.HScrollBar();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.lbPCA9685_1_C3 = new System.Windows.Forms.Label();
            this.scrollBarPCA9685_1_C3 = new System.Windows.Forms.HScrollBar();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.lbPCA9685_1_C4 = new System.Windows.Forms.Label();
            this.scrollBarPCA9685_1_C4 = new System.Windows.Forms.HScrollBar();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddress)).BeginInit();
            this.groupPWM1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
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
            // scrollbarFreq
            // 
            this.scrollbarFreq.LargeChange = 1;
            this.scrollbarFreq.Location = new System.Drawing.Point(39, 37);
            this.scrollbarFreq.Maximum = 255;
            this.scrollbarFreq.Minimum = 1;
            this.scrollbarFreq.Name = "scrollbarFreq";
            this.scrollbarFreq.Size = new System.Drawing.Size(179, 18);
            this.scrollbarFreq.TabIndex = 652;
            this.scrollbarFreq.Value = 1;
            this.scrollbarFreq.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarPCS0_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(381, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 653;
            this.label1.Text = "LED";
            // 
            // lbFreq
            // 
            this.lbFreq.AutoSize = true;
            this.lbFreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFreq.Location = new System.Drawing.Point(263, 40);
            this.lbFreq.Name = "lbFreq";
            this.lbFreq.Size = new System.Drawing.Size(15, 15);
            this.lbFreq.TabIndex = 654;
            this.lbFreq.Text = "0";
            // 
            // groupPWM1
            // 
            this.groupPWM1.Controls.Add(this.lbFreq);
            this.groupPWM1.Controls.Add(this.scrollbarFreq);
            this.groupPWM1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPWM1.Location = new System.Drawing.Point(12, 111);
            this.groupPWM1.Name = "groupPWM1";
            this.groupPWM1.Size = new System.Drawing.Size(305, 66);
            this.groupPWM1.TabIndex = 656;
            this.groupPWM1.TabStop = false;
            this.groupPWM1.Text = "PWM Freqence";
            // 
            // scrollbarOn
            // 
            this.scrollbarOn.LargeChange = 1;
            this.scrollbarOn.Location = new System.Drawing.Point(415, 111);
            this.scrollbarOn.Maximum = 4095;
            this.scrollbarOn.Name = "scrollbarOn";
            this.scrollbarOn.Size = new System.Drawing.Size(127, 17);
            this.scrollbarOn.TabIndex = 652;
            this.scrollbarOn.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollbarOn_Scroll);
            // 
            // lbOn
            // 
            this.lbOn.AutoSize = true;
            this.lbOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOn.Location = new System.Drawing.Point(562, 114);
            this.lbOn.Name = "lbOn";
            this.lbOn.Size = new System.Drawing.Size(15, 15);
            this.lbOn.TabIndex = 654;
            this.lbOn.Text = "0";
            // 
            // scrollBarOff
            // 
            this.scrollBarOff.LargeChange = 1;
            this.scrollBarOff.Location = new System.Drawing.Point(415, 169);
            this.scrollBarOff.Maximum = 4095;
            this.scrollBarOff.Name = "scrollBarOff";
            this.scrollBarOff.Size = new System.Drawing.Size(127, 17);
            this.scrollBarOff.TabIndex = 652;
            this.scrollBarOff.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollBarOff_Scroll);
            // 
            // lbOff
            // 
            this.lbOff.AutoSize = true;
            this.lbOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOff.Location = new System.Drawing.Point(562, 172);
            this.lbOff.Name = "lbOff";
            this.lbOff.Size = new System.Drawing.Size(15, 15);
            this.lbOff.TabIndex = 654;
            this.lbOff.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(380, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 15);
            this.label7.TabIndex = 654;
            this.label7.Text = "On";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(380, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 15);
            this.label8.TabIndex = 654;
            this.label8.Text = "Off";
            // 
            // cmbLed
            // 
            this.cmbLed.FormattingEnabled = true;
            this.cmbLed.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "All"});
            this.cmbLed.Location = new System.Drawing.Point(442, 32);
            this.cmbLed.Name = "cmbLed";
            this.cmbLed.Size = new System.Drawing.Size(121, 21);
            this.cmbLed.TabIndex = 657;
            this.cmbLed.SelectedIndexChanged += new System.EventHandler(this.cmbLed_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox10);
            this.groupBox5.Controls.Add(this.groupBox9);
            this.groupBox5.Controls.Add(this.groupBox8);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Location = new System.Drawing.Point(23, 204);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(382, 370);
            this.groupBox5.TabIndex = 658;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "PCA 9685 PWM";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lbPCA9685_1_C1);
            this.groupBox6.Controls.Add(this.scrollBarPCA9685_1_C1);
            this.groupBox6.Location = new System.Drawing.Point(28, 87);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(327, 62);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Channel 1";
            // 
            // scrollBarPCA9685_1_C1
            // 
            this.scrollBarPCA9685_1_C1.LargeChange = 1;
            this.scrollBarPCA9685_1_C1.Location = new System.Drawing.Point(15, 20);
            this.scrollBarPCA9685_1_C1.Maximum = 255;
            this.scrollBarPCA9685_1_C1.Minimum = 1;
            this.scrollBarPCA9685_1_C1.Name = "scrollBarPCA9685_1_C1";
            this.scrollBarPCA9685_1_C1.Size = new System.Drawing.Size(224, 27);
            this.scrollBarPCA9685_1_C1.TabIndex = 652;
            this.scrollBarPCA9685_1_C1.Value = 1;
            this.scrollBarPCA9685_1_C1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollBarPCA9685_1_C1_Scroll);
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
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lbPCA9685_1_PWM);
            this.groupBox7.Controls.Add(this.scrollBarPCA9685_1PWM);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(28, 19);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(327, 66);
            this.groupBox7.TabIndex = 656;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "PWM Freqence";
            // 
            // lbPCA9685_1_PWM
            // 
            this.lbPCA9685_1_PWM.AutoSize = true;
            this.lbPCA9685_1_PWM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPCA9685_1_PWM.Location = new System.Drawing.Point(281, 31);
            this.lbPCA9685_1_PWM.Name = "lbPCA9685_1_PWM";
            this.lbPCA9685_1_PWM.Size = new System.Drawing.Size(15, 15);
            this.lbPCA9685_1_PWM.TabIndex = 654;
            this.lbPCA9685_1_PWM.Text = "0";
            // 
            // scrollBarPCA9685_1PWM
            // 
            this.scrollBarPCA9685_1PWM.LargeChange = 1;
            this.scrollBarPCA9685_1PWM.Location = new System.Drawing.Point(15, 17);
            this.scrollBarPCA9685_1PWM.Maximum = 255;
            this.scrollBarPCA9685_1PWM.Minimum = 1;
            this.scrollBarPCA9685_1PWM.Name = "scrollBarPCA9685_1PWM";
            this.scrollBarPCA9685_1PWM.Size = new System.Drawing.Size(224, 37);
            this.scrollBarPCA9685_1PWM.TabIndex = 652;
            this.scrollBarPCA9685_1PWM.Value = 1;
            this.scrollBarPCA9685_1PWM.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollBarPCA9685_1PWM_Scroll);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lbPCA9685_1_C2);
            this.groupBox8.Controls.Add(this.scrollBarPCA9685_1_C2);
            this.groupBox8.Location = new System.Drawing.Point(28, 155);
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
            this.scrollBarPCA9685_1_C2.Maximum = 255;
            this.scrollBarPCA9685_1_C2.Minimum = 1;
            this.scrollBarPCA9685_1_C2.Name = "scrollBarPCA9685_1_C2";
            this.scrollBarPCA9685_1_C2.Size = new System.Drawing.Size(224, 27);
            this.scrollBarPCA9685_1_C2.TabIndex = 652;
            this.scrollBarPCA9685_1_C2.Value = 1;
            this.scrollBarPCA9685_1_C2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollBarPCA9685_1_C2_Scroll);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.lbPCA9685_1_C3);
            this.groupBox9.Controls.Add(this.scrollBarPCA9685_1_C3);
            this.groupBox9.Location = new System.Drawing.Point(28, 223);
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
            this.scrollBarPCA9685_1_C3.Maximum = 255;
            this.scrollBarPCA9685_1_C3.Minimum = 1;
            this.scrollBarPCA9685_1_C3.Name = "scrollBarPCA9685_1_C3";
            this.scrollBarPCA9685_1_C3.Size = new System.Drawing.Size(224, 27);
            this.scrollBarPCA9685_1_C3.TabIndex = 652;
            this.scrollBarPCA9685_1_C3.Value = 1;
            this.scrollBarPCA9685_1_C3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollBarPCA9685_1_C3_Scroll);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.lbPCA9685_1_C4);
            this.groupBox10.Controls.Add(this.scrollBarPCA9685_1_C4);
            this.groupBox10.Location = new System.Drawing.Point(28, 293);
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
            this.scrollBarPCA9685_1_C4.Maximum = 255;
            this.scrollBarPCA9685_1_C4.Minimum = 1;
            this.scrollBarPCA9685_1_C4.Name = "scrollBarPCA9685_1_C4";
            this.scrollBarPCA9685_1_C4.Size = new System.Drawing.Size(224, 27);
            this.scrollBarPCA9685_1_C4.TabIndex = 652;
            this.scrollBarPCA9685_1_C4.Value = 1;
            this.scrollBarPCA9685_1_C4.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollBarPCA9685_1_C4_Scroll);
            // 
            // frmBostonDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1664, 1103);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.cmbLed);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbOff);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbOn);
            this.Controls.Add(this.groupPWM1);
            this.Controls.Add(this.scrollBarOff);
            this.Controls.Add(this.scrollbarOn);
            this.Controls.Add(this.label1);
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
            this.groupPWM1.ResumeLayout(false);
            this.groupPWM1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.NumericUpDown numPort;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.NumericUpDown numAddress;
        private System.Windows.Forms.HScrollBar scrollbarFreq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbFreq;
        private System.Windows.Forms.GroupBox groupPWM1;
        private System.Windows.Forms.HScrollBar scrollbarOn;
        private System.Windows.Forms.Label lbOn;
        private System.Windows.Forms.HScrollBar scrollBarOff;
        private System.Windows.Forms.Label lbOff;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbLed;
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
        private System.Windows.Forms.Label lbPCA9685_1_PWM;
        private System.Windows.Forms.HScrollBar scrollBarPCA9685_1PWM;
    }
}