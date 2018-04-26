using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrashInc
{
    class Route : Prototype
    {
        private string name;
        private int distance;
        private bool isCircular;

		public Route(string name, int distance, bool isCircular)
        {
            this.name = name;
            this.distance = distance;
            this.isCircular = isCircular;
        }

        public Prototype Clone()
        {
            return new Route(name, distance, isCircular);
        }
    }
}
