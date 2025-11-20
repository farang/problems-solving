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

// DFS approach
public class Solution
{
    public bool IsBalanced(TreeNode root)
    {
        return Dfs(root)[0] == 1;
    }

    private static int[] Dfs(TreeNode node)
    {
        if (node is null)
        {
            return new int[] { 1, 0 };
        }

        var left = Dfs(node.left);
        var right = Dfs(node.right);

        var isBalanced = ((left[0] == 1 && right[0] == 1) && Math.Abs(left[1] - right[1]) <= 1) ? 1 : 0;
        var height = 1 + Math.Max(left[1], right[1]);

        return new int[] { isBalanced, height };
    }
}