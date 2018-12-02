using System;

namespace _01_Task
{
    class Program
    {
        static int numberOfLoops;
        static int numberOfIterations;
        static int[] loops;

        static void NestedLoops(int currentLoop)
        {
            if (currentLoop == numberOfLoops)
            {
                PrintLoops();
                return;
            }
            for (int counter = 1; counter <= numberOfIterations; counter++)
            {
                loops[currentLoop] = counter;
                NestedLoops(currentLoop + 1);
            }
        }

        static void PrintLoops()
        {
            for (int i = 0; i < numberOfLoops; i++)
            {
                Console.Write("{0} ", loops[i]);
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter N: ");
            numberOfLoops = int.Parse(Console.ReadLine());
            numberOfIterations = numberOfLoops;
            loops = new int[numberOfLoops];
            NestedLoops(0);
        }
    }
    }





