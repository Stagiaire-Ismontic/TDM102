using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP02
{
    public partial class Calculatris : Form
    {
        public Calculatris()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_N2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lbl3.Text = Calcul.Addition(txt1.Text, txt2.Text).ToString();
        }

        private void Calculatris_Resize(object sender, EventArgs e)
        {
            MessageBox.Show("not possible Resize");
        }

        private void Lbl3_Click(object sender, EventArgs e)
        {

        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            Lbl3.Text = Calcul.Subtraction(txt1.Text, txt2.Text).ToString();
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            Lbl3.Text = Calcul.multiiplication(txt1.Text, txt2.Text).ToString();
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            Lbl3.Text = Calcul.Division(txt1.Text, txt2.Text).ToString();
        }
    }
}
