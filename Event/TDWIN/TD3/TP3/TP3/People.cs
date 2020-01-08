using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    public class People 
    {
        public DateTime Birth { get; set; }

        public override string ToString()
        {
            return $"Birth :{this.Birth}";
        }
    }
}
