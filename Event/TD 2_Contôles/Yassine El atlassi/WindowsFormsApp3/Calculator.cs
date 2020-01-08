using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    static public class Calculator
    {
        static public double Addition(string A,string B)
        {
            double result = 0;
            try
            {
                result = double.Parse(A) + double.Parse(B);
            }
            catch (FormatException e)
            {
                MessageBox.Show(e.Message,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return result;
        }
        static public double Subtraction(string A, string B)
        {
            double result=0;
            try
            {
                result=double.Parse(A) - double.Parse(B);
            }
            catch (FormatException e)
            {
                MessageBox.Show(e.Message,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return result;
        }
        static public double Multiplication(string A, string B)
        {
            double result = 0;
            try
            {
                result = double.Parse(A) * double.Parse(B);
            }
            catch (FormatException e)
            {
                MessageBox.Show(e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
        static public double Division(string A, string B)
        {
            double result = 0;
            try
            {
                result = double.Parse(A) / double.Parse(B);
            }
            catch (FormatException e)
            { 
              MessageBox.Show(e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
    }
}
