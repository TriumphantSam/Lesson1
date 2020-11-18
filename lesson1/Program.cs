using System;
using System.Runtime.CompilerServices;

namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 20;
            float f = 20.2f;
            string s = "Hello, world....again";

            Console.WriteLine("This is an {0} value: {1}", i.GetTypeCode(), i);
            Console.WriteLine("This is an {0} value: {1}", f.GetTypeCode(), f);
            Console.WriteLine("This is an {0} value: {1}", s.GetTypeCode(), s);

            var v = 20;
            Console.WriteLine("This is also an {0} value {1}", v.GetTypeCode(), v);

            var d= "hello";
            Console.WriteLine("This is also an {0} value {1}", d.GetTypeCode(), d);

            var j = 10.3f;
            Console.WriteLine("This is also an {0} value {1}", j.GetTypeCode(), j);
        }
    }
}
