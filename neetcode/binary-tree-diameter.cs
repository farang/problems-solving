// Dfs approach
public class Solution
{
    public int DiameterOfBinaryTree(TreeNode root)
    {
        int res = 0;
        Dfs(root, ref res);
        return res;
    }

    private static int Dfs(TreeNode node, ref int res)
    {
        if (node is null)
        {
            return 0;
        }

        var left = Dfs(node.left, ref res);
        var right = Dfs(node.right, ref res);

        res = Math.Max(res, right + left);

        return 1 + Math.Max(left, right);
    }
}
