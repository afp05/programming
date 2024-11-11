using System;

namespace SHapes
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreeDCircle o = new ThreeDCircle();
            o.Draw();
            ((Circle)o).Draw();
            Console.ReadKey();
        }
    }
}
