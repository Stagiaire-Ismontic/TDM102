using System;
using System.Collections.Generic;
using Exemple_exception_m.Exceptions;

namespace Exemple_exception_m
{
    class Facebook
    {
        private string myVar;
        List<string> Alphabet = new List<string> { "A", "B", "C", "D", "E", "F", "G", "H", "I", "G", "K", "L", "M", "N", "O", "P",
            "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        public string Password
        {
            get { return myVar; }
            set
            {
                if (value.Length > 4)
                {
                    throw new ArgumentOutOfRangeException();
                }
                foreach (string item in Alphabet)
                {
                    if (value.StartsWith(item)) ;
                    throw new StartWithAlphabtExepction("password is not accepted : you should not start with a lettre");
                         

                }

                    myVar = value; 
            }
        }
        public Facebook(string Password)
        {
            this.Password = Password;
        }
    

        

    }
}
