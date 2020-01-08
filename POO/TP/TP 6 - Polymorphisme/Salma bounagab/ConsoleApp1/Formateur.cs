using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeritagePolymorphisme
{
    public class Formateur : Personne 
    {
        public Formateur(string _Nom) : base(_Nom)
        {

        }
        public override string ToString()
        {
            // méthode 2: concaténation
            return "formateur : "+this.Nom + "Date de Naissance : "+this.DateNaissance;
        }

        public override bool Equals(object obj)
        {
            Personne personne = obj as Personne;
            if (this.Nom == personne.Nom) return true;
            else
            {
                return false;
            }
        }

        public override string Presentation()
        {
            return "Je suis Formateur et je m'appele : "+this.Nom;
        }
    }
}