using System;

class Switch
{
    public static void Main()
    {
        int totalcoffeecost = 0;
        Console.WriteLine("Welcome to Starbucks!!");
        Start:
        Console.WriteLine("Please select your Coffee size: \n1. Small (Rs 10)\n2. Medium (Rs 20)\n3.Large (Rs 30)");
        int size = int.Parse(Console.ReadLine());
        switch (size)
        {
            case 1:
                Console.WriteLine("You selected small size");
                totalcoffeecost += 10;
                break;
            case 2:
                Console.WriteLine("You selected medium size");
                totalcoffeecost += 20;
                break;
            case 3:
                Console.WriteLine("You selected large size");
                totalcoffeecost += 30;
                break;
            default:
                Console.WriteLine("Invalid Selection {0}, Please try again", size);
                goto Start;
        }

        Step:
        Console.WriteLine("Do you want buy another coffee..? YES or NO");
        string decision = Console.ReadLine();
        switch(decision.ToUpper())
        {
            case "YES":
                goto Start;
            case "NO":
                break;
            default:
                Console.WriteLine("Invalid input {0}, Please try again",decision);
                goto Step;
        }

        Console.WriteLine("Thanks for buying Coffee..!!\n Total coffee cost is {0}", totalcoffeecost);
        
    }
}