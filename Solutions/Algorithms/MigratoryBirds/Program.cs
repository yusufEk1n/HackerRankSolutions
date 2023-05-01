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
     * Complete the 'migratoryBirds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int migratoryBirds(List<int> arr)
    {
        var arrType = new int[5];

        for (int i = 0; i < arr.Count; i++)
            arrType[arr[i] - 1]++;

        int moreFrequencieElement = arrType[0];
        int moreFrequenciesNum = 1;

        for (int i = 1; i < 5; i++)
        {
            if (arrType[i] > moreFrequencieElement)
            {
                moreFrequencieElement = arrType[i];
                moreFrequenciesNum = i + 1;
            }
        }

        return moreFrequenciesNum;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.migratoryBirds(arr);
    }
}
