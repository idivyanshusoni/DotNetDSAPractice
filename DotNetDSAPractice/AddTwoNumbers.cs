using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDSAPractice
{
    public class AddTwoNumbers
    {
        public ListNode Perform(ListNode l1, ListNode l2)
        {
            ListNode dummy = new ListNode();
            ListNode current = dummy;
            int carry = 0;

            while (l1 != null || l2 != null || carry != 0)
            {
                int value1 = l1 != null ? l1.val : 0;
                int value2 = l2 != null ? l2.val : 0;

                int sum = value1 + value2 + carry;

                carry = sum / 10;
                int digit = sum % 10;

                current.next = new ListNode(digit);
                current = current.next;

                if (l1 != null) l1 = l1.next;
                if (l2 != null) l2 = l2.next;
            }

            return dummy.next;
        }
    }
}
