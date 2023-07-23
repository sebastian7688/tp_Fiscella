using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia4
{
    public class A
    {
        public A(int a)
        {
            Console.WriteLine(a);
        }
    }

    public class B : A
    {
        public B(int b) : base(b / 2)
        {
            Console.WriteLine(b);
        }
    }

    public class C : B
    {
        public C(int c) : base(c / 2)
        {
            Console.WriteLine(c);
        }
    }

    class Prueba
    {
        static void Main(string[] args)
        {
            C obj1 = new C(20);
            Console.ReadKey();
        }
    }
}
