using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple_exception_m.Exceptions
{
    public class StartWithAlphabtExepction : Exception
    {
        public StartWithAlphabtExepction(string message) : base(message)
        {
        }
    }
}
