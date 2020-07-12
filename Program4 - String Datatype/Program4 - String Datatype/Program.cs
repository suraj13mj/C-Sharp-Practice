using System;

class Datatype_String
{
    public static void Main()
    {
        string str = "Hello World";
        Console.WriteLine(str);

        //Escape characters
        string str1 = "\" Suraj M Janmane \"";
        string str2 = "1\\n";
        Console.WriteLine("{0}\n{1}", str1, str2);

        //Verbatim Literal
        string path = "C:\\Documents\\Images\\tiger.png";
        string new_path = @"C:\Documents\Images\tiger.png";
        string exp = @"100\n * 100\t"; 
        Console.WriteLine("{0}\n{1}\n{2}", path, new_path,exp);

    }
}