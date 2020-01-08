using System;
using System.Collections.Generic;
using System.Text;

namespace Creation_class
{
    class Projet
    {
        //variable-Attributs
        private String _Titre;
        private String _Description;
        public Projet(String Titre)
        {
            this._Titre = Titre;
        }
        //Construction par defaut
        public Projet() { }
        //Propriété
        public string Titre
        {
            set
            {
                _Titre = value;
            }
            get
            {
                return _Titre;
            }
        }
    }
}
