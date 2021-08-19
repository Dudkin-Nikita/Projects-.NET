using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DiagonalMatrix<int> matrix = new DiagonalMatrix<int>(-1);
                DiagonalMatrix<int> matrix2 = new DiagonalMatrix<int>(2);

                matrix[1, 1] = 4;
                matrix[2, 2] = 5;
                matrix2[3, 1] = 3;
                matrix2[2, 2] = 2;

                MatrixTracker<int> newMatrix = new MatrixTracker<int>(matrix);

                matrix[1, 1] = 10;
                matrix.ElementChanged += (_, e) => Console.WriteLine($"Old = {e.Old}, New = {e.New}");

                matrix[1, 1] = 10;
                matrix[1, 1] = 20;
                matrix[1, 1] = 40;
                newMatrix.Undo();
                Console.WriteLine(matrix[1, 1].ToString());

                Console.WriteLine("Second element of sum:");
                int[] result = matrix.Add(matrix2, (a, b) => a + b);
                Console.WriteLine(result[1].ToString());
            }
            catch(ArgumentNullException)
            {
                Console.WriteLine("Bad length");
                throw;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Bad index");
                throw;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

        }
    }
}
