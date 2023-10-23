using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        int i = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            if (i <= 4)
            {
                int qad = int.Parse(textBox1.Text);
                int j = j + qad;
                listBox1.Items.Add(qad);
                i++;
                label1.Text = (j/i).ToString();
            }
            else
            {
                MessageBox.Show("20 qad geraftam!!!!");
            }
        }
    }
}
