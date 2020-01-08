using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3
{
    public partial class TP3 : Form
    {
        public TP3()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime Date1 = Convert.ToDateTime(DTP.Text);

            Date1 = DTP.Value;
            MessageBox.Show(Date1.ToShortDateString());
        }

        private void Btn_SOT_Click(object sender, EventArgs e)
        {
            this.DTP.Value = DateTime.Now;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
