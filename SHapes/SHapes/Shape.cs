using System;
using System.Collections.Generic;
using System.Text;

namespace SHapes
{
    abstract class Shape
    {


        public Shape(string name = "NoName")
        {
            { PetName = name; }
        }
        public string PetName { get; set; }

        public abstract void Draw();
       // {
            //Console.WriteLine(" Inside Shape.Draw() ");
        //}
    }
}
