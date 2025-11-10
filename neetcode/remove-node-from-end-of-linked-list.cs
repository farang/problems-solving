// own solution
public class Solution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        var map = new Dictionary<int, ListNode>();
        var curr = head;
        var i = 1;
        while (curr is not null)
        {
            map[i] = curr;
            curr = curr.next;
            i++;
        }

        var toRem = i - n;
        var node = map[toRem];

        if (node is null)
        {
            return head;
        }

        if (node == head)
        {
            return node.next;
        }

        map[toRem - 1].next = node.next;

        return head;
    }
}

// neetcode solution
public class Solution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        var dummy = new ListNode(0, head);
        var left = dummy;
        var right = head;

        while (n > 0)
        {
            right = right.next;
            n--;
        }

        while (right is not null)
        {
            left = left.next;
            right = right.next;
        }

        left.next = left.next.next;

        return dummy.next;
    }
}