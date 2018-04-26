using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrashInc
{
    class Center : Google
    {
        private Point center;

        public void addPoint(double lat, double lon)
        {
            center = new Point(lat, lon);
        }
    }
}
