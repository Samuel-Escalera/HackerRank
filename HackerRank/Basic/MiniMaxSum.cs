using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Basic
{
    public class MiniMaxSum
    {
        public static void miniMaxSumSolution(List<int> arr)
        {
            long totalSum = 0;
            foreach (var number in arr)
            {
                totalSum += number;
            }
            long minSum = totalSum;
            long maxSum = 0;

            foreach (var number in arr)
            {
                if ((totalSum - number) < minSum)
                {
                    minSum = totalSum - number;
                }

                if ((totalSum - number) > maxSum)
                {
                    maxSum = totalSum - number;
                }
            }
            

            Console.WriteLine($"{minSum} {maxSum}");
        }
        /*
        public static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            MiniMaxSum.miniMaxSumSolution(arr);
        }
        */
    }
}