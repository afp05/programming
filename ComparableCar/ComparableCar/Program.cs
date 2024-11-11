using System;

namespace ComparableCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============================= Compare objects ===========================");
            Car[] myAutos = new Car[5];
            myAutos[0] = new Car("Rusty", 80, 1);
            myAutos[1] = new Car("Mary", 40, 234);
            myAutos[2] = new Car("Viper", 40, 34);
            myAutos[3] = new Car("Mel", 40, 4);
            myAutos[4] = new Car("Chucky", 40, 5);
            Console.WriteLine("Here is unsorted array of Cars:");
            foreach (Car c in myAutos)
            {
                Console.WriteLine("Car {0} is going {1} . Car ID : {2}", c.PetName, c.CurrentSpeed, c.CarID);
            }
            Array.Sort(myAutos);
            Console.WriteLine("And now here is sorted array of Cars by ID:");
            foreach (Car c in myAutos)
            {
                Console.WriteLine("Car {0} is going {1} . Car ID : {2}", c.PetName, c.CurrentSpeed, c.CarID);
            }
            Array.Sort(myAutos, Car.SortByPetName);
            Console.WriteLine("Odering by pet name:");
            foreach (Car c in myAutos) Console.WriteLine("{0} car is going {1}, car ID: {2}", c.PetName, c.CurrentSpeed, c.CarID);


        }
    }
}
