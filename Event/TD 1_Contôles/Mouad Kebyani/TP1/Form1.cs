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
    public partial class Appwintest : Form
    {
        public Appwintest()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "App wintest";
        }

        private void Appwintest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("App wintest");
        }

        private void Appwintest_Resize(object sender, EventArgs e)
        {
            MessageBox.Show("App wintest");
        }

        private void Appwintest_Move(object sender, EventArgs e)
        {
            MessageBox.Show("App wintest");
        }
    }
}
