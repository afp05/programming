using System;

namespace SimpeException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================== !!! Exceptions !!! ==================" );
            Car mycar = new Car("ZAZ", 29);
            mycar.CrankTunes(true);
            try
            {
                for (int i = 0; i < 910; i++) mycar.Accelerate(10);
            }
            catch(Exception e)
            {
                Console.WriteLine("Error");
                Console.WriteLine("Method: {0} ", e.TargetSite);
                Console.WriteLine("Message; {0} ", e.Message);
                Console.WriteLine("Source : {0} ", e.Source);
                Console.WriteLine("--------end of the error-----------");
            }
            Console.ReadKey();
        }
    }
}
