// own solution
public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        int d = 0;
        var dummyNode = new ListNode(0);
        var s = dummyNode;
        while (l1 != null || l2 != null)
        {
            var sum = (l1?.val ?? 0) + (l2?.val ?? 0) + d;
            d = sum / 10;
            var left = sum - (d * 10);
            s.next = new ListNode(left);
            s = s.next;
            l1 = l1?.next;
            l2 = l2?.next;
        }

        if (d > 0)
        {
            s.next = new ListNode(d);
        }

        return dummyNode.next;
    }
}