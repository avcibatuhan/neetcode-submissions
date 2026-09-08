public class Solution {
    public bool IsValidSudoku(char[][] board) {
        
         var boxHash = new HashSet<(int, char)>();
        
        for(int i=0;i<board.Length;i++){
            var rowHash = new HashSet<char>();
            var columnHash = new HashSet<char>();

            var row = board[i];            

            for(int j=0; j<row.Length;j++){
                var currentValue = row[j];
                char c = '.';

                // column check
                var columnValue = board[j][i];
                if (columnValue != c) {
                    if (columnHash.Contains(columnValue)) return false;
                    columnHash.Add(columnValue);
                }

                // row check
                if(currentValue != c){
                    if(rowHash.Contains(currentValue))return false;
                    rowHash.Add(currentValue);

                // box check
                var belongingBox = (i / 3) * 3 + j / 3;

                if(boxHash.Contains((belongingBox,currentValue))){
                    return false;
                }
                boxHash.Add((belongingBox,currentValue));
                }
            }
        }

        return true;
    }
}
