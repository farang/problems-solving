// iterative BFS solution (with error)
public class Solution
{
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        var queueP = new Queue<TreeNode>(new[] { p });
        var queueQ = new Queue<TreeNode>(new[] { q });

        while (Math.Max(queueP.Count, queueQ.Count) > 0)
        {
            var size = queueP.Count;

            while (size > 0)
            {
                var nodeP = queueP.Dequeue();
                var nodeQ = queueQ.Dequeue();

                if (nodeP is null && nodeQ is null)
                {
                    continue;
                }

                if (nodeP is null || nodeQ is null || nodeP.val != nodeQ.val)
                {
                    return false;
                }

                queueP.Enqueue(nodeP.left);
                queueP.Enqueue(nodeP.right);

                queueQ.Enqueue(nodeQ.left);
                queueQ.Enqueue(nodeQ.right);

                size--;
            }
        }

        return true;
    }
}
