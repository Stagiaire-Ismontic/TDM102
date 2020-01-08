using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TD3
{
    public partial class Birthday : Form
    {
        public Birthday()
        {
            InitializeComponent();
        }

      

        private void okbtt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Votre Date de naissance et le: "+this.dateTimePicker1.Text);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void resertbtt_Click(object sender, EventArgs e)
        {
            this.dateTimePicker1.Value = DateTime.Now;

        }
    }
}
