//https://github.com/idivyanshusoni

using DotNetDSAPractice;

public class MergeKSortedLists
{
    public ListNode Perform(ListNode[] lists)
    {
        if (lists == null || lists.Length == 0)
            return null;

        PriorityQueue<ListNode, int> minHeap = new PriorityQueue<ListNode, int>();

        foreach (var list in lists)
            if (list != null)
                minHeap.Enqueue(list, list.val);

        ListNode dummy = new ListNode();
        ListNode current = dummy;

        while (minHeap.Count > 0)
        {
            ListNode smallest = minHeap.Dequeue();
            current.next = smallest;
            current = current.next;

            if (smallest.next != null)
                minHeap.Enqueue(smallest.next, smallest.next.val);
        }
        return dummy.next;
    }
}