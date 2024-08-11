using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace encrypter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = AesOperation.EncryptString("b14ca5898a4e4133bbce2ea2315a1916", textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = AesOperation.DecryptString("b14ca5898a4e4133bbce2ea2315a1916", textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToString();
        }
    }
}
