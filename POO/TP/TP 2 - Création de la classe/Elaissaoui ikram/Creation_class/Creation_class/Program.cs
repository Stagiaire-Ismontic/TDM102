using System;

namespace Creation_class
{
    class Program
    {
        static void Main(string[] args)
        {
            //création d'un objet de type Project
            Projet projet1 = null;
            //création de l'instance projet1
            projet1 = new Projet("projet1");
            //utilisation de la propriété titre
            projet1.Titre="Création de application";
            //Affichage de l'objet
            Console.WriteLine(projet1);
            Console.WriteLine(projet1.ToString();
            Console.WriteLine(projet1.Titre);
            //equals
            Projet projet2 = new Projet();
            projet2.Titre = "creation d'un application";
            if (projet1.Equals(projet2))
            {
                Console.WriteLine("projet1 egale projet2");

            }
            else
            {
                Console.WriteLine("projet1 n'egale pas projet2");

            }
            Console.ReadKey();



        }
    }
}
