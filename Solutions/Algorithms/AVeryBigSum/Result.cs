using static System.Console;
class Result
{

    /*
     * Complete the 'aVeryBigSum' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts LONG_INTEGER_ARRAY ar as parameter.
     */

    public static long aVeryBigSum(List<long> ar)
    {
        long sum = 0;
        
        foreach(var item in ar)
        {
            sum = sum + item;
        }
        return sum;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int arCount = Convert.ToInt32(ReadLine().Trim());

        List<long> ar = ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt64(arTemp)).ToList();

        long result = Result.aVeryBigSum(ar);

        WriteLine(result);
    }
}
