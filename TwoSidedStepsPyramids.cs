using System;
using System.Text;

namespace CodingChallenge
{
    public class TwoSidedStepsPyramids
    {
        public void ExecuteIteratively(int totalRows)
        {
            var totalColumns = (2 * (totalRows - 1)) + 1;

            for (var row = 1; row <= totalRows; row++)
            {
                var stair = new StringBuilder();
                GetColumnRange(totalColumns, row, out int beginCol, out int endCol);

                for (var col = 1; col <= totalColumns; col++)
                {
                    stair.Append(IsInPyramid(col, beginCol, endCol)
                        ? "#"
                        : " ");
                }  

                Output(stair.ToString());
            }
        }

        public void ExecuteRecursiveRows(int totalRows, int row = 1)
        {
            if (row > totalRows)
            {
                return;
            }

            var stair = new StringBuilder();
            var totalColumns = (2 * (totalRows - 1)) + 1;
            GetColumnRange(totalColumns, row, out int beginCol, out int endCol);

            for (int col = 1; col <= totalColumns; col++)
            {
                stair.Append(IsInPyramid(col, beginCol, endCol)
                    ? "#"
                    : " ");
            }

            Output(stair.ToString());

            ExecuteRecursiveRows(totalRows, row + 1);
        }

        public void ExecuteRecursiveRowsAndCols(int totalRows, int row = 1, StringBuilder stair = null)
        {
            if (row > totalRows)
            {
                return;
            }

            if (stair == null)
            {
                stair = new StringBuilder();
            }

            var totalColumns = (2 * (totalRows - 1)) + 1;
            if (stair.Length == totalColumns)
            {
                Output(stair.ToString());
                ExecuteRecursiveRowsAndCols(totalRows, row + 1);
            }
            else
            {
                GetColumnRange(totalColumns, row, out int beginCol, out int endCol);
                var col = stair.Length + 1;
                
                stair.Append(IsInPyramid(col, beginCol, endCol)
                    ? "#"
                    : " ");

                ExecuteRecursiveRowsAndCols(totalRows, row, stair);
            }
        }

        private void GetColumnRange(int totalCols, int row, out int colStart, out int colEnd)
        {
            var midCol = (totalCols + 1) / 2;
            var wingLength = row - 1;
            colStart = midCol - wingLength;
            colEnd = midCol + wingLength;
        }
        
        private bool IsInPyramid(int col, int colStart, int colEnd)
        {
            return col >= colStart && col <= colEnd;
        }

        private void Output(string output)
        {
            Console.WriteLine($"'{output}'");
        }
    }
}
