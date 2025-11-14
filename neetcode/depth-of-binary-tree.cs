public class Solution
{
    public int MaxDepth(TreeNode root)
    {
        var result = 0;

        if (root is null)
        {
            return result;
        }

        var queue = new Queue<TreeNode>(new[] { root });

        while (queue.Count > 0)
        {
            result++;
            var size = queue.Count;

            while (size > 0)
            {
                var item = queue.Dequeue();
                if (item.left is not null)
                {
                    queue.Enqueue(item.left);
                }
                if (item.right is not null)
                {
                    queue.Enqueue(item.right);
                }
                size--;
            }
        }

        return result;
    }
}