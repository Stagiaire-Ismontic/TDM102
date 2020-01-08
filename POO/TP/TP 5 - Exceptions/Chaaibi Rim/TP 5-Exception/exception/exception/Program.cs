using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            //Exemple
            try
            {
                Console.WriteLine("Donnez un nombre:");
                string nombre = Console.ReadLine();
                i = int.Parse(nombre);
                int k = 5;
                i = k;
                Console.WriteLine();
            }
            catch (DivideByZeroException);
            {
                Console.WriteLine(string.Format("il y a un erreur:{1}"));
                Console.WriteLine("il y a un erreur dans la saisie du nombre, veuillez entrer un nombre valide");
                Console.WriteLine(string.Format("il y a un erreur:{1}"));
                i = 10;
            }
            Finally;
                {
                Console.WriteLine("fin de programme");
                //Exemple 2
                //Console.WriteLine("i = " + i);
                Console.ReadLine();




            }

            }
     }
 }