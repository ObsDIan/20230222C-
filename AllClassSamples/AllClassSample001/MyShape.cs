using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllClassSample001
{
    public abstract class Myshape
    {
        public abstract double GetArea();
    }

    public class MyRectangle : Myshape
    {
        public double Weight { get; set; }
        public double Height { get; set; }
        public override double GetArea()
        {
            return Weight * Height;
        }
    }

    public class MyCricle : Myshape
    {
        public double Radius { get; set; }
        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }


}
