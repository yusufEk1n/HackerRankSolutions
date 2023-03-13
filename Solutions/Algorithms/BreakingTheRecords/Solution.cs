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

class Result
{

    /*
     * Complete the 'breakingRecords' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY scores as parameter.
     */

    public static List<int> breakingRecords(List<int> scores)
    {
        List<int> breakingRecords = new List<int>() {0, 0};
        int highestScore = scores[0];
        int lowestScore = scores[0];

        for(int i = 1; i < scores.Count; i++)
        {
            if(scores[i] < lowestScore)
            {
                lowestScore = scores[i];
                breakingRecords[1]++;
            }
            
            if(scores[i] > highestScore)
            {
                highestScore = scores[i]; 
                breakingRecords[0]++;
            }
        }

        return breakingRecords;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

        List<int> result = Result.breakingRecords(scores);
    }
}
