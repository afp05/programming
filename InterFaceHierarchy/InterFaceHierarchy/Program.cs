using System;

namespace InterFaceHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------- Interface Hierarchy -----------------------");
            BitMapImage bit = new BitMapImage();
            bit.Draw();
            bit.DrawInBoundingBox(10,10,10,10);
            bit.DrowUpSideDown();
            IAdvancedDraw iAdvDrw = bit as IAdvancedDraw;
            if (iAdvDrw != null)
                iAdvDrw.DrowUpSideDown();
        }
    }
}
