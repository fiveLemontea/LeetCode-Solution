/*
力扣第5题：
给你一个字符串 s，找到 s 中最长的回文子串。
如果字符串的反序与原始字符串相同，则该字符串称为回文字符串。

示例 1：
输入：s = "babad"
输出："bab"
解释："aba" 同样是符合题意的答案。
示例 2：
输入：s = "cbbd"
输出："bb"

提示：
1 <= s.length <= 1000
s 仅由数字和英文字母组成
*/

public class Solution {
    public string LongestPalindrome(string s) {
        int max_left=0;
        int max_right=-1;
        for(int i=0;i<s.Length;i++){
            int left=i;
            int right=i;
            while(left>=0 && s[left]==s[i]) --left;
            while(right<=s.Length-1 && s[right]==s[i]){
                right++;
            }
            while(left>=0 && right<s.Length && s[left]==s[right]){
                left--;
                right++;
            }
            if(max_right-max_left<right-left){
                max_left=left;
                max_right=right;
            }
        }
        return s.Substring(max_left+1,max_right-max_left-1);
    }
}
