//https://github.com/idivyanshusoni
using DotNetDSAPractice;

public class MergeTwoSortedLists
{
    public ListNode Perform(ListNode listNode1, ListNode listNode2)
    {
        ListNode dummy = new ListNode();
        ListNode current = dummy;
        while (listNode1 != null && listNode2 != null)
        {
            if (listNode1.val <= listNode2.val)
            {
                current.next = listNode1;
                listNode1 = listNode1.next;
            }
            else
            {
                current.next = listNode2;
                listNode2 = listNode2.next;
            }
            current = current.next;
        }
        if (listNode1 != null)
            current.next = listNode1;
        else
            current.next = listNode2;
        return dummy.next;
    }
}