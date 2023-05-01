using static System.Console;
class Result
{

    /*
     * Complete the 'simpleArraySum' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY ar as parameter.
     */

    public static int simpleArraySum(List<int> arr)
    {
        int sum = 0;

        for(int i = 0; i < arr.Count; i++)
        {
            sum = sum + arr[i];
        }

        return sum;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int arCount = Convert.ToInt32(ReadLine().Trim());

        List<int> ar = ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int result = Result.simpleArraySum(ar);

        WriteLine(result);
    }
}
