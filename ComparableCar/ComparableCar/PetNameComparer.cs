using System;
using System.Collections;
using System.Text;

namespace ComparableCar
{
    class PetNameComparer : IComparer
    {
        int IComparer.Compare(object o1, object o2)
        {
            Car t1 = o1 as Car;
            Car t2 = o2 as Car;
            if (t1 != null)
            
                return String.Compare(t1.PetName, t2.PetName);
                else throw new ArgumentException("Parametr is not a car");
            
        }
    }
}
