//https://github.com/idivyanshusoni
using DotNetDSAPractice;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        ////leetcode #1
        //var indices = new TwoSum().Perform(new int[] { 2, 7, 11, 15 }, 9);
        //Console.WriteLine("Indices: " + string.Join(", ", indices));

        ////leetcode #2
        //ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
        //ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
        //var sum = new AddTwoNumbers().Perform(l1, l2);
        //Print(sum);

        ////leetcode #3
        //var maxLength = new LongestSubstringWithoutRepeatingCharacters().Perform("abcabcabb");
        //Console.WriteLine("maxLength: " + maxLength);

        //leetcode #4
        var median1 = new MedianOfTwoSortedArrays().Perform(new int[] { 1, 3 }, new int[] { 2 });
        Console.WriteLine(median1);
        var median2 = new MedianOfTwoSortedArrays().Perform(new int[] { 1, 2 }, new int[] { 3, 4 });
        Console.WriteLine(median2);
    }

    public static void Print(ListNode head)
    {
        while (head != null)
        {
            Console.Write(head.val);

            if (head.next != null)
                Console.Write(" --> ");

            head = head.next;
        }

        Console.WriteLine();
    }
}
