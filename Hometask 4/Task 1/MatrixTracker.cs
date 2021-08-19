using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class MatrixTracker<T>
    {
        private DiagonalMatrix<T> _matrix;
        private ElementChangedEventArgs<T> elements;
        public MatrixTracker(DiagonalMatrix<T> matrix)
        {
            _matrix = matrix;
            _matrix.ElementChanged += (_, e) => elements = e;
        }

        public void Undo()
        {
            _matrix[elements.Index, elements.Index] = elements.Old;
        }
    }
}
