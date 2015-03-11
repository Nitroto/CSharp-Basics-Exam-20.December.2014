using System;
using System.Globalization;
using System.Threading;

class BitLock
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string[] numbers = Console.ReadLine().Split(' ');
        int[] nums = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            nums[i] = int.Parse(numbers[i]);
        }
        for (int i = 0; i < 30; i++)
        {
            string[] commands = Console.ReadLine().Split(' ');
            int row;
            int col;
            int rotation;
            string command;
            bool chk = int.TryParse(commands[0], out row);
            if (chk)
            {
                command = commands[1];
                rotation = int.Parse(commands[2])%12;
                int movement = 12 - rotation;
                if (nums[row] == 0)
                {
                    nums[row] = 0;
                }
                else if (command == "right")
                {
                    int mask = maskGenerator(rotation);
                    mask = (mask & nums[row]) << movement;
                    nums[row] = nums[row] >> rotation;
                    nums[row] = mask | nums[row];
                }
                else 
                {
                    int mask = nums[row] >> movement;
                    nums[row] = nums[row] << rotation;
                    nums[row] = (mask | nums[row])&maskGenerator(12);
                }
            }
            else 
            {
                if (commands[0] == "check")
                {
                    col = int.Parse(commands[1]);
                    int bitCounter = 0;
                    for (int j = 0; j < nums.Length; j++)
                    {
                        int bit = nums[j] >> col & 1;
                        if (bit == 1)
                        {
                            bitCounter++;
                        }
                    }
                    Console.WriteLine(bitCounter);
                }
                else
                {
                    break;
                }
            }
        }
        foreach (int num in nums)
        {
            Console.Write("{0} ", num);
        }
        Console.WriteLine();
    }

    private static int maskGenerator(int rotation)
    {
        int mask = 0;
        for (int bitMask = 0; bitMask < rotation; bitMask++)
        {
            mask = mask << 1 | 1;

        }
        return mask;
    }
}
