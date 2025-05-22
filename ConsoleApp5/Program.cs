using System;
using System.Threading.Channels;

namespace ConsoleApp5

{
    class Program
    {

        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.ShowData();

            Point p2 = new Point(1,2);
            p2.ShowData();

            Point p3 = new Point(3, 4);
            p3.ShowData();

            Counter c = new Counter(0, 100);
            c.Increment();
            Console.WriteLine(c.CurrentData());
            c.Increment();
            Console.WriteLine(c.CurrentData());
            c.Increment();
            Console.WriteLine(c.CurrentData());

        }
    }


    struct Point
    {

        public int X { get; set; }
        public int Y { get; set; }

        public Point()
        {
            X = 0;
            Y = 0;
        }

        public Point(int x ,int y)
        {
            X = x;
            Y = y;
        }

        public void ShowData()
        {
            Console.WriteLine($"({X},{Y})");
        }
        
    }


    struct Counter
    {
        int min;
        int max;
        int current;

        public Counter(int min,int max)
        {
            min = min;
            max = max;
            current = min;
        }

        public void Increment()
        {
            if (current < max)
            {
                current++;
            }
            else
            {
                current = min;
            }
        }

        public int CurrentData()
        {
            return current;
        }
    }

}
