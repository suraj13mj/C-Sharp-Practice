using System;

class InputOutupt
{
    public static void Main()
    {
        Console.WriteLine("Enter your First Name:");
        string fname = Console.ReadLine();

        Console.WriteLine("Enter your Last Name:");
        string lname = Console.ReadLine();

        //Using Concatenation
        Console.WriteLine("Hello " + fname + " " + lname);

        //Using Place Holder
        Console.WriteLine("Welcome {0} {1}", fname, lname);

    }
}
