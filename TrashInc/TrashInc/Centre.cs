using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrashInc
{
    class Centre : Google
    {
        private Point centre;

        public void ajouterPoint(double lat, double lon)
        {
            centre = new Point(lat, lon);
        }
    }
}
