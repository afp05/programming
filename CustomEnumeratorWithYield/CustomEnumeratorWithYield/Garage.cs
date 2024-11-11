using System;
using System.Collections;
using System.Text;

namespace CustomEnumeratorWithYield
{
    public class Garage : IEnumerable
    {
        private  Car[] carArray = new Car[4];

        public Garage()
        {
            carArray[0] = new Car("Rusty", 130);
            carArray[1] = new Car("Bmw", 200);
            carArray[2] = new Car("Audi", 130);
            carArray[3] = new Car("Polonez", 20);

        }
        public IEnumerator GetEnumerator()
        {
          foreach (Car c in carArray)
            {
                yield return c;
            }
        }
        public IEnumerable GetTheCars (bool ReturnRevesed)
        {
            if (ReturnRevesed)
            {
                for (int i = carArray.Length; i != 0; i--)
                {
                    yield return carArray[i - 1];
                }
            }
            else foreach (Car c in carArray)
                {
                    yield return c;
                }
            
        }
    }
}
