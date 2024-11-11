using System;

namespace ClonablePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+++++++++++++++++++++++++++ Object Cloning +++++++++++++++++++++++++++++++");
            Point p1 = new Point(50, 50);
            Point p2 = p1; // link na jeden i ten sam obiek w pamięci
            p2.X = 0;
            Console.WriteLine(p1);
            Console.WriteLine(p2);

            Point p3 = new Point(100, 100);
            Point p4 = (Point)p3.Clone();
            p4.X = 1;
            Console.WriteLine(p3);
            Console.WriteLine(p4);

            Console.WriteLine("======================== Advanced Clone ===================================");
            Point p5 = new Point(20, 20, "Jane");
            Point p6 = (Point)p5.Clone();
            Console.WriteLine("Before modification:");
            Console.WriteLine("p5: {0}", p5);
            Console.WriteLine("p6: {0}", p6);
            p6.desc.PetName = "My new Point";
            p5.X = 9;
            Console.WriteLine("\nChangeed p6.desc.petName and p6.X");
            Console.WriteLine("After modification:");
            Console.WriteLine("p5 : {0}", p5);
            Console.WriteLine("p6 : {0}", p6);
        }
    }
}
