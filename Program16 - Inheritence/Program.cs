using System;

public class Employee
{
    public string FirstName;
    public string LastName;
    public string Email;

    public Employee()
        :this("NA","NA","NA")
    {
        Console.WriteLine("Employee Default Constructor called");
    }

    public Employee(string FN,string LN, string Email)
    {
        Console.WriteLine("Employee Parameter Constructor called");
        this.FirstName = FN;
        this.LastName = LN;
        this.Email = Email;
    }

    public void Print()
    {
        Console.WriteLine("Full Name : {0} {1}\nEmail : {2}",this.FirstName,this.LastName,this.Email);
    }
}


//--FullTimeEmployee

public class FullTimeEmployee : Employee
{
    
    public int Workdays;
    public FullTimeEmployee()
        :this(0)
    {
        Console.WriteLine("FTE Default Constructor called");
    }
    public FullTimeEmployee(int workdays)
    {
        Console.WriteLine("FTE Parameter Constructor called");
        this.Workdays = workdays;
    }

    public void Print()
    {
        base.Print();
        Console.WriteLine("Work Day : {0}",this.Workdays);
    }
}


//--PartTime Employee

public class PartTimeEmployee : Employee
{
    public int Workhours;

    public PartTimeEmployee()
        :base("NA","NA","NA")
    {
        Console.WriteLine("PTE Default Constructor called");
        this.Workhours = 0;
    }

    public PartTimeEmployee(string FirstName, string LastName,string Email, int workhours) 
        : base(FirstName,LastName,Email)
    {
        Console.WriteLine("PTE Parameter Constructor called");
        this.Workhours = workhours;
    }

    public void Print()
    {
        base.Print();
        Console.WriteLine("Work Hours : {0}",this.Workhours);
    }
}


class Program
{
    public static void Main()
    {
        //Full Time Employee
        FullTimeEmployee fte = new FullTimeEmployee();
        fte.FirstName = "Suraj";
        fte.LastName = "Janmane";
        fte.Email = "suraj.janmane@gmail.com";
        fte.Workdays = 30;
        fte.Print();

        // Part Time Employee
        PartTimeEmployee pte = new PartTimeEmployee("Suraj","Janmane","suraj.janmane@gmail.com",10);
        pte.Print();

        //Part Time Employee
        PartTimeEmployee pte1 = new PartTimeEmployee();
        pte1.Print();
    }
}


/*
Inheritence

1. C# only supports only Single Inheritence
2. We inherit using ":" symbol
3. C# supports multipe Inheritence through Interfaces
4. Parent class constructor are called before Child class constructors
5. We can control which constructor of base class is called using "base" keyword

* Observe the constructor inheritence.
*/