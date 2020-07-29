using System;

class Employee
{
    public string FirstName = "FN";
    public string LastName = "LN";

    public virtual void PrintFullName()
    {
        Console.WriteLine(this.FirstName + " " + this.LastName);
    } 
}


//Derived Classes
class FullTimeEmployee : Employee
{
    public new void PrintFullName()                                                     //This method is hiding Base class PrintFullName()
    {                                                                                   //Since we have used Base class reference this method is not invoked
        Console.WriteLine(this.FirstName + " " + this.LastName + " - FullTime");
    }
}

class PartTimeEmployee : Employee                                                   //Here we are overriding the PrintFullName() of Base class
{                                                                                   //Now this method is invoked whenever we refer to PrintFullName() using Base class reference.
    public override void PrintFullName()                                            //In FullTimeEmployee we have not overrided, thus there it always refers to Base class PrintFullName() method.
    {
        Console.WriteLine(this.FirstName + " " + this.LastName + " - PartTime");
    }
}

class TemproryEmployee : Employee
{
    public override void PrintFullName()
    {
        Console.WriteLine(this.FirstName + " " + this.LastName + " - Temporary");
    }
}



class Program
{
    public static void Main()
    {
        Employee[] emps = new Employee[4];

        //Base class reference pointing to Base class object
        emps[0] = new Employee();

        //Base class reference pointing to Derived class objects.
        //Base class reference has no idea about 'PrintFullName()' method is Derived classes
        //Therefore alway invokes PrintFullName() of Base class
        emps[1] = new FullTimeEmployee();
        emps[2] = new PartTimeEmployee();
        emps[3] = new TemproryEmployee();

        foreach ( Employee e in emps)
        {
            e.PrintFullName();
        }

        //To invoke the Derived class PrintFullName() method using Base class reference
        //1. We have to make base class PrintFullName() a 'virtual' method i.e If derived class methods wish to override this method then they can.
        //2. We have to 'override' the PrintFullName() in Derived class

        //Runtime Polymorphism( Method Overriding ): Calling Derived class methods using Base class reference during runtime is called Runtime Polymorphism.

        //In Method Overriding : Base class reference invokes Derived class methods.

        //Method Hiding
        //Parttime Employee is invoking hidden method in Base class
        //Here Base class reference is pointing to Derived class object (But method is not overridden).
        //Therefore the Base class reference invokes hidden PrintFullName() method in Base class.

    }
}