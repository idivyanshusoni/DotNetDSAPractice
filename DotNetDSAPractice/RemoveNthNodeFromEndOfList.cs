//https://github.com/idivyanshusoni
using DotNetDSAPractice;

public class RemoveNthNodeFromEndOfList
{
    public ListNode Perform(ListNode listNode, int n)
    {
        ListNode dummy = new ListNode(0, listNode);

        ListNode fast = dummy;
        ListNode slow = dummy;

        for (int i = 0; i < n; i++)
            fast = fast.next;

        while (fast.next != null)
        {
            slow = slow.next;
            fast = fast.next;
        }

        slow.next = slow.next.next;

        return dummy.next;
    }
}