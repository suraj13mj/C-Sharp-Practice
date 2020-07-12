
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!\n");

            // Variable and Datatypes
            int x = 5, y = 10, z = 15;
            char ch = 'A';
            string first = "Suraj ", last = "Janmane";
            bool bl = true;
            double db = 3.77D;

            System.Console.WriteLine(x+y+z);
            System.Console.WriteLine(ch);
            System.Console.WriteLine(first+last);
            System.Console.WriteLine(bl);
            System.Console.WriteLine(db);
            System.Console.WriteLine();

            //Implicit Typecasting
            double d = 20.05D, d1;
            float f = 2.5F, f1;
            long l = 100L, l1;
            int i = 10, i1;
            char c = 'A', c1;

            d1 = f;
            System.Console.WriteLine(f);
            System.Console.WriteLine(d1);
            f1 = i;
            System.Console.WriteLine(i);
            System.Console.WriteLine(f1);
            l1 = i;
            System.Console.WriteLine(i);
            System.Console.WriteLine(l1);
            i1 = c;
            System.Console.WriteLine(c);
            System.Console.WriteLine(i1);

            //Explicit Typecasting
            double d2;
            float f2;
            long l2;
            int i2;
            string c2;

            c1 = (char) i;
            c2 = Convert.ToString(i);
            System.Console.WriteLine(i);
            System.Console.WriteLine(c1);
            System.Console.WriteLine(c2);


        }
    }
}
