
using System.Linq;
class SolutionTwo
{
    public static void Main(String[] args)
    {

        string[] arr = { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" };
        Console.WriteLine(dirReduc(arr));
    }

    public static string[] dirReduc(String[] arr) {

        int arrSize = 0;
        while (arrSize != arr.Count())
        {
            arrSize = arr.Count();
            for (int i = 0; i < arr.Count(); i++)
            {
                for (int j = 0; j < arr.Count(); j++)
                {
                    if (arr[i] == "NORTH" && arr[j] == "SOUTH")
                    {
                        if (j == i + 1)
                        {
                            arr[i] = "";
                            arr[j] = "";
                        }
                    }
                    else if (arr[i] == "SOUTH" && arr[j] == "NORTH")
                    {
                        if (j == i + 1)
                        {
                            arr[i] = "";
                            arr[j] = "";
                        }
                    }
                    else if (arr[i] == "EAST" && arr[j] == "WEST")
                    {
                        if (j == i + 1)
                        {
                            arr[i] = "";
                            arr[j] = "";
                        }
                    }
                    else if (arr[i] == "WEST" && arr[j] == "EAST")
                    {
                        if (j == i + 1)
                        {
                            arr[i] = "";
                            arr[j] = "";
                        }
                    }
                }
            }

            arr = arr.Where(x => x != "").ToArray();
        }

        return arr;
    }
}