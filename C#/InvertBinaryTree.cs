/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {

    public TreeNode InvertTree(TreeNode root) {
        if(root == null) return null;
        var left = InvertTree(root.left);
        var right = InvertTree(root.right);
        root.left = right;
        root.right = left;
        return root;
        
    }
}