using System;

namespace CustomGenericMethods
{
    class Program
    {
        static void Swap<T>(ref T a, ref T b)
        {
            Console.WriteLine("You sent the swap () method a {0}", typeof(T));
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            int a = 10, b = 90;
            Console.WriteLine("Before swap : {0}, {1}", a, b);
            Swap<int>(ref a, ref b);
            Console.WriteLine("After swap : {0}, {1}", a, b);
            string s1 = "Hello";
            string s2 = "there";
            Console.WriteLine("Before swap : {0}, {1}", s1, s2);
            Swap<int>(ref a, ref b);
            Console.WriteLine("After swap : {0}, {1}", s1, s2);

        }
    }
}
