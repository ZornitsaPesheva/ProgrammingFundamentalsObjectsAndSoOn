using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Circles_Intersection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] p1 = Console.ReadLine().
                Split().Select(int.Parse).ToArray();
            int[] p2 = Console.ReadLine().
                Split().Select(int.Parse).ToArray();
            Circle c1 = null;
            Circle c2 = null;
            c1.Center.X = p1[0];
            c1.Center.Y = p1[1];
            c1.Radius = p1[2];
            c2.Center.X = p2[0];
            c2.Center.Y = p2[1];
            c2.Radius = p2[2];
            if (Inrersect(c1, c2))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        static bool Inrersect(Circle c1, Circle c2)
        {
            double d = CalcDistance(c1.Center, c2.Center);
            if (d <= c1.Radius + c2.Radius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static double CalcDistance(Point p1, Point p2)
        {
            int deltaX = p2.X - p1.X;
            int deltaY = p2.Y - p1.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }

    class Circle
    {
        public Point Center { get; }
        public int Radius { get; set; }

    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
