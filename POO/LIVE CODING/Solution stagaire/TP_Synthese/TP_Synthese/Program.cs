using System;
using System.Text;
using System.Collections.Generic;

namespace TP_Synthese
{
    class Program
    {
        static void Main(string[] args)
        {
            Habit habit = new Habit(94894, 400, 5000, 2000, 98, "Rouge");
            habit.aprovisionner(300);
            Electroménager electroménager = new Electroménager(48447, 45, 1500, 800, 46.5,12);
            electroménager.achat(10);
            electroménager.datefinGarantie();
            Console.WriteLine(electroménager);
        }
    }
}
