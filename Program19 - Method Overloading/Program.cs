using System;

class Program
{
    public static void Main()
    {
        Program P = new Program();

        P.Sum(10,20);
        P.Sum(10.5f,20.5f);
        P.Sum(10,20,30);

        int sum = 0;
        P.Sum(10,20, out sum);

        int[] arr = new int[3];
        P.Array_Length(arr);

    }

    public void Sum(int FN, int SN)
    {
        Console.WriteLine("Sum : {0}", FN+SN);
    }

    /*
    public int Sum(int FN, int SN)                      //This method has same signature as previous, thus compiler gives error
    {                                                   //Return type is not part of the signature
        Console.WriteLine("Sum: {0}", FN+SN);
        return FN+SN;
    }
    */

    public void Sum(float FN, float SN)
    {
        Console.WriteLine("Sum : {0}", FN+SN);
    }

    public void Sum(int FN, int SN, int TN)
    {
        Console.WriteLine("Sum : {0}", FN+SN+TN);
    }

    public void Sum(int FN, int SN, out int Sum)
    {
        Console.WriteLine("Sum : {0}", FN+SN);
        Sum = FN+SN;
    }

    

    public void Array_Length(int []N_Array)
    {
        Console.Write("Array Length : {0}",N_Array.Length);
    }

    /*
    public void Array_Length(params int []N_Array)                      //This method has same signature as previous, thus compiler gives error
    {                                                                   //params is not part of the signature
        Console.Write("Array Length : {0}",N_Array.Length);
    }
    */
}


/* 
 1. Method Overloading : Methods in the class having same Name but different signatures are overloaded based on the type, number and kind of Parameter.
 2. Method Signature : Method Name, Number of Parameters, Type of Parameters, Kind of Parameters form method Signature
 3. Return type and params are not part of the method Signature.
*/
