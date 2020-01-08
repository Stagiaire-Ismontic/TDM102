using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp3
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

        private void lbl_sign_in_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }


        private void date_sign_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pnl_research_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_sign_Click(object sender, EventArgs e)
        {
            new Student(name_sign.Text, DateTime.Parse(date_sign.Value.ToString()));

        }

        private void btn_research_Click(object sender, EventArgs e)
        {
            try
            {
                txt_resault.Text = Student.Research(txt_name_research.Text);
            }
            catch (NullReferenceException)
            {
                txt_resault.Text = "Name not found";
            }
       
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
