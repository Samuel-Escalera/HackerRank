using System;
using System.IO;

namespace HackerRank.Basic;

class TimeConversion
{

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        string houres = $"{s[0]}{s[1]}";
        string minutes = $"{s[3]}{s[4]}";
        string seconds = $"{s[6]}{s[7]}";
        bool isAm =  true;
        
        if ($"{s[8]}{s[9]}" == "PM")
        {
            isAm = false;
        }

        if (isAm == false)
        {
            if (houres != "12")
            {
                houres =  $"{Convert.ToInt32(houres) + 12}";
            }

            return $"{houres}:{minutes}:{seconds}";
        }

        if (houres == "12")
        {
            houres = "00";
        }
        return $"{houres}:{minutes}:{seconds}";
    }
    
    /*
    public static void Main(string[] args)
    {
       

        string s = Console.ReadLine();

        string result = TimeConversion.timeConversion(s);

        Console.WriteLine(result);
    }*/

}