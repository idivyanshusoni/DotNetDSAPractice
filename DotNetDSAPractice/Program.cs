//https://github.com/idivyanshusoni
using DotNetDSAPractice;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        ////leetcode #1
        //var indices = new TwoSum().Perform(new int[] { 2, 7, 11, 15 }, 9);
        //Console.WriteLine("Indices = " + string.Join(", ", indices));

        ////leetcode #2
        //ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
        //ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
        //var sum = new AddTwoNumbers().Perform(l1, l2);
        //Print(sum);

        ////leetcode #3
        //var maxLength = new LongestSubstringWithoutRepeatingCharacters().Perform("abcabcabb");
        //Console.WriteLine("maxLength: " + maxLength);

        ////leetcode #4
        //var median1 = new MedianOfTwoSortedArrays().Perform(new int[] { 1, 3 }, new int[] { 2 });
        //Console.WriteLine(median1);
        //var median2 = new MedianOfTwoSortedArrays().Perform(new int[] { 1, 2 }, new int[] { 3, 4 });
        //Console.WriteLine(median2);

        ////leetcode #5
        //var @string = new LongestPalindromicSubstring().Perform("abbababbabaaababababaabaaaaaaaaaaaaaaaaaa");
        //Console.WriteLine("string = " + @string);

        ////leetcode #7
        //var reverse = new ReverseInteger().Perform(321);
        //Console.WriteLine("reverse = " + reverse);
        //reverse = new ReverseInteger().Perform(1534236469);
        //Console.WriteLine("reverse = " + reverse);

        ////leetcode #10
        //var match = new RegularExpressionMatching().Perform("aa", "a*");
        //Console.WriteLine("match = " + match);
        //match = new RegularExpressionMatching().Perform("aab", "c*a*b");
        //Console.WriteLine("match = " + match);
        //match = new RegularExpressionMatching().Perform("ab", ".*");
        //Console.WriteLine("match = " + match);
        //match = new RegularExpressionMatching().Perform("aa", "a");
        //Console.WriteLine("match = " + match);

        ////leetcode #11
        //var maxVolume = new ContainerWithMostWater().Perform(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 });
        //Console.WriteLine("maxVolume = " + maxVolume);
        //maxVolume = new ContainerWithMostWater().Perform(new int[] { 1, 1 });
        //Console.WriteLine("maxVolume = " + maxVolume);

        ////leetcode #15
        //var threeSum = new ThreeSum().Perform(new int[] { -1, 0, 1, 2, -1, -4 });
        //Console.Write("[ ");
        //foreach (IList<int> triplet in threeSum)
        //{
        //    Console.Write($" [{string.Join(", ", triplet)}] ");
        //}
        //Console.Write(" ]");

        ////leetcode #17
        //var combinations = new LetterCombinationsOfAPhoneNumber().Perform("13324242334442");
        //foreach (var str in combinations)
        //    Console.WriteLine(str);

        //leetcode #19
        //Approach — Two Pointers - fast and slow
        var head = new RemoveNthNodeFromEndOfList().Perform(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5))))), 2);
        Print(head);
        head = new RemoveNthNodeFromEndOfList().Perform(new ListNode(1, new ListNode(2)), 2);
        Print(head);
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
