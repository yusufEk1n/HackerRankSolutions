﻿using static System.Console;
class Result
{

    /*
     * Complete the 'compareTriplets' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

    public static List<int> compareTriplets(List<int> a, List<int> b)
    {
        List<int> result = new List<int>() {0, 0};
        
        for(int i = 0; i < 3; i++)
        {
            if(a[i] > b[i])
            {
                result[0]++;
            }
            else if(a[i] < b[i])
            {
                result[1]++;
            }
        }
        return result;       
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        List<int> a = ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> b = ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

        List<int> result = Result.compareTriplets(a, b);

        WriteLine(String.Join(" ", result));
    }
}
