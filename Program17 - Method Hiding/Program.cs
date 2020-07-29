using System;

public class Employee
{
    public string FirstName = "FN";
    public string LastName = "LN";
    public void PrintFullName()                                         //Hidden method
    {
        Console.WriteLine(this.FirstName + " " + this.LastName);
    }
}



//FullTime Employee Class

public class FullTimeEmployee : Employee
{
    public  new void PrintFullName()                                                         //Here we are hiding the PrintFullName() method of Base class
    {                                                                                        //If this was intentional then we can avoid the Compiler warning 
        Console.WriteLine(this.FirstName + " " + this.LastName + " - FullTime");             //By adding 'new' keyword  (it is hidden even if we don't specify 'new' keyword, but gives warning)
    }
}



//PartTime Employee Class

public class PartTimeEmployee : Employee
{
    public new void PrintFullName()
    {
        Console.WriteLine(this.FirstName + " " + this.LastName + " - PartTime");
        //base.PrintFullName();
    }
}




public class Program
{
    public static void Main()
    {
        FullTimeEmployee FTE = new FullTimeEmployee();
        FTE.FirstName = "Ramesh";
        FTE.LastName = "Jain";
        FTE.PrintFullName();

        PartTimeEmployee PTE = new PartTimeEmployee();
        PTE.FirstName = "Suresh";
        PTE.LastName = "Jain";
        PTE.PrintFullName();

        //Suppose we want to call the hidden Base class 'PrintFullName()' method then we can do it 3 ways
        //1. We can use 'base.PrintFullName()' in the inherited PrintFullName() method in derived class

        //2. We can typecast the derived class object to be act as Parent class object.
        //Since Derived class is a specialisation of Base class, it fullfills all responsibilities of Base class
        //Thus we can use it refer to hidden base class method

        ((Employee)PTE).PrintFullName();


        //3. Since Derived class fulfills all responsibility of Base class
        //We can assign Derived class object to Base class Reference 
        //Thus the Base class reference always invokes hidden base class method as it has no idea about Derived class PrintName method

        Employee emp = new PartTimeEmployee();
        emp.FirstName = "Lavish";
        emp.LastName = "Jain";
        emp.PrintFullName();

    }
}


// NOTE :
// -> Base class reference can point to Derived class object
// -> Derived class reference cannot point to Base class object (Because Base class doesn't satisfy all responsibilities of Derived class)