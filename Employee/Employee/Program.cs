using System;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            static void CastingExample()
            {
                object frank = new Manager("Frank Zuppa", 530, 912, 56000, "333-45-435", 21);
                GivePromotion((Manager)frank);
                Employees monnunit = new Manager("MoonUnit", 50, 92, 100000, "333-45-234", 9);
                GivePromotion(monnunit);
                SalesPerson Jill = new PTSalesPerson();
            }
            static void GivePromotion(Employees emp)
            {
                
                Console.WriteLine("{0} was promoted", emp.Name);
                if (emp is SalesPerson)
                {
                    Console.WriteLine("{0} made {1} sales!", emp.Name, ((SalesPerson)emp).SalesNumber);
                    Console.WriteLine();
                }
                if (emp is Manager)
                {
                    Console.WriteLine("{0} has {1} stock options!", emp.Name, ((Manager)emp).StockOptions);
                    Console.WriteLine();
                }
            }
            Console.WriteLine("======================+ Inheritance +======================");
            //SalesPerson fred = new SalesPerson();
            // fred.Age = 31;
            // fred.Name = "Fred";
            // fred.SalesNumber = 50;
            Employees chuck = new Manager("CHucky", 50, 92, 100000, "333-45-234", 9000);
            double cost = chuck.GetBenefitCost();
            chuck.GiveBonus(1);
            chuck.DisplayStats();
            SalesPerson fran = new SalesPerson("Frank", 43, 93, 3000, "4343-544-323", 31);
            fran.GiveBonus(5);
            fran.DisplayStats();
            Employees.BenefitPackage Benefit = chuck.Benefits;
            double cost2 = Benefit.ComputePayDeduction();
            GivePromotion(chuck);
            Console.ReadKey();
        }
    }
}
