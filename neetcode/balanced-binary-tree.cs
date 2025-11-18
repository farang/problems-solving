public class Solution
{
    public bool IsBalanced(TreeNode root)
    {
        if (root is null)
        {
            return true;
        }

        var queue = new Queue<TreeNode>(new[] { root });
        var balance = 0;
        var tmpBalance = 0;

        while (queue.Count > 0)
        {
            var count = queue.Count;
            if (tmpBalance > 0)
            {
                balance++;
            }
            else if (tmpBalance < 0)
            {
                balance--;
            }
            tmpBalance = 0;
            while (count-- > 0)
            {
                var node = queue.Dequeue();

                if (node.left is not null)
                {
                    queue.Enqueue(node.left);
                    tmpBalance++;
                }

                if (node.right is not null)
                {
                    queue.Enqueue(node.right);
                    tmpBalance--;
                }
            }
        }

        return Math.Abs(balance) <= 1;
    }
}