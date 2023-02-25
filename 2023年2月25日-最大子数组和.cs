/*
力扣53题：
给你一个整数数组 nums ，请你找出一个具有最大和的连续子数组（子数组最少包含一个元素），返回其最大和。
子数组 是数组中的一个连续部分。

示例 1：
输入：nums = [-2,1,-3,4,-1,2,1,-5,4]
输出：6
解释：连续子数组 [4,-1,2,1] 的和最大，为 6 。
示例 2：
输入：nums = [1]
输出：1
示例 3：
输入：nums = [5,4,-1,7,8]
输出：23

提示：
1 <= nums.length <= 105
-104 <= nums[i] <= 104
*/

/*
解题思路：动态规划
*/

public class Solution {
    public int MaxSubArray(int[] nums) {
        //动态规划
        int pre=0,maxAns=nums[0];
        foreach(int x in nums){
            pre=Math.Max(pre+x,x);
            if(pre>maxAns) maxAns=pre;
            //maxAns=Math.Max(maxAns,pre);
        }
        return maxAns;
    }
}
