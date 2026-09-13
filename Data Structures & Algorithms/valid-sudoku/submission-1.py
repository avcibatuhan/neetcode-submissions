class Solution:
    def isValidSudoku(self, board: List[List[str]]) -> bool:
        # rows and columns
        for i in range(9):
            rowSet, colSet = set(), set()
            for j in range(9):
                if board[i][j] != ".":
                    if board[i][j] in rowSet:
                        return False
                    rowSet.add(board[i][j])
                if board[j][i] != ".":
                    if board[j][i] in colSet:
                        return False
                    colSet.add(board[j][i])

        # boxes
        for boxRow in range(0, 9, 3):
            for boxCol in range(0, 9, 3):
                boxSet = set()
                for r in range(boxRow, boxRow + 3):
                    for c in range(boxCol, boxCol + 3):
                        if board[r][c] == ".":
                            continue
                        if board[r][c] in boxSet:
                            return False
                        boxSet.add(board[r][c])

        return True
