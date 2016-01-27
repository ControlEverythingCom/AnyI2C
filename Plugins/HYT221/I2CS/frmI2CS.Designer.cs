namespace HYT221_I2CS
{
    partial class frmI2CS
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numAddress = new System.Windows.Forms.NumericUpDown();
            this._ERROR = new System.Windows.Forms.Label();
            this.btnReadCh0 = new System.Windows.Forms.Button();
            this.lbCh0 = new System.Windows.Forms.Label();
            this.tempc = new System.Windows.Forms.Label();
            this.lbCh1 = new System.Windows.Forms.Label();
            this.humRh = new System.Windows.Forms.Label();
            this.humidity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAddress)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numAddress);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 68);
            this.groupBox1.TabIndex = 491;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hardware Address";
            // 
            // numAddress
            // 
            this.numAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.numAddress.Location = new System.Drawing.Point(11, 21);
            this.numAddress.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numAddress.Name = "numAddress";
            this.numAddress.Size = new System.Drawing.Size(82, 35);
            this.numAddress.TabIndex = 0;
            this.numAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numAddress.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // _ERROR
            // 
            this._ERROR.BackColor = System.Drawing.Color.Red;
            this._ERROR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this._ERROR.Location = new System.Drawing.Point(9, 102);
            this._ERROR.Name = "_ERROR";
            this._ERROR.Size = new System.Drawing.Size(290, 63);
            this._ERROR.TabIndex = 492;
            this._ERROR.Text = "ERROR: Device did Not Respond";
            this._ERROR.Visible = false;
            // 
            // btnReadCh0
            // 
            this.btnReadCh0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReadCh0.Location = new System.Drawing.Point(335, 24);
            this.btnReadCh0.Name = "btnReadCh0";
            this.btnReadCh0.Size = new System.Drawing.Size(249, 29);
            this.btnReadCh0.TabIndex = 493;
            this.btnReadCh0.Text = "Read ";
            this.btnReadCh0.UseVisualStyleBackColor = true;
            this.btnReadCh0.Click += new System.EventHandler(this.btnReadCh0_Click);
            // 
            // lbCh0
            // 
            this.lbCh0.AutoSize = true;
            this.lbCh0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbCh0.Location = new System.Drawing.Point(470, 114);
            this.lbCh0.Name = "lbCh0";
            this.lbCh0.Size = new System.Drawing.Size(23, 16);
            this.lbCh0.TabIndex = 494;
            this.lbCh0.Text = "---";
            // 
            // tempc
            // 
            this.tempc.AutoSize = true;
            this.tempc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.tempc.Location = new System.Drawing.Point(543, 114);
            this.tempc.Name = "tempc";
            this.tempc.Size = new System.Drawing.Size(18, 16);
            this.tempc.TabIndex = 495;
            this.tempc.Text = "C";
            // 
            // lbCh1
            // 
            this.lbCh1.AutoSize = true;
            this.lbCh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbCh1.Location = new System.Drawing.Point(470, 152);
            this.lbCh1.Name = "lbCh1";
            this.lbCh1.Size = new System.Drawing.Size(23, 16);
            this.lbCh1.TabIndex = 496;
            this.lbCh1.Text = "---";
            // 
            // humRh
            // 
            this.humRh.AutoSize = true;
            this.humRh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humRh.Location = new System.Drawing.Point(530, 154);
            this.humRh.Name = "humRh";
            this.humRh.Size = new System.Drawing.Size(43, 16);
            this.humRh.TabIndex = 497;
            this.humRh.Text = "%RH";
            // 
            // humidity
            // 
            this.humidity.AutoSize = true;
            this.humidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidity.Location = new System.Drawing.Point(336, 152);
            this.humidity.Name = "humidity";
            this.humidity.Size = new System.Drawing.Size(68, 16);
            this.humidity.TabIndex = 498;
            this.humidity.Text = "Humidity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 499;
            this.label1.Text = "Temperature";
            // 
            // frmI2CS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 196);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.humidity);
            this.Controls.Add(this.humRh);
            this.Controls.Add(this.lbCh1);
            this.Controls.Add(this.tempc);
            this.Controls.Add(this.lbCh0);
            this.Controls.Add(this.btnReadCh0);
            this.Controls.Add(this._ERROR);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmI2CS";
            this.Text = "HYT221 Control Panel";
            this.Load += new System.EventHandler(this.frmI2CS_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numAddress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.NumericUpDown numAddress;
        internal System.Windows.Forms.Label _ERROR;
        internal System.Windows.Forms.Button btnReadCh0;
        internal System.Windows.Forms.Label lbCh0;
        internal System.Windows.Forms.Label tempc;
        internal System.Windows.Forms.Label lbCh1;
        private System.Windows.Forms.Label humRh;
        internal System.Windows.Forms.Label humidity;
        internal System.Windows.Forms.Label label1;


    }
}