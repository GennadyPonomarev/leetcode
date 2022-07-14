namespace LeetCode.AddTwoNumbers;

public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var head = new ListNode();

        var current = head;
        var overflow = 0;

        while (l1 != null || l2 != null || overflow != 0)
        {
            var left = l1?.val ?? 0;
            var right = l2?.val ?? 0;

            var sum = left + right + overflow;

            if (sum > 9)
            {
                overflow = 1;
                sum -= 10;
            }
            else
            {
                overflow = 0;
            }

            current.next = new ListNode(sum);
            current = current.next;

            l1 = l1?.next;
            l2 = l2?.next;
        }

        return head.next;
    }
}