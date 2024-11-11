using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
    class car
    {
        Wheel koleso = new Wheel();
        
        public int WheelRadius ()
        {
            return koleso.Radius;
        }

        public int WheelPreasure()
        {
            return koleso.Preasure;
        }
        public car()
        {
            koleso.Preasure = 2;
        }

        public Wheel koles
        {
            get { return koleso; }
        }

    }
}
