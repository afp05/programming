using System;

namespace CustomEnumeratorWithYield
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------- Yield ---------------------------");
            Garage carLot = new Garage();
            foreach (Car c in carLot)
            {
                Console.WriteLine("{0} is going {1} KMH", c.PetName, c.CurrentSpeed);
            }
            Console.WriteLine("_______________________________________________________________");
            
            foreach(Car c in carLot.GetTheCars(true))
            {
                Console.WriteLine("{0} id going {1} KMH", c.PetName, c.CurrentSpeed);
            }

            

        }
    }
}
