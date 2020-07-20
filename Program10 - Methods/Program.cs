using System;

class Methods
{
    public static void Main()
    {
        Methods.evenNumber(20);

        Methods mtd = new Methods();
        mtd.oddNumber(20);
    }

    //Static Methods - Must be called using the Classname
    public static void evenNumber(int N)
    {
        int start = 0;
        while(start <= N)
        {
            Console.WriteLine(start);
            start += 2;
        }
    }

    //Instance Methods - Must be called using the instance of a class
    public void oddNumber(int N)
    {
        int start = 1;
        while(start <= N)
        {
            Console.WriteLine(start);
            start += 2;
        }
    }
}