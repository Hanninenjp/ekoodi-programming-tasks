using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekoodi.Utilities
{
    public abstract class BankReference
    {
        public abstract string Reference { get; }
        public abstract string ToPrint();
    }
}
