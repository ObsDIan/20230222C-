using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllClassSample002
{
    public class BaseClass
    {
        public virtual void Excute()
        {
            Console.WriteLine("BaseClass Execute Methid");
        }

        public virtual void Begun()
        {
            Console.WriteLine("BaseClass Begin Method");
        }
    }
    public class Class1 : BaseClass
    {
        public override void Excute()
        {
            Console.WriteLine("Class1 Execut Method");
        }
    }

    public class Class2 : Class1
    {
        public sealed override void Excute()
        {
            Console.WriteLine("Class2 Begun Method");
        }

        public override void Begun()
        {
            Console.WriteLine("Class2 Begin Methon");
        }
    }

    public class Class3 : Class2
    {
        
    }

    
}
