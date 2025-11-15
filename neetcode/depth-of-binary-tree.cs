// iterative BFS solution
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

// recursive solution
public class Solution
{
    public int MaxDepth(TreeNode root)
    {
        if (root is null)
        {
            return 0;
        }

        return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
    }
}

// iterative DFS solution
public class Solution
{
    public int MaxDepth(TreeNode root)
    {
        if (root is null)
        {
            return 0;
        }

        var stack = new Stack<Tuple<TreeNode, int>>(new[] { new Tuple<TreeNode, int>(root, 1) });
        var result = 0;

        while (stack.Count > 0)
        {
            var item = stack.Pop();
            var node = item.Item1;
            var depth = item.Item2;

            result = Math.Max(result, depth);

            if (node.right is not null)
            {
                stack.Push(new Tuple<TreeNode, int>(node.right, depth + 1));
            }
            if (node.left is not null)
            {
                stack.Push(new Tuple<TreeNode, int>(node.left, depth + 1));
            }
        }

        return result;
    }
}
