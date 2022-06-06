using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sumLeft = 0;
            int sumRight = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers.Length == 1)
                {
                    Console.WriteLine(0);
                    return;
                }
                sumLeft = 0;
                for (int leftSum = i; leftSum > 0; leftSum--)
                {
                    int nextLeftElement = leftSum - 1;
                    if (leftSum > 0)
                    {
                        sumLeft += numbers[nextLeftElement];
                    }
                }
                sumRight = 0;
                for (int j = i; j < numbers.Length; j++)
                {
                    int nextRightElement = j + 1;
                    if (j < numbers.Length - 1)
                    {
                        sumRight += numbers[nextRightElement];
                    }
                }
                if (sumRight == sumLeft)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
