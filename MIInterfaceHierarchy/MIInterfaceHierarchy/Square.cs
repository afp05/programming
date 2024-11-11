using System;
using System.Collections.Generic;
using System.Text;

namespace MIInterfaceHierarchy
{
    class Square : IShape
    {
       void IPrintable.Draw()
        {
            Console.WriteLine("Printing the sqaure");
        }
        void IDrawable.Draw()
        {
            Console.WriteLine("Drawing the squre");
        }
        public void Print()
        {
            Console.WriteLine("Sending data to printer...");
        }
        public int GetNumberOfSides()
        {
            return 4;
        }
    }
}
