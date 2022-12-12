using System;

namespace ClonablePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun With Clone ");
            Point p1 = new Point(60, 60,"Jamshid");
            Console.WriteLine("P1 is :{0}",p1);
            Point p2 = p1;
            p2.X = 80;
            Console.WriteLine("P1 is :{0}", p1);
            Console.WriteLine("P2.x Changed to 80");
            Console.WriteLine("P1 is :{0}", p2);
            Console.WriteLine( "P3 is Cloned And chand to 70");
            Point p3 = (Point)p1.Clone();
            p3.X = 70;
            Console.WriteLine("P1 is :{0}",p1);
            
            p3.desc.PetName = "Ehsan";
            Console.WriteLine("P3 is :{0}", p3);
            Point p4 = (Point)p3.Clone();
            p4.desc.PetName = "rtett";
            p4.X = 76;
            p4.Y = 78;
            Console.WriteLine("P3 is :{0}", p4);
        }
    }
}
