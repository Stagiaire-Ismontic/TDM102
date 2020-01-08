using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TD1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "This is my application";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you clicked on my app!!");
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            MessageBox.Show("you moved my app!!");
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            MessageBox.Show("the mouse left my app!!");
        }
    }
}
