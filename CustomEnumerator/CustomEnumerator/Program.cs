using System;

namespace CustomEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++  IEnumerable / IEnumerator ++++++++++++++++++++++++++++++++++");
            Garage carLot = new Garage();
            foreach (Car c in carLot)
            {
                Console.WriteLine("{0} is going {1} KMH", c.PetName, c.CurrentSpeed);
            }
        }
    }
}
