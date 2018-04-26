using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrashInc
{
    class Route : Prototype,Google
    {
        private string name;
        private int distance;
        private bool isCircular;
        private List<Point> listePoint = new List<Point>();

        public Route() { }

        public Route(string name, int distance, bool isCircular)
        {
            this.name = name;
            this.distance = distance;
            this.isCircular = isCircular;
        }

        public void addPoint(double lat, double lon)
        {
            listePoint.Add(new Point(lat, lon));
        }

        public Prototype Clone()
        {
            return new Route(name, distance, isCircular);
        }
    }
}
