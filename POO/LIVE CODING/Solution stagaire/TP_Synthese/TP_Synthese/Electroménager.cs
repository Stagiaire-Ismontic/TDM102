using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Synthese
{
    class Electroménager : Article
    {
        public double Poids { get; set; }
        public int DureeDeGarantie { get; set; }
        public Electroménager(int NumeroDeSerie, int PrixHorsTaxe, int QuantiteEnStock,
            int QuantiteMinimale, double Poids, int DureeDeGarantie)
            : base(NumeroDeSerie, PrixHorsTaxe, QuantiteEnStock, QuantiteMinimale)
        {
            this.DureeDeGarantie = DureeDeGarantie;
            this.Poids = Poids;
        }
        public void datefinGarantie()
        {
            DateTime Today = DateTime.Now;
            int day = Today.Day;
            int Month = Today.Month;
            int year = Today.Year;
            while (DureeDeGarantie + Month > 12)
            {
                Month -= 12;
                year++;
            }

            DateTime FinGarantie = new DateTime(year, Month + DureeDeGarantie, day);
            Console.WriteLine("La date de fin de garantie est : " + FinGarantie);
        }
        public override string ToString()
        {
            return $"\nNumero De serie:{NumeroDeSerie}\t Prix hors taxe:{PrixHorsTaxe}\t Quantite en stock:{QuantiteEnStock} \n" +
                $"Quantite minimale:{QuantiteMinimale}\t Poids:{Poids}        \t Duree de grantie: {DureeDeGarantie}";
        }
    }
}
