using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AnyI2C;


namespace PluginDemo
{



    public partial class frmIO : Form
    {
        CommInterface CommObj = null;
        public frmIO()
        {
            InitializeComponent();
        } 

        private void frmIO_Load(object sender, EventArgs e)
        {

        }

        public void Attach(CommInterface com)
        {
            CommObj = com;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(CommObj !=null)
            {
                byte[] data = CommObj.Send(new byte[] { 0x41 }, 1);
                if (data != null)
                {
                    label1.Text = "sss";
                }
            }

        }

        

    }


    public class MyGUI : GuiInterface
    {
        public void Show(CommInterface com)
        {
            frmIO frm = new frmIO();
            frm.Attach(com);
            frm.ShowDialog();
        }
    }
}
