using System;

namespace CheatSheet
{
    class CheatSheet
    {
        static void Main()
        {
            long r = Int64.Parse(Console.ReadLine());
            long c = Int64.Parse(Console.ReadLine());
            long v = Int64.Parse(Console.ReadLine());
            long h = Int64.Parse(Console.ReadLine());
            for (long i = v; i < r+v; i++) 
            {
                for (long j = h; j < c + h; j++)
                {
                    Console.Write(i * j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
