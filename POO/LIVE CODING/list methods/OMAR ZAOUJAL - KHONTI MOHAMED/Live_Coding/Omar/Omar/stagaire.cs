using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omar
{
  public  class Stagaire
    {
        public int Id { get; set; }
        public String Nome { get; set; }

        public Stagaire(int Id,String nome)
        {
            this.Id = Id;
            this.Nome = nome;
        }

        public override string ToString()
        {
            return $"{this.Id} - {this.Nome}";
        }
    }
   
}
