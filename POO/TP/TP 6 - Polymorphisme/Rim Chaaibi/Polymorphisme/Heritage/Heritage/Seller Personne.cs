using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class Seller_Personne
    {
        public Seller_Personne (string Nom):base(Nom)
        {

        }
        public override string ToString()
        {
            // méthode 2: concaténation
            return $"seller {this.Nom} {this.DateNaissance}";
        }

        public override bool Equals(object obj)
        {
            Seller_Personne personne = obj as Seller_Personne;
            if (this.name == personne.Nom) ;
                return true;
            else
            {
                return false;
            }
        }

        public override string Presentation()
        {
            return $"Je suis Seller et je m'appele {this.Nom}";
        }
    }
}
    }
}
