using static System.Console;
class Result
{

    /*
     * Complete the 'birthdayCakeCandles' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY candles as parameter.
     */

    public static int birthdayCakeCandles(List<int> candles)
    {
        int max = 0;
        int blowOutCandles = 0;

        foreach(var item in candles)
        {
            if(item > max)
            {
                max = item;
                blowOutCandles = 1;
            }
            else if(item == max)
                blowOutCandles++;
        }
        return blowOutCandles;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int candlesCount = Convert.ToInt32(ReadLine().Trim());

        List<int> candles = ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

        int result = Result.birthdayCakeCandles(candles);

        WriteLine(result);
    }
}
