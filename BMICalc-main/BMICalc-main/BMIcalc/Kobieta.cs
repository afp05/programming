using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIcalc
{
    class Kobieta
    {
        public double waga;
        public double wzrost;
        public double BMI;
        public string message;
        public Kobieta()
        {
            waga = 0;
            wzrost = 0;
        }
        public Kobieta(double weight, double heigth)
        {
            waga = weight;
            wzrost = heigth;
        }
        public string calculateBMI()
        {
            wzrost = wzrost / 100;
            BMI = waga / (wzrost * wzrost);
            if (BMI < 18.4) message = "Niedowaga. Musiałabyś trochy więcej jeść!";
            if (BMI >= 18.5 && BMI <= 24.8) message =  "Waga jest w porządku. Tak trzymać!";
            if (BMI >= 24.8 && BMI <= 29.9) message =  "Nadwaga. Musiałabyś trochy więcej ćwiczyć!";
            if (BMI >= 29.9) message =  "Otyłość. Pilnie zadzwoń do lekarza.";
            return message;
        }
    }
}
