using System;

namespace InterFaceNameClash
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Octagon oct = new Octagon();
            IDrawToForm itfForm = (IDrawToForm)oct;
            itfForm.Draw();

            IDrawToMemory itfMemory = (IDrawToMemory)oct;
            itfMemory.Draw();

            IDrawToPrinter itfPrinter = (IDrawToPrinter)oct;
            itfPrinter.Draw();

            ((IDrawToForm)oct).Draw();

            if (oct is IDrawToPrinter) ((IDrawToPrinter)oct).Draw();
        }
    }
}
