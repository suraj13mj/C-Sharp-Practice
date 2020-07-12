using System;

class NullableDatatype
{
    public static void Main()
    {
        //Value Datatype
        int num1 = 10;
        bool marital_status = true;

        //Nullable Value Datatype
        int? num2 = null;
        float? num3 = 10.544F;

        //Example
        bool? marital_status1 = null;  //Not interested to mention
        if (marital_status1 == true)  
        {
            Console.WriteLine("Person is Married");
        }
        else if (marital_status1 == false)
        {
            Console.WriteLine("Person is not Married");
        }
        else
        {
            Console.WriteLine("Person did not mention his marital status");
        }



        //Null Coalescing Operator ??

        int? Total_tickets = null;
        int Available_tickets = Total_tickets ?? 0;

        //or

        if (Total_tickets == null)
        {
            Available_tickets = 0;
        }
        else
        {
            Available_tickets = (int) Total_tickets;  //Total_tickets.Value   returns Non-Nullable int Value
        }
        Console.WriteLine("Available Tickets:{0}", Available_tickets);
    }
}