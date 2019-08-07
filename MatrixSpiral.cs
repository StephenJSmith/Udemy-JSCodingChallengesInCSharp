namespace CodingChallenge
{
    public class MatrixSpiral
    {
        public int[,] Execute(int sideLength)
        {
            var total = sideLength * sideLength;
            var result = new int[sideLength, sideLength];

            var rowBegin = 1;
            var colBegin = 1;
            var rowEnd = sideLength;
            var colEnd = sideLength;
            var n = 1;

            while (n <= total && rowBegin <= rowEnd && colBegin <= colEnd)
            {
                for (var col = colBegin; col <= colEnd; col++)
                {
                    result[rowBegin - 1, col - 1] = n;
                    n++;
                }
                rowBegin++;

                for (var row = rowBegin; row <= rowEnd; row++)
                {
                    result[row - 1, colEnd - 1] = n;
                    n++;
                }
                colEnd--;

                for (int col = colEnd; col >= colBegin; col--)
                {
                    result[rowEnd - 1, col - 1] = n;
                    n++;
                }
                rowEnd--;

                for (var row = rowEnd; row >= rowBegin; row--)
                {
                    result[row - 1, colBegin - 1] = n;
                    n++;
                }
                colBegin++;
            }

            return result;
        }
    }
}
