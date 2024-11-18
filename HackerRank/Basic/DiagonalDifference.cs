using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank.Basic;

public class DiagonalDifference
{
    public static int diagonalDifference(List<List<int>> arr)
    {
        int sumRightDiagonal = SumRightDiagonal(arr);
        int sumLeftDiagonal = SumLeftDiagonal(arr);
        
        int difference = Math.Abs(sumRightDiagonal - sumLeftDiagonal);

        return difference;
    }

    public static int SumRightDiagonal(List<List<int>> arr)
    {
        int sumRightDiagonal =0;
        int matrixSize = arr.Count;
        for (int i = 0; i <= matrixSize - 1; i++)
        {
            sumRightDiagonal += arr[i][i];
        }
        return sumRightDiagonal;
    }
    
    public static int SumLeftDiagonal(List<List<int>> arr)
    {
        int sumLeftDiagonal = 0;
        int matrixSize = arr.Count;
        int aux = matrixSize - 1;
        
        for (int i = 0; i <= matrixSize - 1; i++)
        {
            sumLeftDiagonal += arr[aux][i];
            aux--;
        }
        return sumLeftDiagonal;
    }
    
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        
        List<List<int>> arr = new List<List<int>>();
        
        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = DiagonalDifference.diagonalDifference(arr);

        Console.WriteLine(result);
    }
}
