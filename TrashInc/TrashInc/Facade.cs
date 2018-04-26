using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrashInc
{
    class Facade
    {
       private Google chem;
       private Google cen;

       public Facade()
        {
            chem = new Chemin();
            cen = new Centre();
        }

       public void ajouterPointChemin(double lat,double lon)
        {
            chem.ajouterPoint(lat, lon);
        }

        public void ajouterPointCentre(double lat,double lon)
        {
            cen.ajouterPoint(lat,lon);
        }
    }
}
