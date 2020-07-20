using System;

class Arrays
{
    public static void Main()
    {
        Example e = new Example();
        int[] oddNumbers = new int[10];
        int num = 1;
        for(int i=0; i<10;i++)
        {
            oddNumbers[i] = num;
            num += 2;
        }
        for(int i=0;i<10;i++)
        {
            Console.WriteLine(oddNumbers[i]);
        }

        string[] names = new string[3];
        names[0] = "Ramesh";
        names[1] = "Suresh";
        names[2] = "Rahul";

    }
}

/// <summary>
/// This is an example of XML Documentation Comments
/// </summary>
class Example
{

}
