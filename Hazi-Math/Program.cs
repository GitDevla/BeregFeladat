using System;

namespace Hazi_Math {
    class Program {
        static readonly (string op, Func<int[,], int[,], int[,]> fun)[] operations = {
            ("Összeadás", Matrix.Sum),
            ("Kivonás", Matrix.Sub),
            ("Skaláris Szorzás", Matrix.Scalar),
        };

        static void Main(string[] args) {
            Console.WriteLine("Első mátrix: ");
            var a = ReadMatrix();
            Console.WriteLine("\nMásodik mátrix: ");
            var b = ReadMatrix();

            Console.WriteLine("\nKérem válasszon egy Mátrix operációt: ");
            for (int i = 0; i < operations.Length; i++) {
                var (op, _) = operations[i];
                Console.WriteLine($"\t {i+1}. {op}");
            }
            Console.Write("Válasz: ");
            var input = int.Parse(Console.ReadLine());

            if (a.GetLength(0) != b.GetLength(0)
                || a.GetLength(1) != b.GetLength(1)) {
                Console.WriteLine("A mátrixok nem megegyező méretűek");
                return;
            }
            var res = operations[input - 1].fun(a, b);
            Console.WriteLine("\nKapott mátrix az operáció elvégzése után:");
            DrawMatrix(res);
        }

        static int[,] ReadMatrix() {
            Console.Write("Kérem a mátrix oszlopainak számát: ");
            int height = int.Parse(Console.ReadLine());
            Console.Write("Kérem a mátrix sorainak számát: ");
            int width = int.Parse(Console.ReadLine());

            int[,] matrix = new int[height, width];
            for (int y = 0; y < height; y++) {
                for (int x = 0; x < width; x++) {
                    Console.Write($"Kérem a mátrix [i:{y+1},j:{x+1}] elemét: ");
                    matrix[y, x] = int.Parse(Console.ReadLine());
                }
            }
            return matrix;
        }

        static void DrawMatrix(int[,] matrix) {
            int height = matrix.GetLength(0), width = matrix.GetLength(1);
            for (int y = 0; y < height; y++) {
                for (int x = 0; x < width; x++)
                    Console.Write("{0}\t", matrix[x, y]);
                Console.WriteLine();
            }
        }
    }
}
