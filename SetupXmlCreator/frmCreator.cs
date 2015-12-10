using System;
using System.Xml;
using System.Xml.Serialization;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Schema;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace SetupXmlCreator
{
    public partial class frmCreator : Form
    {
        public frmCreator()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            ArrayList devices = new ArrayList();
            var files = Directory.EnumerateFiles(".", "*I2C*.dll");
            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb3 = new StringBuilder();
            foreach (var d in files)
            {
                string filename = Path.GetFileName(d);
                string componentName = filename.Replace(".", "");
                string str1 = string.Format("<Component Id=\"{0}\" Guid=\"*\">", componentName );
                string str2 = string.Format("<File Id=\"{0}\" Name=\"{1}\" DiskId=\"1\" Source=\"{1}\" KeyPath=\"yes\"></File>", componentName, filename );
                string str3 = "</Component>";
                sb1.AppendLine(str1);
                sb1.AppendLine(str2);
                sb1.AppendLine(str3);
                string str4 = string.Format("      <ComponentRef Id=\"{0}\" />", componentName);
                sb3.AppendLine(str4);
                Debug.Print(filename);
            }
            textBox1.Text = sb1.ToString();

            files = Directory.EnumerateFiles(".\\Data", "*I2C*.xml");
            StringBuilder sb2 = new StringBuilder();
            foreach (var d in files)
            {
                string filename = Path.GetFileName(d);
                string componentName = filename.Replace(".", "");
                string str1 = string.Format("<Component Id=\"{0}\" Guid=\"*\">", componentName);
                string str2 = string.Format("<File Id=\"{0}\" Name=\"{1}\" DiskId=\"1\" Source=\"Data\\{1}\" KeyPath=\"yes\"></File>", componentName, filename);
                string str3 = "</Component>";
                sb2.AppendLine(str1);
                sb2.AppendLine(str2);
                sb2.AppendLine(str3);
                string str4 = string.Format("      <ComponentRef Id=\"{0}\" />", componentName);
                sb3.AppendLine(str4);
                Debug.Print(filename);
            }
            textBox1.Text = sb1.ToString();
            textBox2.Text = sb2.ToString();
            textBox3.Text = sb3.ToString();
        }
    }
}
