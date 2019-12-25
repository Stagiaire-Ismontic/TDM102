﻿using System;
using System.Collections.Generic;
using System.Text;

namespace heritage
{
    public class Patient:Personne
    {
        public Patient(string Nom):base(Nom)
        {

        }
        public override string ToString()
        {
            return "Patient :" + this.Nom + " " + this.DateNaissance;
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
    }
}
