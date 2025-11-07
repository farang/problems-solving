public class Solution
{
    public TreeNode InvertTree(TreeNode root)
    {
        if (root is null)
        {
            return root;
        }

        var stack = new Stack<TreeNode>();
        stack.Push(root);

        while (stack.Count > 0)
        {
            var node = stack.Pop();
            var tmpNodeLeft = node.left;
            node.left = node.right;
            node.right = tmpNodeLeft;
            if (node.left is not null)
            {
                stack.Push(node.left);
            }

            if (node.right is not null)
            {
                stack.Push(node.right);
            }
        }

        return root;
    }
}