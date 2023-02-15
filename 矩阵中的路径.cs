/*
给定一个 m x n 二维字符网格 board 和一个字符串单词 word 。如果 word 存在于网格中，返回 true ；否则，返回 false 。

单词必须按照字母顺序，通过相邻的单元格内的字母构成，其中“相邻”单元格是那些水平相邻或垂直相邻的单元格。同一个单元格内的字母不允许被重复使用。
例如，在下面的 3×4 的矩阵中包含单词 "ABCCED"（单词中的字母已标出）。
示例 1：

输入：board = [["A","B","C","E"],["S","F","C","S"],["A","D","E","E"]], word = "ABCCED"
输出：true
示例 2：

输入：board = [["a","b"],["c","d"]], word = "abcd"
输出：false

提示：
m == board.length
n = board[i].length
1 <= m, n <= 6
1 <= word.length <= 15
board 和 word 仅由大小写英文字母组成

*/



public class Solution {
    public bool Exist(char[][] board, string word) {
        char[] words=word.ToCharArray();
        for(int i=0;i<board.Length;i++){
            for(int j=0;j<board[0].Length;j++){
                if(Dfs(board,words,i,j,0)) return true;
            }
        }
        return false;
    }

    public bool Dfs(char[][] board,char[] word,int i,int j,int k){
        if(i>=board.Length||i<0||j<0 || j>=board[0].Length||board[i][j]!=word[k]) return false;
        if(k==word.Length-1) return true;
        board[i][j]='\0';
        bool res=Dfs(board,word,i+1,j,k+1)||Dfs(board,word,i,j+1,k+1)||Dfs(board,word,i-1,j,k+1)||Dfs(board,word,i,j-1,k+1);
        board[i][j]=word[k];
        return res;
    }
}
