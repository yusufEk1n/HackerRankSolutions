using static System.Console;
class Result
{

    /*
     * Complete the 'staircase' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void staircase(int n)
    {
        for(int i = 0; i < n; i++)
        {
            for(int j = 1; j <= n; j++)
            {
                if(j < n - i)
                {
                    Write(" ");
                }
                else
                {
                    Write("#");
                }
            }
            WriteLine();
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(ReadLine().Trim());

        Result.staircase(n);
    }
}
