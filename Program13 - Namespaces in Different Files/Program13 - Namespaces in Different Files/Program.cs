using System;
using t_car = Vehicle.Car;
using t_truck = Vehicle.Truck;


class Namespaces
{
    static void Main()
    {
        t_car.Tata.drive();
        t_truck.Tata.drive();
    }
}


//Inorder to access the namespaces present in separate folders, we have to add Reference to those project folders from this project.
//Then we can access it through 'using' keyword