using System;
class Result
{

    public static int simpleArraySum(List<int> ar)
    {
        return ar.Sum();
    }

    static void Main(String[] args)
    {

        int arCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int result = Result.simpleArraySum(ar);

        Console.WriteLine(result);
    }
}