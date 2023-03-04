/*
力扣102题：
给你二叉树的根节点 root ，返回其节点值的 层序遍历 。 （即逐层地，从左到右访问所有节点）。 

示例 1：
输入：root = [3,9,20,null,null,15,7]
输出：[[3],[9,20],[15,7]]
示例 2：
输入：root = [1]
输出：[[1]]
示例 3：
输入：root = []
输出：[]
*/

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<IList<int>> LevelOrder(TreeNode root) {
        IList<IList<int>> res=new List<IList<int>>();
        Queue<TreeNode> queue=new Queue<TreeNode>();
        if(root!=null){
            queue.Enqueue(root);
        }
        while(queue.Count()!=0){
            int n=queue.Count();
            List<int> lev=new List<int>();
            for(int i=0;i<n;i++){
                TreeNode node=queue.Dequeue();
                lev.Add(node.val);
                if(node.left!=null){
                    queue.Enqueue(node.left);
                }
                if(node.right!=null){
                    queue.Enqueue(node.right);
                }
            }
            res.Add(lev);
        }
        return res;
    }
}
