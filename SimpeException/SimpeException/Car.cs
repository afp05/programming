﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SimpeException
{
    class Car
    {
        public const int MaxSpeed = 100;

        public int CurrentSpeed { get; set; }
        public string PetName { get; set; }
        private bool carIsDead;
        private Radio theMusicBox = new Radio();
        public Car() { }
        public Car(string name, int speed)
        {
            CurrentSpeed = speed;
            PetName = name;
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
    }
}
