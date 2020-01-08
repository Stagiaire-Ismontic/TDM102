using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txt_result.Text= Calculator.Addition(Txt_1.Text,Txt_2.Text).ToString();
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_result.Text = Calculator.Subtraction(Txt_1.Text, Txt_2.Text).ToString();
        }
        private void btn_3_Click(object sender, EventArgs e)
        {
            txt_result.Text = Calculator.Multiplication(Txt_1.Text, Txt_2.Text).ToString();
        }
        private void btn_4_Click(object sender, EventArgs e)
        {
            txt_result.Text = Calculator.Division(Txt_1.Text, Txt_2.Text).ToString();
        }

        private void Txt_2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
