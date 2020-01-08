using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListeMethodes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Création des classes Gestion
            GestionStagiaires gestionStagiaires =
                new GestionStagiaires();

            Stagiaire S = new Stagiaire();
            S.Nom = "Salma";
            S.DateNaissance = new DateTime(2001, 2, 17);

            gestionStagiaires.Ajouter(S);

            Stagiaire S2 = new Stagiaire();
            S2.Nom = "Lamiae";
            S2.DateNaissance = new DateTime(2000, 3, 10);

            gestionStagiaires.Ajouter(S2);

            Console.WriteLine(S.Nom + " " +S.DateNaissance);
            Console.WriteLine(S2.Nom + " " + S2.DateNaissance);

            Console.ReadKey();

        }
    }
}
