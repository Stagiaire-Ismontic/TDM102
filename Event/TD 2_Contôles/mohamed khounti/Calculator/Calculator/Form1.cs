using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            try
            {
                
                float result = float.Parse(txtb_number1.Text) + float.Parse(txtb_number2.Text);
                lbl_result.Text = "result : "+ result.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("enter a valid number","error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                
                
            }
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                float result = float.Parse(txtb_number1.Text) + float.Parse(txtb_number2.Text);
                lbl_result.Text = "result : " + result.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("enter a valid number", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                float result = float.Parse(txtb_number1.Text) - float.Parse(txtb_number2.Text);
                lbl_result.Text = "result : " +  result.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("enter a valid number", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                float result = float.Parse(txtb_number1.Text) / float.Parse(txtb_number2.Text);
                

                lbl_result.Text = "result : " +  result.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("enter a valid number", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                float result = float.Parse(txtb_number1.Text) * float.Parse(txtb_number2.Text);
                lbl_result.Text = "result : " + result.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("enter a valid number", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
        }

        private void txtb_number1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

                double result = Math.Sqrt(double.Parse(txtb_number1.Text));
                lbl_result.Text = "result : " + result.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("enter a valid number", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
        }
    }
}
