using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Segment a = new Segment(1, 2);
            Segment b = new Segment(5, 3);

            Console.WriteLine(a + b);
            a = (5, 6);

            uint length = (uint)b;

            Console.WriteLine(length);
            Console.WriteLine(a);
        }
    }
}
