using System;
using System.Collections.Generic;
using System.Text;

namespace InterFaceHierarchy
{
    class BitMapImage : IAdvancedDraw
    {
        public void Draw()
        {
            Console.WriteLine("Drawing");
        }
        public void DrawInBoundingBox(int top, int left, int bottom, int right)
        {
            Console.WriteLine("Drawing box");
        }
        public void DrowUpSideDown()
        {
            Console.WriteLine("Drawing upside down");
        }
    }
}
