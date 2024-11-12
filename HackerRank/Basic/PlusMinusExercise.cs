using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Basic
{
    public class PlusMinusExercise
    {
        public static List<int> NumbersProcessor(List<int> array)
        {
            int positiveNumbers = 0;
            int negativeNumbers = 0;
            int zeros = 0;

            foreach (var number in array)
            {
                switch (number)
                {
                    case 0:
                        zeros++;
                        break;
                    case > 0:
                        positiveNumbers++;
                        break;
                    case < 0:
                        negativeNumbers++;
                        break;
                }
            }

            return new List<int> { positiveNumbers, negativeNumbers, zeros };
        }

        public static void PlusMinus(int arraySize, List<int> numbersType)
        {
            double positiveNumbersRation = (double)numbersType[0] / arraySize;
            double negativeNumbersRation = (double)numbersType[1] / arraySize;
            double zeroRation = (double)numbersType[2] / arraySize;

            Console.WriteLine(positiveNumbersRation.ToString("F6"));
            Console.WriteLine(negativeNumbersRation.ToString("F6"));
            Console.WriteLine(zeroRation.ToString("F6"));
        }
/*
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp))
                .ToList();

            PlusMinusExercise.PlusMinus(n, PlusMinusExercise.NumbersProcessor(arr));
        }
*/
    }
}