using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quete_SOLID_Liskov
{
   public class Square: Polygon
    {
        private double side;
        public void SetSide(double side)
        {
            this.side = side;
        }

        public double GetSide(double side)
        {
            return side;
        }

        public override double Area()
        {
            return side * side;
        }
    }
}
