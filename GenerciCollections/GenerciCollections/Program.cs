using System;
using System.Collections.Generic;

namespace GenerciCollections
{
    class Program
    {
        static void UseSortedSet()
        {
            SortedSet<Person> setOfPeople = new SortedSet<Person>(new SortPeopleByAge())
            {
            new Person { FirstName = "Homer", LastName = "Simpson", Age = 28 },
            new Person { FirstName = "Merge", LastName = "Simpson", Age = 68 },
            new Person { FirstName = "Lisa", LastName = "Simpson", Age = 17 },
            new Person { FirstName = "Bart", LastName = "Simpson", Age = 24 }
             };
            foreach (Person p in setOfPeople) Console.WriteLine(p);
            setOfPeople.Add(new Person { FirstName = "Saku", LastName = "Jones", Age = 4 });
            setOfPeople.Add(new Person { FirstName = "Mikko", LastName = "Jones", Age = 34 });
            foreach (Person p in setOfPeople) Console.WriteLine(p);
        }
        static void Main(string[] args)
        {
            static void GetCoffee(Person p)
            {
                Console.WriteLine("{0} got coffee", p.FirstName);
            }
            static void UseGenericQueue()
            {
                Queue<Person> peopleQ = new Queue<Person>();
                peopleQ.Enqueue(new Person { FirstName = "Homer", LastName = "Simpson", Age = 28 });
                peopleQ.Enqueue(new Person { FirstName = "Merge", LastName = "Simpson", Age = 68 });
                peopleQ.Enqueue(new Person { FirstName = "Lisa", LastName = "Simpson", Age = 17 });
                Console.WriteLine("{0} is first in line", peopleQ.Peek().FirstName);
                GetCoffee(peopleQ.Dequeue());
                GetCoffee(peopleQ.Dequeue());
                GetCoffee(peopleQ.Dequeue());
                try
                {
                    GetCoffee(peopleQ.Dequeue());
                }
                catch (InvalidCastException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            static void UseGenericStat()
            {
                Stack<Person> stackOfPeople = new Stack<Person>();
                stackOfPeople.Push(new Person { FirstName = "Homer", LastName = "Simpson", Age = 28 });
                stackOfPeople.Push(new Person { FirstName = "Merge", LastName = "Simpson", Age = 68 });
                stackOfPeople.Push(new Person { FirstName = "Lisa", LastName = "Simpson", Age = 17 });
                // stackOfPeople.Push(new Person { FirstName = "Homer", LastName = "Simpson", Age = 28 });\
                foreach (Person p in stackOfPeople) Console.WriteLine(p);
                Console.WriteLine("First person is: {0}", stackOfPeople.Peek());
                Console.WriteLine("pOPPED OFF {0}", stackOfPeople.Pop());
                Console.WriteLine("First person is: {0}", stackOfPeople.Peek());
                Console.WriteLine("pOPPED OFF {0}", stackOfPeople.Pop());
                Console.WriteLine("First person item is: {0}", stackOfPeople.Peek());
                Console.WriteLine("pOPPED OFF {0}", stackOfPeople.Pop());
                try
                {
                    Console.WriteLine("First person is: {0}", stackOfPeople.Peek());
                    Console.WriteLine("Popped off {0}", stackOfPeople.Pop());
                }
                catch (InvalidCastException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            static void UseGenericList()
            {
                List<Person> people = new List<Person>()
                {
                new Person { FirstName = "Homer", LastName = "Simpson", Age = 28 },
                new Person { FirstName = "Merge", LastName = "Simpson", Age = 68 },
                new Person { FirstName = "Lisa", LastName = "Simpson", Age = 17 },
                new Person { FirstName = "Bart", LastName = "Simpson", Age = 24 }
                };
                Console.WriteLine("Items in list: {0}", people.Count);
                foreach (Person p in people) Console.WriteLine(p);
                Console.WriteLine("Inserting new person...");
                people.Insert(2, new Person { FirstName = "Koli", LastName = "Simpson", Age = 12 });
                Console.WriteLine("{0} items in list", people.Count);
                Person[] arrayOfPeople = people.ToArray();
                for (int i = 0; i< arrayOfPeople.Length; i++) Console.WriteLine("First names: {0}", arrayOfPeople[i].FirstName);
            }

            // UseGenericList();
            //UseGenericStat();
            //UseGenericQueue();
            UseSortedSet();
        }
    }
}

