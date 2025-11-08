public class Solution
{
    public void ReorderList(ListNode head)
    {
        var slow = head;
        var fast = head.next;

        while (fast is not null && fast.next is not null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        var second = slow.next;
        var prev = slow.next = null;
        while (second is not null)
        {
            var next = second.next;
            second.next = prev;
            prev = second;
            second = next;
        }

        var first = head;
        second = prev;
        while (second is not null)
        {
            var tmpFirst = first.next;
            var tmpSecond = second.next;
            first.next = second;
            second.next = tmpFirst;
            first = tmpFirst;
            second = tmpSecond;
        }
    }
}