using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class FindTheMedian
{
    public static List<int> sortList(List<int> arr)
    {
        int arrSize = arr.Count;
        bool swapped;

        do
        {
            swapped = false;

            for (int i = 0; i < arrSize -1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    int temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                    
                    swapped = true;
                }
            }

            arrSize--;
        } while (swapped);
        
        return arr;
    }
    public static int findMedian(List<int> arr)
    {
        arr.Sort();
        int arrSize = arr.Count;

        if (arrSize % 2 == 0)
        {
            int median = ((arr[arrSize / 2]) + (arr[(arrSize / 2) + 1])) / 2;
            return median;
        }
        
        return arr[arrSize / 2];
        
    }
    
    /*
    public static void Main(string[] args)
    {
        

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

       
       
        int result = FindTheMedian.findMedian(arr);
        Console.WriteLine(result);
    }
    */
}