using static System.Console;
class Result
{

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        var amOrPm = s.Substring(8);
        var hourComponent = s.Substring(0, 2);
        var remainingTimeComponent = s.Substring(2, 6);

        if(amOrPm == "AM" && hourComponent == "12")
        {
            hourComponent = "00";
        }
        else if(amOrPm == "PM" && hourComponent != "12")
        {
            var numericHourComponent = int.Parse(hourComponent);
            hourComponent = Convert.ToString(12 + numericHourComponent);
        }
        return (hourComponent + remainingTimeComponent);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string s = ReadLine();

        string result = Result.timeConversion(s);

        WriteLine(result);
    }
}
