using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_number2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                float result = float.Parse(txt_1.Text) + float.Parse(txt_2.Text);

                lbl_Result.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("please enter numbers only");

            }
        }

        private void n1_TextChanged(object sender, EventArgs e)
        {
        }

        private void lbl_Result_Click(object sender, EventArgs e)
        {
   
        }

        private void btt_Multiply_Click(object sender, EventArgs e)
        {
            try
            {
                float result = float.Parse(txt_1.Text) * float.Parse(txt_2.Text);

                lbl_Result.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("please enter numbers only");

            }

        }

        private void btt_Substract_Click(object sender, EventArgs e)
        {
            try
            {
                float result = float.Parse(txt_1.Text) - float.Parse(txt_2.Text);

                lbl_Result.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("please enter numbers only");

            }

        }

        private void btt_divid_Click(object sender, EventArgs e)
        {
            try
            {
                float result = float.Parse(txt_1.Text) / float.Parse(txt_2.Text);

                lbl_Result.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("please enter numbers only");

            }
        }
    }
}
