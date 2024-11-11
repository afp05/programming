using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Person
    {
        private string surname;
        public Person()
        {
            surname = "";
            Console.WriteLine("Ctor base Person");
        }
        public Person( string name)
        {
            surname = name;
            Console.WriteLine("Ctro person with 1 parametr, class Person");
        }
    }
    
    abstract partial class Employees : Person
    {
      public  class BenefitPackage
        {
            public double ComputePayDeduction()
            {
                return 125.0;
            }
            public enum BenefitPackageLevel
            {
                Standart, Gold, Platinum
            }

        }
        protected string empName;
        protected int empID;
        protected float currPay;
        protected int empAge;
        protected string empSSN;
        protected BenefitPackage empBenefits = new BenefitPackage();
        

        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }
        public string Name

        {
            get { return empName; }
            set { if (value.Length > 15) Console.WriteLine("Error - too longe  name!!!"); else empName = value; }
        }
        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }
        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }

        public string SocialSecurityNumber
        {
            get { return empSSN; }
        }
        public Employees() : base("") { }
       
       

        public Employees(string name, int id, float pay) 
            
            : this(name, 0, id, pay) { Console.WriteLine("Ctor with 3 pramaetrs class Employee"); }

        public Employees(string name, int age, int id, float pay)
            : base ()
            
        {
            empName = name;
            empID = id;
            currPay = pay;
            empAge = age;
            Console.WriteLine("Ctor with 4 parametrs. Class Employee");
        }
        public Employees(string name, int age, int id, float pay, string ssn)
        {
            empName = name;
            empID = id;
            currPay = pay;
            empAge = age;
            empSSN = ssn;
        }
        public virtual void GiveBonus (float amount)
        {
            Pay += amount;
        }
        public virtual void DisplayStats()
        {
            Console.WriteLine("Name : {0}", empName);
            Console.WriteLine("ID : {0}", empID);
            Console.WriteLine("Pay : {0}", currPay);
            Console.WriteLine("Age : {0}", empAge);

        }
        public string GetName()
        {
            return empName;
        }
        public void SetName (string name)
        {
            if (name.Length > 15)
            
                Console.WriteLine("Error! Name must be less than 16 characters!!!!");
                else empName = name;
            
        }
        public double GetBenefitCost()
        {
            return empBenefits.ComputePayDeduction();
        }
        public BenefitPackage Benefits { get { return empBenefits;  } set { empBenefits = value; } }
    }
}
