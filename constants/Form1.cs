using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace constants
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            double pi = 3.14159265389793;
            double c = 299792458;
            richTextBox1.AppendText(pi.ToString() + "\n");
            richTextBox1.AppendText(pi.ToString("0.0.0.0") + "\n");
            richTextBox1.AppendText(pi.ToString("0.00000") + "\n");
            richTextBox1.AppendText(pi.ToString("0.000000000000000") + "\n");
            richTextBox1.AppendText(c.ToString() + "\n");
            richTextBox1.AppendText(c.ToString("000,000,000") + "\n");
            richTextBox1.AppendText(c.ToString("E3") + "\n");
            string s = "3";
            int i = int.Parse(s);
            double d = double.Parse(pi);



       




        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
