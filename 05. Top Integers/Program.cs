using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < inputArray.Length; i++)
            {
                bool currBigNum = true;
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    if (inputArray[i] <= inputArray[j])
                    {
                        currBigNum = false;
                    }
                }
                if (currBigNum)
                {
                    Console.Write($"{inputArray[i]} ");
                }

            }
        }
    }
}
