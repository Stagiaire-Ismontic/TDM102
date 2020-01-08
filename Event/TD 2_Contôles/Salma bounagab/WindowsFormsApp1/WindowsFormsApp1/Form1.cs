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
    public partial class WindowsFormsApp1 : Form
    {
        public WindowsFormsApp1()
        {
            InitializeComponent();
        }

        private void lbl_result_Click(object sender, EventArgs e)
        {

        }


        private void btn_addition_Click(object sender, EventArgs e)
        {
            float a = float.Parse(tbx_1.Text);
            float b = float.Parse(tbx_2.Text);
            lbl_result.Text = (a + b).ToString();

        }

        private void btn_soustraction_Click(object sender, EventArgs e)
        {
            float a = float.Parse(tbx_1.Text);
            float b = float.Parse(tbx_2.Text);
            lbl_result.Text = (a - b).ToString();

        }

        private void btn_multiplication_Click(object sender, EventArgs e)
        {
            float a = float.Parse(tbx_1.Text);
            float b = float.Parse(tbx_2.Text);
            lbl_result.Text = (a * b).ToString();

        }

        private void btn_division_Click(object sender, EventArgs e)
        {
            float a = float.Parse(tbx_1.Text);
            float b = float.Parse(tbx_2.Text);
            lbl_result.Text = (a / b).ToString();
        }







    }
}
