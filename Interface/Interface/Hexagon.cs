using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Hexagon : Shape, IPointy, IDraw3d
    {

        public Hexagon() { }
        public Hexagon(string name) : base(name) { }
        public override void Draw()
        {
            Console.WriteLine("Drawing the {0} hexagon", PetName);
        }
        public byte Points
        {
            get { return 6; }
        }
        public void Draw3d()
        {
            Console.WriteLine("Drawing Hexagon in 3d");
        }

    }
}
