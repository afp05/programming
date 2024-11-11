using System;
using System.Collections;
using System.Text;

namespace ComparableCar
{

    class Car : IComparable
    {
        public const int MaxSpeed = 100;
        public int CarID { get; set; }
        public int CurrentSpeed { get; set; }
        public string PetName { get; set; }
        public static IComparer SortByPetName { get { return (IComparer)new PetNameComparer(); } }
        private bool carIsDead;
        private Radio theMusicBox = new Radio();
        public Car() { }
        public Car(string name, int speed, int id)
        {
            CurrentSpeed = speed;
            PetName = name;
            CarID = id;
        }

        public void CrankTunes (bool state)
        {
            theMusicBox.TurnOn(state);
        }
        public void Accelerate(int delta)
        {
            if (carIsDead) Console.WriteLine("{0} is out of order....", PetName);
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed > MaxSpeed)
                {
                    Console.WriteLine("{0} has overheated!!!", PetName);
                    CurrentSpeed = 0;
                    carIsDead = true;
                    throw new Exception(string.Format("{0} has overhaeted", PetName));
                }
                else Console.WriteLine("=> Current speed is {0}", CurrentSpeed);
            }
        }
        int IComparable.CompareTo(object obj)
        {
            Car temp = obj as Car;
            if (temp != null)
            {
                if (this.CarID > temp.CarID) return 1;
                if (this.CarID < temp.CarID) return -1;
                else return 0;
            }
            else throw new ArgumentException("Parametr is not a Car compatible");
        }
    }
}
