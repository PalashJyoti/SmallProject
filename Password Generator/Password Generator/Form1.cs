using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void Generate(int len)
        {
            const string validChar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ123456789~`!@#$%^&*()_-+={[}]|\"\\:;'<,>.?/'";
            StringBuilder result = new StringBuilder();
            Random rand = new Random();
            while (0 < len--)
            {
                result.Append(validChar[rand.Next(validChar.Length)]);
            }
            textBox1.Text = result.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int len = 6;
            /*const string validChar="abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ123456789~`!@#$%^&*()_-+={[}]|\"\\:;'<,>.?/'";
            StringBuilder result = new StringBuilder();
            Random rand = new Random(); 
            while(0<len--)
            {
                result.Append(validChar[rand.Next(validChar.Length)]);
            }
            textBox1.Text = result.ToString();*/
            if(checkBox1.Checked)
            {
                Generate(8);
            }
            else if(checkBox2.Checked)
            {
                Generate(10);
            }
            else if(checkBox3.Checked)
            {
                Generate(12);
            }
        }
    }
}
