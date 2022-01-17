using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        private float a, result;
        private int count;
        private bool isPositive = true;

        public Form1()
        {
            InitializeComponent();
        }

        // C - Button

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Switch Positive and Negative

        private void button3_Click(object sender, EventArgs e)
        {
            isPositive = !isPositive;

            if (isPositive)
                textBox1.Text = (float.Parse(textBox1.Text) * -1).ToString();
            else
                textBox1.Text = (float.Parse(textBox1.Text) * -1).ToString();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        #region Buttons
        // 0

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        // 1

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        // 2

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        // 3

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        // 4

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        // 6

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        // 7

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        // 8

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        // 9

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        // 5

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        // DOT

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        // Erase

        private void button2_Click(object sender, EventArgs e)
        {
            int length = textBox1.Text.Length - 1;
            string bufferText = textBox1.Text;
            textBox1.Clear();

            for (int i = 0; i < length; i++)
            {
                textBox1.Text = textBox1.Text + bufferText[i];
            }
            
        }

        #endregion

        #region Logic
        // Operation addition

        private void button16_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
                return;

            a = float.Parse(textBox1.Text);

            textBox1.Clear();
            count = 1;
            label1.Text = a.ToString() + "+";
            isPositive = true;
        }

        // Operation minus

        private void button17_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
                return;

            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            label1.Text = a.ToString() + "-";
            isPositive = !true;
        }

        // Operation multiply

        private void button18_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
                return;

            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            label1.Text = a.ToString() + "*";
            isPositive = !true;
        }

        // Operation Division

        private void button19_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
                return;

            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            label1.Text = a.ToString() + "/";
            isPositive = !true;
        }

        private void DisplayResult() 
        {
            label1.Text = "";
            textBox1.Text = result.ToString();
        }

        private void Calculate() 
        {
            switch(count) 
            {
                case 1:
                    result = a + float.Parse(textBox1.Text);
                break;

                case 2:
                    result = a - float.Parse(textBox1.Text);
                break;

                case 3:
                    result = a * float.Parse(textBox1.Text);
                break;

                case 4:
                if (float.Parse(textBox1.Text) == 0) 
                {
                    label1.Text = "Error!";
                    return;
                }

                    result = a / float.Parse(textBox1.Text);
                break;
                
                default:
                break;
            }

            DisplayResult();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        #endregion

       
    }
}
