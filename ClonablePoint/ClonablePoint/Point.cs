using System;
using System.Collections.Generic;
using System.Text;

namespace ClonablePoint
{
    class Point : ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointDescription desc = new PointDescription();
        public Point (int xPos, int yPos, string petName) { X = xPos;  Y = yPos; desc.PetName = petName; }
        public Point(int xPos, int yPos) { X = xPos; Y = yPos; }
        public Point() { }
        public override string ToString()
        {
            return string.Format("X = {0}, Y = {1}, Name = {2}, \nID = {3}", X, Y,desc.PetName,desc.PointID);
        }
        public object Clone()
        {
            Point newPoint = (Point)this.MemberwiseClone(); // 2 linki na jeden i ten sam obiekt + kopia 
        //    PointDescription currentDesc = new PointDescription();
         //   currentDesc.PetName = this.desc.PetName;
        //    newPoint.desc = currentDesc;   //this.desc.PetName;
            return newPoint;
        }
    }
}
