//https://github.com/idivyanshusoni
using DotNetDSAPractice;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        ////leetcode #1
        ////Approach: HashMap / Dictionary
        //var result = new TwoSum().Perform(new int[] { 2, 7, 11, 15 }, 9);
        //Console.WriteLine("Indices = " + string.Join(", ", result));

        ////leetcode #2
        ////Approach
        ////Each number is represented by a linked list in reverse order.
        //ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
        //ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
        //var result = new AddTwoNumbers().Perform(l1, l2);
        //Print(result);

        ////leetcode #3
        ////Approach — Sliding Window
        //var result = new LongestSubstringWithoutRepeatingCharacters().Perform("abcabcabb");
        //Console.WriteLine("maxLength: " + result);

        ////leetcode #4
        ////Approach — Binary Search on the Partition
        //var result = new MedianOfTwoSortedArrays().Perform(new int[] { 1, 3 }, new int[] { 2 });
        //Console.WriteLine(result);
        //result = new MedianOfTwoSortedArrays().Perform(new int[] { 1, 2 }, new int[] { 3, 4 });
        //Console.WriteLine(result);

        ////leetcode #5
        ////Approach — Expand Around Center
        //var result = new LongestPalindromicSubstring().Perform("abbababbabaaababababaabaaaaaaaaaaaaaaaaaa");
        //Console.WriteLine("string = " + result);

        ////leetcode #7
        ////Approach — Digit Extraction
        //var result = new ReverseInteger().Perform(321);
        //Console.WriteLine("reverse = " + result);
        //result = new ReverseInteger().Perform(1534236469);
        //Console.WriteLine("reverse = " + result);

        ////leetcode #10
        ////Approach — 2D Dynamic Programming
        //var result = new RegularExpressionMatching().Perform("aa", "a*");
        //Console.WriteLine("match = " + result);
        //result = new RegularExpressionMatching().Perform("aab", "c*a*b");
        //Console.WriteLine("match = " + result);
        //result = new RegularExpressionMatching().Perform("ab", ".*");
        //Console.WriteLine("match = " + result);
        //result = new RegularExpressionMatching().Perform("aa", "a");
        //Console.WriteLine("match = " + result);

        ////leetcode #11
        ////Approach — Two Pointers
        //var result = new ContainerWithMostWater().Perform(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 });
        //Console.WriteLine("maxVolume = " + result);
        //result = new ContainerWithMostWater().Perform(new int[] { 1, 1 });
        //Console.WriteLine("maxVolume = " + result);

        ////leetcode #15
        ////Approach — Sorting + Two Pointers
        //var result = new ThreeSum().Perform(new int[] { -1, 0, 1, 2, -1, -4 });
        //Console.Write("[ ");
        //foreach (IList<int> triplet in result)
        //{
        //    Console.Write($" [{string.Join(", ", triplet)}] ");
        //}
        //Console.Write(" ]");

        ////leetcode #17
        ////Approach — Backtracking
        //var result = new LetterCombinationsOfAPhoneNumber().Perform("13324242334442");
        //foreach (var str in result)
        //    Console.WriteLine(str);

        ////leetcode #19
        ////Approach — Two Pointers - fast and slow
        //var result = new RemoveNthNodeFromEndOfList().Perform(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5))))), 2);
        //Print(result);
        //result = new RemoveNthNodeFromEndOfList().Perform(new ListNode(1, new ListNode(2)), 2);
        //Print(result);

        ////leetcode #20
        ////Approach — Stack
        //var result = new ValidParentheses().Perform("[{()}]");
        //Console.WriteLine("valid = " + result);
        //result = new ValidParentheses().Perform("[{(]})");
        //Console.WriteLine("valid = " + result);

        //leetcode #21
        //Approach — Two Pointers
        var result = new MergeTwoSortedLists().Perform(new ListNode(1, new ListNode(2, new ListNode(4))), new ListNode(1, new ListNode(3, new ListNode(4))));
        Print(result);
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
