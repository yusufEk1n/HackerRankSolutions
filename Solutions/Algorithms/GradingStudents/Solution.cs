using static System.Console;

class Result
{

    /*
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */

    public static List<int> gradingStudents(List<int> grades)
    {
        List<int> finalGrade = new List<int>();
        int passingGrade = 38;

        foreach(int grade in grades)
        {
            if(grade < passingGrade || grade % 5 < 3)
            {
                finalGrade.Add(grade);
            }
            else
            {
                finalGrade.Add(grade + (5 - (grade % 5)));
            }
        }

        // for(int i = 0; i < grades.Count; i++)
        // {
        //     if(grades[i] < 38)
        //     {
        //         finalGrade.Add(grades[i]);
        //     }
        //     else
        //     {
        //         int remainder = grades[i] % 5;
        //         if((5 - remainder) < 3)  
        //         {
        //             finalGrade.Add(grades[i] + (5 - remainder));
        //         }
        //         else
        //         {
        //             finalGrade.Add(grades[i]);
        //         }
        //     }
        // }
        return finalGrade;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int gradesCount = Convert.ToInt32(ReadLine().Trim());

        List<int> grades = new List<int>();

        for (int i = 0; i < gradesCount; i++)
        {
            int gradesItem = Convert.ToInt32(ReadLine().Trim());
            grades.Add(gradesItem);
        }

        List<int> result = Result.gradingStudents(grades);

        foreach(var item in result)
        {
            WriteLine(item);
        }
    }
}
