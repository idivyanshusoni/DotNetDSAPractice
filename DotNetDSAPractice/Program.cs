//https://github.com/idivyanshusoni
using DotNetDSAPractice;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //leetcode #1
        var indices = new TwoSum().Perform(new int[] { 2, 7, 11, 15 }, 9);
        Console.WriteLine("Indices: " + string.Join(", ", indices));
    }
}