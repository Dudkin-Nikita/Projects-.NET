using System;


namespace Task_1
{
    public static class DiagonalMatrixHelper
    {
        public delegate T Sum<T>(T a, T b);
        public static T[] Add<T>(this DiagonalMatrix<T> array1, DiagonalMatrix<T> array2,
       Sum<T> func)
        {
            array1 ??= new DiagonalMatrix<T>(0);
            array2 ??= new DiagonalMatrix<T>(0);

            if (array1.Size < array2.Size)
            {
                var tmp = array1;
                array1 = array2;
                array2 = tmp;
            } 

            T[] result = new T[array1.Size];
            for (var i = 0; i < array2.Size; i++)
            {
                result[i] = func(array1[i, i], array2[i, i]);
            }

            for (var i = array2.Size; i < array1.Size; i++)
            {
                result[i] = array1[i, i];
            }

            return result; 
        }

    }
}
