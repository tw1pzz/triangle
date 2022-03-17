using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programm15._03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);
            int x = a + b;
            int y = a + c;
            int z = c + b;
            if (x > c && y > b && z > a)
            {
                MessageBox.Show("Треугольник реализуется ");
            }
            else { MessageBox.Show("Треугольник не реализуется "); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);
            int x = a + b;
            int y = a + c;
            int z = c + b;
            if (x > c && y > b && z > a)
            {
                if (a == b && a == c && b == c)
                {
                    MessageBox.Show("Треугольник равносторонний ");
                    return;
                }
                if (a == b || a == c || b == c)
                {
                    MessageBox.Show("Треугольник равнобедренных ");
                }
                else { MessageBox.Show("Треугольник разносторонний "); }
            }
            else { MessageBox.Show("Треугольник не реализуется "); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);
            int x = a + b;
            int y = a + c;
            int z = c + b;
            if (x > c && y > b && z > a)
            {
                float p = (a + b + c) / 2;
                float s = (float)Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                s = (float)Math.Round(s, 2);
                label6.Text = Convert.ToString(s);
                label7.Text = Convert.ToString(p);
            }
            else { MessageBox.Show("Треугольник не реализуется "); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);
            int x = a + b;
            int y = a + c;
            int z = c + b;
            if (x > c && y > b && z > a)
            {
                if (a * a == b * b + c * c || b * b == c * c + a * a || c * c == a * a + b * b)
                {
                    MessageBox.Show("прямоугольный");
                }
                if (a * a > b * b + c * c || c * c > a * a + b * b || b * b > a * a + c * c)
                {
                    MessageBox.Show("тупоугольный");
                }
                else
                {
                    MessageBox.Show("остроугольный");
                }
            }
            else { MessageBox.Show("Треугольник не реализуется "); }
        }
    }
}
