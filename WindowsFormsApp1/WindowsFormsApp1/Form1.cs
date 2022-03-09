using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public event SendText OnSentFrom1to2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

     

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.OnSentFrom2to1 += s => textBox1.Text = s;
            form2.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            OnSentFrom1to2?.Invoke(textBox1.Text);
            textBox1.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
