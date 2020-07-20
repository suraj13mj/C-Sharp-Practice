using System;

class Circle
{
    public static float _PI;
    int _radius;

    static Circle()
    {
        Console.WriteLine("Static Constructor is called");
        Circle._PI = 3.142F;
    }

    public Circle(int radius)
    {
        Console.WriteLine("Instance Constructor is called");
        this._radius = radius;
    }

    public float calcArea()
    {
        return Circle._PI * this._radius * this._radius;
    }
}


class Program
{
    public static void Main()
    {
        Circle C1 = new Circle(10);
        float area1 = C1.calcArea();
        Console.WriteLine("Area of Circle is {0}",area1);

        Circle C2 = new Circle(20);
        float area2 = C2.calcArea();
        Console.WriteLine("Area of Circle is {0}",area2);

        Console.WriteLine("PI value : {0}",Circle._PI);
    }
}


/*
Why create Static members...?
-> fields or types (fields, methods, properties, constructors etc) that remain same for all the objects (instances) of the class
need not be created for all the objects. (Thus preventing memory wastage).

-> Through static keyword we can create such fields only once and access for all the objects.
-> Static members must be accessed using the Classname
*/


/*
Static Constructors
1. Static Constructors are called before Instance Constructor 
i.e Static constructor is called only once when a object of a class is created for the first time 
i.e for subsequent objects, static constructor is not called.


2. Static constructors must be private, i.e they must not be accessible outside the class. 
(which might cause in tampering the static fields)
*/

