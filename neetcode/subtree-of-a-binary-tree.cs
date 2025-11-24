public class Solution
{
    public bool IsSubtree(TreeNode root, TreeNode subRoot)
    {
        if (subRoot is null)
        {
            return true;
        }

        if (root is null)
        {
            return false;
        }

        return IsSameTree(root, subRoot) ||
        IsSubtree(root.left, subRoot) ||
        IsSubtree(root.right, subRoot);
    }

    private static bool IsSameTree(TreeNode root, TreeNode subTree)
    {
        if (root is null && subTree is null)
        {
            return true;
        }

        if (root?.val == subTree?.val)
        {
            return IsSameTree(root.left, subTree.left) && IsSameTree(root.right, subTree.right);
        }

        return false;
    }
}