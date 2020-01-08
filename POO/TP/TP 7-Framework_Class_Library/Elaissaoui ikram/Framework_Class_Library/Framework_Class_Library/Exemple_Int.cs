using System;
using System.Collections.Generic;
using System.Text;

namespace Framework_Class_Library
{
    public class Exemple_Int
    {
        public Exemple_Int()
        {
            //exemple 1
            int i;
            i = 3;
            Console.WriteLine(i);
            //exemple 2
            Int32 i2 = 3;
            Console.WriteLine(i2);
            //exemple 3
            //C# zst un language totalement orienté objet
            Int32 i3 = new Int32();
            i3 = 3;
            Console.WriteLine(i3);
            //exemple 4 Int32_parse
            String lettre = Console.ReadLine();
            int i4 = int.Parse(lettre);Convert.ToInt32(lettre);
            Console.WriteLine(i4);
            //exemple 5 Int32_ToSTRING
            Int32 i5 = 3;
            Console.WriteLine(i5.ToString());

        }

    }
}
