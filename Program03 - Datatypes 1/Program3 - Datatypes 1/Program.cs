using System;

class Datatype
{
    public static void Main()
    {
        //Integral Datatype
        byte b = 10;
        sbyte sb = 20;

        Console.WriteLine("byte : Min {0} and Max {1}", byte.MinValue, byte.MaxValue);
        Console.WriteLine("sbyte: Min {0} and Max {1}", sbyte.MinValue, byte.MaxValue);

        short s = -10;
        ushort us = 10;

        int i = -10;
        uint ui = 10;

        long l = -10L;
        ulong ul = 10L;

        //Floating Datatype
        float f = 10.555F;
        double d = 10.555;
        decimal deci = 10.555M;

        Console.WriteLine("Float: {0}\nDouble: {1}\nDecimal: {2}", f, d, deci);

        //Boolean Datatype
        bool b = true;

    }
}
