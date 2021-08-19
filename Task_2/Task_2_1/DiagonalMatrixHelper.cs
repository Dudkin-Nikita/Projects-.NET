public static class DiagonalMatrixHelper
{
    public static DiagonalMatrix Add(this DiagonalMatrix a, DiagonalMatrix b)
    {
        // аргументы могут быть равны null
        a ??= new DiagonalMatrix();
        b ??= new DiagonalMatrix();

        if (a.Size < b.Size)
        {
            var tmp = a;
            a = b;
            b = tmp;
            // или так: (a, b) = (b, a);
        }

        // матрица a имеет размер, больший или равный размеру матрицы b
        var data = new int[a.Size];
        for (var i = 0; i < b.Size; i++)
        {
            data[i] = a[i, i] + b[i, i];
        }

        for (var i = b.Size; i < a.Size; i++)
        {
            data[i] = a[i, i];
        }

        return new DiagonalMatrix(data);
    }
}