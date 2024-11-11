using System;
using System.Collections.Generic;
using System.Text;

namespace SHapes
{
    class Circle : Shape
    {
        public Circle() { }
        public Circle(string name) : base(name) { }

        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the circle", PetName);
        }


    }
}
