using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage_Polymorphisme
{
    class Personne
    {

        public string Nom { get; set; }
        public DateTime DateNaissance { get; set; }
        public Personne(string Nom)
        {
            this.Nom = Nom;
            this.DateNaissance = DateTime.Now;
        }
        public override string ToString()
        {
            base.ToString();
            return this.Nom + "" + this.DateNaissance;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
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
        public virtual string Presentation()
        {
            return $"je suis personne et je m'appelle {this.Nom}";
        }
    }
}
