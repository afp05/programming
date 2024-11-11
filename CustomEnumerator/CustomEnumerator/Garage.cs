using System;
using System.Collections;
using System.Text;

namespace CustomEnumerator 
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
            return carArray.GetEnumerator();
        }
    }
}
