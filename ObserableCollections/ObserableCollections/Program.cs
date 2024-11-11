using System;
using System.Collections.ObjectModel;

namespace ObserableCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            ObservableCollection<Person> people = new ObservableCollection<Person>()
           {
               new Person {FirstName= "Peter", LastName = "Murphy", Age = 32 },
               new Person {FirstName= "Kevin", LastName = "Key", Age = 28 }
           };
            people.CollectionChanged += people_CollectionChanged;
            people.Add(new Person { FirstName = "Ann", LastName = "Bird", Age = 22 });
        }
        static void people_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            Console.WriteLine("Action for this event: {0}", e.Action);
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("Here are the old items:");
                foreach (Person p in e.OldItems) Console.WriteLine(p.ToString());
            }
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                Console.WriteLine("Here are the new items:");
                foreach (Person p in e.NewItems) Console.WriteLine(p.ToString());
            }
            //throw new NotImplementedException();
        }
    }
}
