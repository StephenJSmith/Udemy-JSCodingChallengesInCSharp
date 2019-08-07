using System;
using System.Text;

namespace CodingChallenge
{
    public class PrintingSteps
    {
        public void ExecuteLooping(int totalRows)
        {
            for (var row = 1; row <= totalRows; row++)
            {
                var sb = new StringBuilder();
                for (var col = 1; col <= totalRows; col++)
                {
                    sb.Append(col <= row ? "#" : " ");
                }

                Output(sb.ToString());
            }
        }

        public void ExecuteRowsRecursively(int totalRows, int row = 1)
        {
            var stair = new StringBuilder();
            for (var col = 1; col <= totalRows; col++)
            {
                stair.Append(col <= row ? '#' : ' ');
            }

            Output(stair.ToString());

            if (row == totalRows)
            {
                return;
            }

            ExecuteRowsRecursively(totalRows, row + 1);
        }

        public void ExecuteRowsAndColsRecursively(int totalRows, int row = 1, StringBuilder stair = null)
        {
            if (row > totalRows)
            {
                return;
            }

            if (stair == null)
            {
                stair = new StringBuilder();
            }

            if (stair.Length == totalRows)
            {
                Output(stair.ToString());

                ExecuteRowsAndColsRecursively(totalRows, row + 1);
            }
            else
            {
                stair.Append(stair.Length < row
                    ? "#"
                    : " ");

                ExecuteRowsAndColsRecursively(totalRows, row, stair);
            }
        }

        private void Output(string output)
        {
            Console.WriteLine($"'{output}'");
        }
    }
}
