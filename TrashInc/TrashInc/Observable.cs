using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrashInc;

namespace TrashInc
{
    interface Observable
    {
        void addObserver(Obverser observer);
        void removeObserver(Obverser observer);
        void notifyObservers();
    }
}
