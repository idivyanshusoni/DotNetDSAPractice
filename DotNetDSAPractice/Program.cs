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

        ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
        ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
        var sum = new AddTwoNumbers().Perform(l1, l2);
        Print(sum);
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
