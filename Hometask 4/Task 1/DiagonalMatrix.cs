using System;

namespace Task_1
{
    public class DiagonalMatrix<T>
    {
        private readonly T[] _data;

        public int Size => _data.Length;

        public T this[int i, int j]
        {
            get
            {
                if(i == j && IsCorrect(i))
                {
                    return _data[i];
                }
                else
                {
                    if(!IsCorrect(i) || !IsCorrect(j))
                    {
                        throw new IndexOutOfRangeException("Not correct index");
                    }
                    return default(T);
                }
            }
            set
            {
                if (i == j && IsCorrect(i))
                {
                    if (_data[i].Equals(value)) return;
                    T oldData = _data[i];
                    _data[i] = value;
                    OnElementChanged(new ElementChangedEventArgs<T>(i, oldData, _data[i]));
                }
            }
        }

        public event EventHandler<ElementChangedEventArgs<T>> ElementChanged;

        protected virtual void OnElementChanged(ElementChangedEventArgs<T> e)
        {
            ElementChanged?.Invoke(this, e);
        }

        public DiagonalMatrix(int len)
        {
            if (len < 0)
            {
                throw new ArgumentNullException("Error");
            }
            else
            {
                _data = new T[len];
            }
        }
        private bool IsCorrect(int i) => i >= 0 && i < Size;
    }
}
