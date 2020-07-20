using System;

class Customer
{
    string _firstname;
    string _lastname;

    // public Customer()
    // {
    //     this._firstname = "Firstname not provided";
    //     this._lastname = "Lastname not provided";
    // }
    
    //OR

    public Customer()
        :this("Firstname not provided","Lastname not provided")                 //Constructor Chaining (invokes Parameterised Constructor)
    {
    }

    public Customer(string firstname, string lastname)
    {
        this._firstname = firstname;
        this._lastname = lastname;
    }

    public void printName()
    {
        Console.WriteLine("Customer Name : {0}",this._firstname + " " + this._lastname);
    }

    ~Customer()
    {
        //Memory free-up code
    }
}


class Program
{
    public static void Main()
    {
        Customer C1 = new Customer("Suraj","Janmane");
        C1.printName();

        Customer C2 = new Customer();
        C2.printName();
        
    }
}


/*
Constructor Properties
1. Does not have a return type
2. Must have same name as the class
3. Automatically invoked when object of the class is created
4. When we create a Parameterized constructor, then we have to explicitly create the Default constructor if we need it. (Compiler doesn't create)


Destructor Properties
1. Does not have a return type
2. Must have same name as the class, but must begin with ~
3. It is used for releasing the memory used by the resources.
4. In C# Garbage Collector automatically releases memory after execution. (No need of Destructor)
*/