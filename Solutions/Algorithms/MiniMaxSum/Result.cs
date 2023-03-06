using static System.Console;
class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        long min = arr[0], max = arr[0];
        long maxSum = 0, minSum = 0;

        for(int i = 0; i < arr.Count; i++)
        {
            if(min > arr[i])
            {
                min = arr[i];
            }
            else if(max < arr[i])
            {
                max = arr[i];
            }

            maxSum += arr[i];
            minSum += arr[i]; 
        }
        WriteLine($"{minSum - max} {maxSum - min}");
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
