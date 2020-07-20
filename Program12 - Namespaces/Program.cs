using System;

//using Vehicle.Car;
//using Vehicle.Truck;

using t_car = Vehicle.Car;                                    //Giving alias names to the namespaces
using t_truck = Vehicle.Truck;


class Namespaces
{
    public static void Main()
    {
        //1.Using complete qualified name
        Vehicle.Car.Tata.drive();
        Vehicle.Truck.Tata.drive();

        //2.Including 'using Vehicle.Car'
        //Tata.drive();                                       //Causes ambiguity to decide using which namespace
        //Tata.drive();

        //3.To use alias names for the namespaces
        t_car.Tata.drive();
        t_truck.Tata.drive();

    }
}




namespace Vehicle                                               //Nested Namespace
{
    namespace Car
    {
        class Tata
        {
            public static void drive()
            {
                Console.WriteLine("You are driving a Tata Safari Car");
            }
        }
    }
}




namespace Vehicle.Truck                                         //Nested Namespace with . operator
{
    class Tata
    {
        public static void drive()
        {
            Console.WriteLine("You are driving a Tata HMV Truck");
        }
    }
}