using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class TriAngle : Shape, IPointy
    {
        public TriAngle()  { }
        public TriAngle(string name) : base(name) { }
        public override void Draw()
        {
            Console.WriteLine("Drawing the {0}", PetName);
        }
        public byte Points
        {
            get { return 3; }
        }


    }
    
    
}
