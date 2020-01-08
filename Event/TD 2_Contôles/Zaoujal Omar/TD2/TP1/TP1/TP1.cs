using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class TP1 : Form
    {
        public TP1()
        {
            InitializeComponent();
            this.Text = "Omar Zaoujal - TP1";
        }





        private void TP1_Scroll(object sender, ScrollEventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void TP1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("hello everyone !!");
        }



        private void TP1_ResizeBegin(object sender, EventArgs e)
        {
            MessageBox.Show("Move");
        }

        private void TP1_ResizeEnd(object sender, EventArgs e)
        {
            MessageBox.Show("Your moving's succesfuly ");
        }

        private void TP1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("wolcome all !!!");
        }

        private void button_Click(object sender, EventArgs e)
        {

        }

        private void TP1_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
