using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrashInc
{
    class Center : Google
    {
        private Point centre;

        public void addPoint(double lat, double lon)
        {
            centre = new Point(lat, lon);
        }
    }
}
