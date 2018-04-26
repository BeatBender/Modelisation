using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrashInc
{
    class Chemin : Google
    {
        private List<Point> listePoint = new List<Point>();

        public void ajouterPoint(double lat, double lon)
        {
            listePoint.Add(new Point(lat, lon));
        }
    }
}
