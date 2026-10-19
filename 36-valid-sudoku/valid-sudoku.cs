public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var rows=new Dictionary<int,HashSet<char>>();
        var cols=new Dictionary<int,HashSet<char>>();
        var squares=new Dictionary<(int,int),HashSet<char>>();

        for(int i=0;i<=8;i++){
            for(int j=0;j<=8;j++){
                if (!rows.ContainsKey(i)) rows[i] = new HashSet<char>();
                if (!cols.ContainsKey(j)) cols[j] = new HashSet<char>();
                if (!squares.ContainsKey((i/3, j/3))) squares[(i/3, j/3)] = new HashSet<char>();
                if(board[i][j]!='.'){
                    if(rows[i].Contains(board[i][j]) || cols[j].Contains(board[i][j]) || squares[(i/3,j/3)].Contains(board[i][j])){
                        return false;
                    }else{
                        rows[i].Add(board[i][j]);
                        cols[j].Add(board[i][j]);
                        squares[(i/3,j/3)].Add(board[i][j]);
                    }
                }
            }
        }
        return true;
    }
}