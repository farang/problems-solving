public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode dummy = new ListNode(0);
        ListNode newHead = dummy;

        while (list1 != null && list2 != null)
        {
            if (list1.val > list2.val)
            {
                newHead.next = list2;
                list2 = list2.next;
            }
            else
            {
                newHead.next = list1;
                list1 = list1.next;
            }

            newHead = newHead.next;
        }

        if (list1 is not null)
        {
            newHead.next = list1;
        }
        else
        {
            newHead.next = list2;
        }

        return dummy.next;
    }
}