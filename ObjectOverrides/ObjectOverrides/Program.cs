using System;

namespace ObjectOverrides
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Person p1 = new Person();
            Console.WriteLine("tostring {0}", p1.ToString());
            Console.WriteLine("HashCode {0}", p1.GetHashCode());
            Console.WriteLine("Type {0}", p1.GetType());
            Person p2 = p1;
            object o = p2;
            if (o.Equals(p1) && p2.Equals(o))
            {
                Console.WriteLine("Same instance");
            }
            Console.ReadLine();
        }
    }
}
