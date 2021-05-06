using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IDamaged
    {
        bool Fixed { get; set; }
        void Fix();
    }
}
