using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {

            static void DrawIn3d(IDraw3d itf3d)
            {
                Console.WriteLine("--> Drawing IDraw3D compatible type");
                itf3d.Draw3d();
            }
            static IPointy FindFirstPointyShape(Shape[] shapes)
            { 
                foreach (Shape s in shapes)
                {
                    if (s is IPointy)
                        return s as IPointy;
                }
                return null;
            }
            Console.WriteLine("=============== Interface ==============");
            Hexagon hex = new Hexagon();
            Console.WriteLine("Points: {0} ", hex.Points);
            Circle c = new Circle("Lisa");
            IPointy itfPt = null; // Po co zerować?
            try
            {
                itfPt = (IPointy)c;
                Console.WriteLine(itfPt.Points);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }
            Hexagon hex2 = new Hexagon("Peter");
            IPointy itfPt2 = hex2 as IPointy;
            if (itfPt2 != null) Console.WriteLine("Points: {0}", itfPt2.Points);
            else Console.WriteLine("{0} is not hex-compatible", hex2.PetName);
            Shape[] myShapes = { new Hexagon(), new Circle(), new TriAngle("Joe"), new Circle("JoJo") };
            for (int i = 0; i< myShapes.Length; i++)
            {
                myShapes[i].Draw();
                if (myShapes[i] is IPointy) Console.WriteLine("--> Points {0}", ((IPointy)myShapes[i]).Points);
                else Console.WriteLine("--> {0} is not pointy", myShapes[i].PetName);
            }
            Console.WriteLine("---------------------------------------------------------------------------");
            for (int i=0;i<myShapes.Length; i++)
            {
                if (myShapes[i] is IDraw3d) DrawIn3d((IDraw3d)myShapes[i]);
            }
            IPointy firstPointyItem = FindFirstPointyShape(myShapes);
            Console.WriteLine(" First item has {0} points", firstPointyItem.Points);
            Console.WriteLine("---------------------------------------------------------------------------");

            IPointy[] myPointyObjects = { new Hexagon(), new Fork(), new Knife(), new PitchFork(), new TriAngle() };
            foreach( IPointy s in myPointyObjects)
            {
                Console.WriteLine("Objects has {0} points", s.Points);
            }
           Console.ReadKey();
        }
    }
}
