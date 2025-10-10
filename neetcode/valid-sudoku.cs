public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        var len = board.Length;

        var matrixMap = new Dictionary<int, bool[]>();

        for (var i = 0; i < len; i++)
        {
            matrixMap[i] = new bool[10];
        }

        for (var i = 0; i < len; i++)
        {
            var rowsMap = new Dictionary<int, bool>();
            var colMap = new Dictionary<int, bool>();

            for (var i1 = 0; i1 < len; i1++)
            {
                char rowNChar = board[i][i1];
                char colNChar = board[i1][i];
                // row
                if (rowNChar != '.')
                {
                    var rn = rowNChar - '0';

                    if (rowsMap.ContainsKey(rn))
                    {
                        return false;
                    }
                    else
                    {
                        rowsMap[rn] = true;
                    }
                    var rowIndex1 = (int)Math.Floor((double)(i / 3));
                    var columnIndex1 = (int)Math.Floor((double)(i1 / 3));
                    var matrixIndex1 = (rowIndex1 * 3) + columnIndex1;
                    if (matrixMap[matrixIndex1][rn])
                    {
                        return false;
                    }
                    matrixMap[matrixIndex1][rn] = true;
                }
                // column
                if (colNChar == '.')
                {
                    continue;
                }
                var cn = colNChar - '0';

                if (colMap.ContainsKey(cn))
                {
                    return false;
                }
                else
                {
                    colMap[cn] = true;
                }
            }
        }

        return true;
    }
}
