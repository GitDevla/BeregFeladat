using System;

namespace Hazi_Math {
    static class Matrix {
        public static int[,] Transform(int[,] a, int[,] b,Func<int,int,int> f) {
            if (!IsSameSize(a,b)) throw new FormatException();

            int height = a.GetLength(0), width = a.GetLength(1);
            int[,] outMatrix = new int[height, width];
            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                    outMatrix[x, y] = f(a[x, y],b[x, y]);

            return outMatrix;
        }

        public static int[,] Sum(int[,] a, int[,] b) {
            return Transform(a, b, (a, b) => a + b);
        }

        public static int[,] Sub(int[,] a, int[,] b) {
            return Transform(a, b, (a, b) => a - b);
        }

        public static int[,] Scalar(int[,] a, int[,] b) {
            return Transform(a, b, (a, b) => a * b);
        }

        public static int[,] DotProduct(int[,] a, int[,] b) {
            if(a.GetLength(1) != b.GetLength(0)) throw new FormatException();
            int rows = a.GetLength(0);
            int columns = b.GetLength(1);
            int[,] dotMatrix = new int[rows, columns];
            for (int ay = 0; ay < rows; ay++) {
                for (int bx = 0; bx < columns; bx++) {
                    var row = GetRow(a, ay);
                    var column = GetColumn(b, bx);
                    var product = CalculateDotProduct(row, column);
                    dotMatrix[ay, bx] = product;
                }
            }
            return dotMatrix;
        }

        private static int CalculateDotProduct(int[] a, int[] b) {
            var product = 0;
            for (int i = 0; i < a.Length; i++)
                product += a[i] * b[i];
            return product;
        }

        public static int[] GetColumn(int[,] matrix,int num) {
            int length = matrix.GetLength(0);
            int[] column = new int[length];
            for (int y = 0; y < length; y++)
                column[y] = matrix[y, num];
            return column;
        }

        public static int[] GetRow(int[,] matrix, int num) {
            int length = matrix.GetLength(1);
            int[] row = new int[length];
            for (int x = 0; x < length; x++)
                row[x] = matrix[num,x];
            return row;
        }

        public static bool IsSameSize(int[,] a, int[,] b) {
            return a.GetLength(0) == b.GetLength(0)
                && a.GetLength(1) == b.GetLength(1);
        }
    }
}
