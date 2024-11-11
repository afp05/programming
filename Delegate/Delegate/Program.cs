using System;


namespace Delegate
{


    class Program
    {

        static void Main(string[] args)
        {


            car BMW = new car();
            Console.WriteLine("Wheel raius :{0}, preasure : {1}", BMW.WheelRadius(), BMW.WheelPreasure());
            // Console.WriteLine(DisplaySizeOf<BMW>());
            RGB p = new RGB();
            p.R = 100;
            p.G = 101;
            p.B = 102;
            Picture<RGB> pic = new Picture<RGB>();
            for (int j = 0; j < 100000000; j++)
            {


                for (int i = 0; i < 10; i++)
                {
                    pic.data[i] = p;
                    pic.data[i].R += (byte)i;
                    pic.data[i].G += (byte)i;
                    pic.data[i].B += (byte)i;
                    // Console.WriteLine(pic.data[i].R);
                }
            }
            /*unsafe
            {
                fixed (RGB* s = &pic.data[0])
                {
                    byte* b = (byte*) s; 
                    for (int i = 0; i < 11*3; i++)
                    {


                        Console.WriteLine(*(b+i));
                    }
                }
            }
            */
            Console.WriteLine("Finished");
           Console.ReadKey();

        }

            
        
    }
}
