using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage_Polymorphisme
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne L1 = new Buyer("Chaaibi");
            Personne B2 = new Seller("Habaoui");

            Console.WriteLine(L1.Presentation());
            Console.WriteLine(B2.Presentation());

            Console.ReadKey();
            
        }
    }
}
