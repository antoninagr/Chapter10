using System;

namespace _04_Task
{
    class Program
    {
        static int k;
        static string[] strings = { "test", "rock", "fun" };
        static string[] str;
        static void Main(string[] args)
        {
            
            int.TryParse(Console.ReadLine(), out k);
            str = new string[k];
            CyclesNoRepeat(0, 0);
        }

        static void CyclesNoRepeat(int currentIteration, int startIndex)
        {
            if (currentIteration == k)
            {
                PrintLoop();
                return;
            }

            for (int i = startIndex; i < strings.Length; i++)
            {
                str[currentIteration] = strings[i];
                CyclesNoRepeat(currentIteration + 1, i + 1);
            }
        }

        static void PrintLoop()
        {
            for (int i = 0; i < k; i++)
            {
                Console.Write("{0} ", str[i]);
            }
            Console.WriteLine();
        }
    }
}
}
