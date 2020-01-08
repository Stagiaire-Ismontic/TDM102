using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Stagaire> st1 = new List<Stagaire>();
            Stagaire S1 = new Stagaire(2, "Khalid");
            Stagaire S2 = new Stagaire(3, "Khonti");
            Stagaire S3 = new Stagaire(1, "Zaoujal");
            st1.Add(S1);
            st1.Add(S2);
            st1.Add(S3);

            List<Stagaire> st2 = new List<Stagaire>();
            Stagaire S4 = new Stagaire(4, "Rossi");
            Stagaire S5 = new Stagaire(5, "Kibiani");
            st2.Add(S4);
            st2.Add(S5);
            st1.AddRange(st2);

            st1.RemoveAt(4);

            int Nom_de_stagiaire= 
            st1.Count();
            st1.Sort();
            
            
            









        }
    }
}
