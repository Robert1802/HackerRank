using System.Linq;
class Solution
{
    public static void Main(string[] args)
    {

        Console.WriteLine(HasUniqueChars("abcdefg"));
    }

    public static bool HasUniqueChars(string str)
    {
        if (str.Length != str.Distinct().Count())
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}