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
    public delegate void SendText(string text);
    public partial class Form2 : Form
    {
        private Form1 parent;
        public event SendText OnSentFrom2to1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            parent = form1;
            parent.OnSentFrom1to2 += text => textBox1.Text = text;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OnSentFrom2to1?.Invoke(textBox1.Text);
            textBox1.Clear();
        }
    }
}
