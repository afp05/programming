using System;
using System.Collections.Generic;
using System.Text;

namespace ObserableCollections
{
    public class Person
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person()
        {

        }
        public Person(string name,string lastname,int age)
        {
            Age = age;
            FirstName = name;
            LastName = lastname;
        }
        public override string ToString()
        {
            string s = FirstName+" "+LastName+" "+Age+" years old";  
           //Console.WriteLine("{0} {1} is {2} years old", this.FirstName, this.LastName, this.Age);
            return s;
        }
        
    
    }
}
