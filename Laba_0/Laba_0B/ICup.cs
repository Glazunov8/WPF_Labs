using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_0B
{
    interface ICup
    {
        void Refill();
        void Wash();

        string Type { get; set; }
        double Copacity { get; set; }
    }
}
