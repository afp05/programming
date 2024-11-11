using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Circle : Shape
    {
        public Circle() { }
        public Circle(string name) : base(name) { }
        public override void Draw()
        {
            Console.WriteLine("Drawing the {0} circle", PetName);
        }
        public byte Points
        {
            get { return 6; }
        }
    }
}
