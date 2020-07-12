using System;

class Typecasting
{
    public static void Main()
    {
        //Implicit Typecasting
        int i = 250;
        float f = i;
        Console.WriteLine(f);

        //Explicit Typecasting

        //1.Using Typecast () Operator
        float f1 = 25045.235F;
        int i1 = (int)f;
        Console.WriteLine(i1);

        //2.Using Convert. class can handle Exceptions i.e out of range Exceptions
        long l = 24L;
        short s = Convert.ToInt16(l);
        Console.WriteLine(s);

        double d = 124457576845.1234;
        long l1 = Convert.ToInt64(d);
        Console.WriteLine(l1);


        //3. Using type.Parse() or type.TryParse() for parsing string to different types
        string snum = "1000";
        int num = int.Parse(snum);

        string snum1 = "1000ABC";
        int num1;
        //num1 = int.Parse(snum1);    //Gives Error

        bool status = int.TryParse(snum1, out num1);
        if (status)
        {
            Console.WriteLine("Parsed Number is {0}", num1);
        }
        else
        {
            Console.WriteLine("Enter Valid Number to Parse");
        }
    }
}