using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrashInc;

namespace TrashInc
{
    interface Observer
    {
        void Notify(Observable obs);
    }
}
