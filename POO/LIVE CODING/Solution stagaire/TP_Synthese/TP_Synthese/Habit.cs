using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Synthese
{
    class Habit : Article
    {
        public int Taille { get; set; }
        public string Couleur { get; set; }
        public Habit(int NumeroDeSerie, int PrixHorsTaxe, int QuantiteEnStock, int QuantiteMinimale, int Taille, string Couleur)
            : base(NumeroDeSerie, PrixHorsTaxe, QuantiteEnStock, QuantiteMinimale)
        {
            this.Taille = Taille;
            this.Couleur = Couleur;
        }


        public override string ToString()
        {
            return $"{NumeroDeSerie} {PrixHorsTaxe} {QuantiteEnStock} {QuantiteMinimale} {Taille} {Couleur}";
        }

    }
}
