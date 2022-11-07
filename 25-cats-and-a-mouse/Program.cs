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

class Solution
{

    // Complete the catAndMouse function below.
    static string catAndMouse(int x, int y, int z)
    {
        int maxDistance = new[] { x, y, z }.Max();

        for (int i = 0; i < maxDistance; i++)
        {
            if (x<z)
            {
                x++;
            }
            else
            {
                x--;
            }

            if (y<z)
            {
                y++;
            }
            else
            {
                y--;
            }

            if (x == z && y == z)
            {
                return "Mouse C";
            }
            if (x == z)
            {
                return "Cat A";
            }
            if (y == z)
            {
                return "Cat B";
            }
        }
            return "";

        //var stepsA = Math.Abs(x - z);
        //var stepsB = Math.Abs(y - z);
        //if (stepsA == stepsB)
        //    return "Mouse C";
        //else if (stepsA < stepsB)
        //    return "Cat A";
        //return "Cat B";

    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string[] xyz = Console.ReadLine().Split(' ');
            // 1 2 3
            // 1 3 2

            int x = Convert.ToInt32(xyz[0]);

            int y = Convert.ToInt32(xyz[1]);

            int z = Convert.ToInt32(xyz[2]);

            string result = catAndMouse(x, y, z);

            Console.WriteLine(result);
        }

        //textWriter.Flush();
        //textWriter.Close();
    }
}
