//https://github.com/idivyanshusoni

using DotNetDSAPractice;

public class ReverseNodesInKGroup
{
    //head  = (1 --> 2 --> 3 --> 4 --> 5 --> 6 --> 7 --> 8)
    //
    //dummy = (0 --> 1 --> 2 --> 3 --> 4 --> 5 --> 6 --> 7 --> 8)
    //
    public ListNode Perform(ListNode head, int k)
    {
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        ListNode groupPrev = dummy;
        while (true)
        {
            ListNode kth = GetKthNode(groupPrev, k);
            if (kth == null)
            {
                break;
            }

            ListNode groupNext = kth.next;
            ListNode prev = groupNext;
            ListNode current = groupPrev.next;

            while (current != groupNext)
            {
                ListNode temp = current.next;
                current.next = prev;
                prev = current;
                current = temp;
            }

            ListNode oldGroupStart = groupPrev.next;
            groupPrev.next = kth;
            groupPrev = oldGroupStart;
        }
        return dummy.next;
    }

    private ListNode GetKthNode(ListNode groupPrev, int k)
    {
        ListNode current = groupPrev;
        for (int i = 0; i < k; i++)
        {
            current = current.next;
            if (current == null)
                return null;
        }
        return current;
    }
}