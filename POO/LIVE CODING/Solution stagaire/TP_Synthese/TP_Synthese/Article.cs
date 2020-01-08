using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Synthese
{
    class  Article
    {
        //Propriete
        public int NumeroDeSerie { get; set; }
        public int PrixHorsTaxe { get; set; }
        public int QuantiteEnStock { get; set; }
        public int QuantiteMinimale { get; set; }

        public Article(int NumeroDeSerie, int PrixHorsTaxe, int QuantiteEnStock, int QuantiteMinimale)
        {
            this.NumeroDeSerie = NumeroDeSerie;
            this.PrixHorsTaxe = PrixHorsTaxe;
            this.QuantiteEnStock = QuantiteEnStock;
            this.QuantiteMinimale = QuantiteMinimale;
        }

        public override string ToString()
        {
            return $"NumeroDeSerie:{NumeroDeSerie} PrixHorsTaxe:{PrixHorsTaxe} QuantiteEnStock:{QuantiteEnStock} QuantiteMinimale:{QuantiteMinimale}";
        }
        public void aprovisionner(int qte)
        {

            if (qte<QuantiteEnStock)
            {
                QuantiteEnStock =- qte;
                if (QuantiteEnStock<QuantiteMinimale)
                {
                    Console.WriteLine("->ATTENTION : la quantite en stock est inferieure de la quatite minimal!");
                }
            }
            else
            {
                Console.WriteLine("La quantite en stock n'est pas sufisant");
            }
        } 
        public void achat(int qte)
        {
            if (qte < QuantiteEnStock)
            {
                QuantiteEnStock -= qte;
            }
            else
                Console.WriteLine("L'achat est imposible (Quantite en stocker est insifisant).");
        }
        
    }
}
