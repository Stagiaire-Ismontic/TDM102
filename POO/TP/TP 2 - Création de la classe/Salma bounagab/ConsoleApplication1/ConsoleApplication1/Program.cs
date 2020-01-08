using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal("tiger");
            Mamiphere m1 = new Mamiphere("cat");

            Console.WriteLine(a1);
            Console.WriteLine(m1);

            Console.ReadKey();
        }
    }
}
