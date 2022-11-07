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
     * Complete the 'gradingStudents' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY grades as parameter.
     */

    public static List<int> gradingStudents(List<int> grades)
    {

        for (int i = 0; i < grades.Count; i++)
        {
            if (grades[i] >= 38)
            {
                int nextMultiple = (5 * ((grades[i] - 1) / 5 + 1));
                if (nextMultiple - grades[i] <= 2)
                {
                    grades[i] = nextMultiple;
                }
            } 
        }

        return grades;
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        int gradesCount = Convert.ToInt32(4);

        List<int> grades = new List<int>();

        //for (int i = 0; i < gradesCount; i++)
        //{
        //    int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
        //    grades.Add(gradesItem);
        //}

        grades.Add(73);
        grades.Add(67);
        grades.Add(38);
        grades.Add(33);

        List<int> result = Result.gradingStudents(grades);

        Console.WriteLine(String.Join("\n", result));

    }
}
