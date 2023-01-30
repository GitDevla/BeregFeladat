using System;

namespace Hazi_Math {
    static class Matrix {
        public static int[,] Transform(int[,] a, int[,] b,Func<int,int,int> f) {
            if (a.GetLength(0) != b.GetLength(0)
                || a.GetLength(1) != b.GetLength(1)) throw new FormatException();

            int height = a.GetLength(0), width = a.GetLength(1);
            int[,] sumMatrix = new int[height, width];
            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                    sumMatrix[x, y] = f(a[x, y],b[x, y]);

            return sumMatrix;
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
    }
}
