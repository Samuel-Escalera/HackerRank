using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Basic;

public class LonleyInteger
{
    public static int lonelyinteger(List<int> arr)
    {
        foreach (var number in arr)
        {
            List<int> tempList = arr.ToList();

            tempList.Remove(number);

            if (tempList.Contains(number))
            {
                continue;
            }

            return number;
        }

        return 0;
    }

    /*
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = lonelyinteger(arr);
        Console.WriteLine(result);
    }
    */
}
