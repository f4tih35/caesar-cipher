using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caesar_Cipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        EncodeDecode encrypt = new EncodeDecode();
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
            richTextBox2.Text = encrypt.encode(richTextBox1.Text, Convert.ToInt32(maskedTextBox1.Text));
        }
    }
}