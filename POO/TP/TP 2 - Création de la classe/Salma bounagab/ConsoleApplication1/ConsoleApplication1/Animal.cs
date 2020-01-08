using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   public class Animal
    {
        public string Nom { get; set; }
        public string Place { get; set; }


        public Animal(string nom)
        {
            Nom = nom;
        }

        public override string ToString()
        {
            return "Animal :" + this.Nom + " " + this.Place;
        }

        public override bool Equals(object obj)
        {
            Animal animal = obj as Animal;
            if (this.Nom == animal.Nom) return true;
            else
            {
                return false;
            }
        }
    }
}
