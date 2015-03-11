using System;

namespace Boat
{
    class Boat
    {
        static void Main()
        {
            int n = Int32.Parse(Console.ReadLine());
            bool middlePoint = true;
            int lineCounter=1;
            int stars = 1;
            int middle = n / 2+1;
            int boatBody = (n-1) / 2;
            int bodyDots = 0;
            do
            {
                if (middlePoint)
                {
                    Console.Write(new string('.', n - stars));
                    Console.Write(new string('*', stars));
                    stars += 2;
                    Console.Write(new string('.', n));
                    Console.WriteLine();
                    lineCounter++;
                    if (lineCounter < middle)
                    {
                        middlePoint = true;
                    }
                    else
                    {
                        middlePoint = false;
                    }
                }
                else
                {
                    Console.Write(new string('.', n - stars));
                    Console.Write(new string('*', stars));
                    Console.Write(new string('.', n));
                    stars -= 2;
                    Console.WriteLine();
                    lineCounter++;
                }
            } while (lineCounter <= n);
            lineCounter = 1;
            do
            {
                Console.Write(new string('.', bodyDots));
                Console.Write(new string('*', 2*n-2*bodyDots));
                Console.Write(new string('.', bodyDots));
                Console.WriteLine();
                bodyDots++;
                lineCounter++;
            }while (lineCounter<=boatBody);
        }
    }
}
