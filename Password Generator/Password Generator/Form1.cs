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
        string password;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void Generate(int len)
        {
            const string validChar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789~`!@#$%^&*()_-+={[}]|\"\\:;'<,>.?/'";
            StringBuilder result = new StringBuilder();
            Random rand = new Random();
            while (0 < len--)
            {
                result.Append(validChar[rand.Next(validChar.Length)]);
            }
            textBox1.Text = result.ToString();
        }

        public void Check()
        {
            int l = 0, u = 0, n = 0, s = 0, t = 0;
            const string lower = "abcdefghijklmnopqrstuvwxyz";
            const string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string number = "0123456789";
            const string sign = "~`!@#$%^&*()_-+={[}]|\"\\:;'<,>.?/'";
            for (int i=0;i<password.Length;i++)
            {
                char[] a = password.ToCharArray();
                if(lower.Contains(a[i]))
                {
                    l = 1;
                }
                if (upper.Contains(a[i]))
                {
                    u = 1;
                }
                if (number.Contains(a[i]))
                {
                    n = 1;
                }
                if (sign.Contains(a[i]))
                {
                    s = 1;
                }
            }
            t = l + u + s + n;
            if (t==4)
            {
                label4.Visible = true;
                label2.Visible = false;
                label3.Visible = false;
            }
            else if(t==3)
            {
                label3.Visible = true;
                label2.Visible = false;
                label4.Visible = false;
            }
            else if(t==1||t==2)
            {
                label2.Visible = true;
                label3.Visible = false;
                label4.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(radioButton1.Checked)
            {
                Generate(8);
            }
            else if(radioButton2.Checked)
            {
                Generate(10);
            }
            else if(radioButton3.Checked)
            {
                Generate(12);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            password = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }
    }
}