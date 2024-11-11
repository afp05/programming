using System;
using System.Collections.Generic;
using System.Text;

namespace InterFaceNameClash
{
    class Octagon : IDrawToForm, IDrawToMemory,IDrawToPrinter
    {
        void IDrawToForm.Draw() 
        {
            Console.WriteLine("Drawing the octagon to form");
        }
        void IDrawToPrinter.Draw()
        {
            Console.WriteLine("Drawing the octagon to printer");
        }
        void IDrawToMemory.Draw()
        {
            Console.WriteLine("Drawing the octagon to memory");
        }
    }
}
