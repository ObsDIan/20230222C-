using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllClassSample001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Myshape rect = new MyRectangle(){Weight = 10, Height= 10};
            Console.WriteLine(rect.GetArea());
            
            Myshape circle = new MyCricle() { Radius = 3 };
            Console.WriteLine(circle.GetArea());
            Console.ReadKey();
        }
    }
}
