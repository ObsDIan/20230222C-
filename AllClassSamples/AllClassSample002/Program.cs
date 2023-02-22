using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllClassSample002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass o1 = new Class1();
            o1.Excute();
            o1.Begun();
            BaseClass o2 = new Class2();
            o2.Excute();
            o2.Begun();

            Console.ReadLine();
        }
        

    }
}
