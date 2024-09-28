namespace Questions.Solutions;

public class BinaryTreeMaximumPathSum
{
    private int? maxPathSum;

    public int MaxPathSum(TreeNode root)
    {
        Search(root);
        return maxPathSum ?? int.MinValue;
    }

    private int Search(TreeNode node)
    {
        if (node is null)
            return 0;

        var leftSum = Search(node.left);
        var rightSum = Search(node.right);

        maxPathSum = Math.Max(
            maxPathSum ?? node.val,
            node.val + leftSum + rightSum);

        return Math.Max(
            node.val + Math.Max(leftSum, rightSum),
            0);
    }
}

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
