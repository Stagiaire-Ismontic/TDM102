using System;
using System.Collections.Generic;
using Exemple_exception_m.Exceptions;

namespace Exemple_exception_m
{
    class Program
    {
        static void Main(string[] args)
        {
            Facebook facebook;
            string Input;
            try
            {
                Console.Write("Enter your password : ");

                    Input = Console.ReadLine();
                facebook = new Facebook(Input);
            }
            catch (StartWithAlphabtExepction)
            {
                {

                    Console.WriteLine("password is not accepted : you should not start with a lettre");
                }

            }
            catch (Exception)
            {
               
                {
                    Console.WriteLine("password is not accepted : you should use less than 5 characters");

                }

              }


                


            finally
            {
                Console.WriteLine("Thanks for using our programe");
            }
            {
                Console.ReadKey();
            }
        }
    }
}
