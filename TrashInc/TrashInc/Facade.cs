﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrashInc
{
    class Facade
    {
       private Google route;
       private Google center;

       public Facade()
        {
            route = new Route();
            center = new Center();
        }

       public void addPointRoute(double lat,double lon)
        {
            route.addPoint(lat, lon);
        }

        public void addPointCenter(double lat,double lon)
        {
            center.addPoint(lat,lon);
        }
    }
}
