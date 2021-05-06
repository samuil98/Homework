using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ISold
    {
         double  SellPrice { get; set; }
        public abstract void Sell(object objekt);
    }
}
