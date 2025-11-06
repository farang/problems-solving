public class Solution
{
    public bool HasCycle(ListNode head)
    {
        ListNode future = head.next?.next;

        while (future?.next != null)
        {
            if (head == future)
            {
                return true;
            }

            head = head.next;
            future = future.next.next;
        }

        return false;
    }
}