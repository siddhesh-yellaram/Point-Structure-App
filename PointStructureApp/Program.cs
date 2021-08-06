using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointStructureApp
{
    class Program
    {
        public struct Point
        {
            private int _x;
            private int _y;

            public Point(int x, int y)
            {
                _x = x;
                _y = y;
            }

            public int X
            {
                get
                {
                    return _x;
                }
                set
                {
                    _x = value;
                }
            }

            public int Y
            {
                get
                {
                    return _y;
                }
                set
                {
                    _y = value;
                }
            }
        }
        static void Main(string[] args)
        {
            Point p1 = new Point(4, 5);
            UpdatePoint(p1);
            PrintDetails(p1);
            Console.ReadLine();
        }

        static void UpdatePoint(Point obj)
        {
            obj.X = 15;
            obj.Y = 40;
        }

        static void PrintDetails(Point obj)
        {
            Console.WriteLine("X-axis Point: " + obj.X);
            Console.WriteLine("Y-axis Point: " + obj.Y);
        }
    }
}
