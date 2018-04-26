using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrashInc
{
    class Point
    {
        private double latitude;
        private double longitude;

        public Point(double lat,double lon)
        {
            latitude = lat;
            longitude = lon;
        }

        public string getStringLatitude()
        {
            return latitude.ToString();
        }

        public string getStringLongitude()
        {
            return longitude.ToString();
        }

    }
}
