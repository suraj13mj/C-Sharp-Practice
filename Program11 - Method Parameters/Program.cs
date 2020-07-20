/* There are 4 different types of Parameter methods in C#

1. Value Parameters.
2. Reference Parameters. (ref)
3. Output Parameters. (out)
4. Parameter Arrays. (params)

*/

using System;

class Method_Parameters
{
    public static void Main()
    { 
        //Value Parameters  
        int num = 100;
        Method_Parameters.Value_Parameter(num);
        Console.WriteLine("Number : {0}",num);

        //Reference Parameters
        int n = 10, m = 20;
        int sum = 0;
        Method_Parameters.Reference_Parameter(n,m,ref sum);                                             //Passed using ref keyword
        Console.WriteLine("Sum of {0} and {1} is {2}",n,m,sum);

        //Output Parameters
        int n1 = 10, m1 = 20;
        int sum1 = 0, prod1 = 0;
        Method_Parameters.Output_Parameter(n1, out sum1, m1, out prod1);                                //Passed using out keyword 
        Console.WriteLine("Sum of {0} and {1} is {2}\nProduct of {0} and {1} is {3}",n,m,sum1,prod1);   //order must be same as method parameters


        //Non-Parameter Arrays
        int[] Numbers = new int[3];
        Numbers[0] = 11;
        Numbers[1] = 22;
        Numbers[2] = 33;

        Method_Parameters.NonParameter_Arrays(Numbers);                   //If we create normal parameter arrays in methods, then we can have to pass the array
        // Method_Parameters.NonParameter_Arrays();                       //But Advantage of params is that, we can make it optional to pass arrays
        // Method_Parameters.NonParameter_Arrays(1,2,3);                  //Also we can directly pass values of arrays without creating an array.




        //Parameter Arrays (params)
        string msg = "Good Morning";
        int[] Numbers1 = new int[3];
        Numbers1[0] = 11;
        Numbers1[1] = 22;
        Numbers1[2] = 33;

        Method_Parameters.Parameter_Arrays(msg,Numbers1);
        Method_Parameters.Parameter_Arrays(msg);
        Method_Parameters.Parameter_Arrays(msg,1,2,3);

    }







    //Value Parameters
    public static void Value_Parameter(int num)
    {
        num = 200;                                                                  //Changing num value doesn't affect the actual argument 'num' in main()
    }


    //Reference Parameters
    public static void Reference_Parameter(int n, int m, ref int sum)               //Reference Argument points to the actual argument
    {                                                                               //changing sum value affects the actual argument 'sum' in main
        sum = n + m;
    }

    
    //Output Parameters
    public static void Output_Parameter(int n, out int Sum, int m, out int Product)
    {
        Sum = n + m;                                                               //In C# bydef we can return only one value, inorder to return multiple values we use output parameters
        Product = n * m;                                                           //Values to be returned must be stored in the output parameters
    }


    //Non-Parameter Arrays
    public static void NonParameter_Arrays(int[] Numbers)
    {
        Console.WriteLine("Length of the Array is {0}",Numbers.Length);
        foreach ( int num in Numbers)
        {
            Console.WriteLine(num);
        }
    }


    //Parameter Arrays
    public static void Parameter_Arrays(string msg, params int[] Numbers)
    {
        Console.WriteLine(msg);
        Console.WriteLine("Length of the Array is {0}",Numbers.Length);
        foreach ( int num in Numbers)
        {
            Console.WriteLine(num);
        }
    }
}


// 1. params : Parameter Array must always be the last parameter
// 2. We can have only one params arrays.

// function_name(10,20)     -> Arguments

/* 
public void function_name(int n, int m)    -> Parameters
{
    ....
}
*/
