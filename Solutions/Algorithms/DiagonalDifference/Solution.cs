using static System.Console;
class Result
{

    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
        int rightDiagonal = 0;
        int leftDiagonal = 0;
        int arrCount = arr.Count;

        for(int i = 0; i < arrCount; i++)
        {
            rightDiagonal = rightDiagonal + arr[i][i];
            leftDiagonal = leftDiagonal + arr[i][arrCount - i - 1];
        }
        return Math.Abs(rightDiagonal - leftDiagonal);
    }   

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);

        WriteLine(result);
    }
}
