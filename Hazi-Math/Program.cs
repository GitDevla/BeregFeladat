using System;
using System.Linq;

namespace Hazi_Math {
    class Program {
        static readonly (
            string op,
            Func<int[,], int[,], int[,]> fun,
            Func<int[,], int[,], bool> filter)[] operations = {
            ("Összeadás", Matrix.Sum, Matrix.IsSameSize),
            ("Kivonás", Matrix.Sub, Matrix.IsSameSize),
            ("Skaláris Szorzás", Matrix.Scalar, Matrix.IsSameSize),
            ("Mátrix Szorzat",Matrix.DotProduct,(a,b)=>a.GetLength(1) == b.GetLength(0))
        };


        static void Main(string[] args) {
            Console.WriteLine("Első mátrix: ");
            var a = ReadMatrix();
            Console.WriteLine("\nMásodik mátrix: ");
            var b = ReadMatrix();

            var filteredOptions = operations.Where(i => i.filter(a, b)).ToArray();
            if (filteredOptions.Length == 0) {
                Console.WriteLine("Ezeken a mátrixokon nem lehet operációkat elvégezni");
                return;
            }
            Console.WriteLine("\nKérem válasszon egy Mátrix operációt: ");
            for (int i = 0; i < filteredOptions.Length; i++) {
                var (op, _, _) = filteredOptions[i];
                Console.WriteLine($"\t {i + 1}. {op}");
            }
            Console.Write("Válasz: ");
            var input = int.Parse(Console.ReadLine());

            var res = filteredOptions[input - 1].fun(a, b);
            Console.WriteLine("\nKapott mátrix az operáció elvégzése után:");
            DrawMatrix(res);
        }


        static int[,] ReadMatrix() {
            Console.Write("Kérem a mátrix sorainak számát: ");
            int height = int.Parse(Console.ReadLine());
            Console.Write("Kérem a mátrix oszlopainak számát: ");
            int width = int.Parse(Console.ReadLine());

            int[,] matrix = new int[height, width];
            for (int y = 0; y < height; y++) {
                for (int x = 0; x < width; x++) {
                    Console.Write($"Kérem a mátrix [i:{y + 1},j:{x + 1}] elemét: ");
                    matrix[y, x] = int.Parse(Console.ReadLine());
                }
            }
            return matrix;
        }

        static void DrawMatrix(int[,] matrix) {
            int height = matrix.GetLength(0), width = matrix.GetLength(1);
            for (int y = 0; y < height; y++) {
                for (int x = 0; x < width; x++)
                    Console.Write("{0}\t", matrix[y, x]);
                Console.WriteLine();
            }
        }
    }
}
