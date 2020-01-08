using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP02
{
   static public class Calcul
    {
        static public double Addition(string a,string b)
        {
            double result = 0;
            try
            {
                result = double.Parse(a) + double.Parse(b);
            }
            catch(FormatException e)
            {
                MessageBox.Show(e.Message, "error, try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
    
    static public double Subtraction(string a, string b)
        {
            double result = 0;
            try
            {
                result = double.Parse(a) - double.Parse(b);
            }
            catch (FormatException e)
            {
                MessageBox.Show(e.Message, "error, try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
    
    static public double multiiplication(string a, string b)
        {
            double result = 0;
            try
            {
                result = double.Parse(a) * double.Parse(b);
            }
            catch (FormatException e)
            {
                MessageBox.Show(e.Message, "error, try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
        static public double Division(string a, string b)
        {
            double result = 0;
            try
            {
                result = double.Parse(a) / double.Parse(b);
            }
            catch (FormatException e)
            {
                MessageBox.Show(e.Message, "error, try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
    }
}
