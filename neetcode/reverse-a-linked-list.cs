
public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode prev = null;
        ListNode curr = head;

        while (curr != null) {
            var currentTmp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = currentTmp;
        }

        return prev;
    }
}