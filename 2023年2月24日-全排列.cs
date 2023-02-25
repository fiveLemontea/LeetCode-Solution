/*
力扣46题：
给定一个不含重复数字的数组 nums ，返回其 所有可能的全排列 。你可以 按任意顺序 返回答案。

示例 1：
输入：nums = [1,2,3]
输出：[[1,2,3],[1,3,2],[2,1,3],[2,3,1],[3,1,2],[3,2,1]]
示例 2：
输入：nums = [0,1]
输出：[[0,1],[1,0]]
示例 3：
输入：nums = [1]
输出：[[1]]
 
提示：
1 <= nums.length <= 6
-10 <= nums[i] <= 10
nums 中的所有整数 互不相同
*/

public class Solution {   
     IList<IList<int>> result = new List<IList<int>>(); 
    public IList<IList<int>> Permute(int[] nums)
    {
        LinkedList<int> track = new LinkedList<int>();
        Backtrack(nums, track);
        return result;
    }
    void Backtrack(int[] nums, LinkedList<int> track)
    {
        if (track.Count == nums.Length)
        {
            result.Add(new List<int>(track));
            return;
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (track.Contains(nums[i]))
                continue;
            track.AddLast(nums[i]);
            Backtrack(nums, track);
            track.RemoveLast();
        }
    }
}
