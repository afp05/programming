using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
    
    class Tubless
    {
         public int Weight { get; set; }
         public int ProtectorHeight { get; set; }
    }
    class Felga 
    {
        public int Weight { get; set; }
    }

    class Wheel
    {
        protected Tubless tube = new Tubless();
        protected Felga felg = new Felga();

        public Wheel()
        {
            tube.Weight = 4;
            felg.Weight = 9;
        }

        public int Weight { get { return tube.Weight + felg.Weight; }  }
        public int Preasure { get; set; }
        public int Radius { get { return 13; } }

        
        
    }
}
