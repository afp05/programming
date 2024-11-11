using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class ThreeDCircle : Circle,  IDraw3d
    {
        public void Draw3d()
        {
            Console.WriteLine("Drawing 3d Circle");
        }
    }
}
