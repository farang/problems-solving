public class Solution
{
    public Node copyRandomList(Node head)
    {
        var dummy = new Node(0);

        var link = new Dictionary<Node, Node>();

        var track = head;
        var prev = dummy;
        while (track != null)
        {
            var node = new Node(track.val);
            prev.next = node;
            prev = node;
            link[track] = node;
            track = track.next;
        }

        track = head;
        while (track != null)
        {
            if (track.random != null)
            {
                link[track].random = link[track.random];
            }
            track = track.next;
        }

        return dummy.next;
    }
}