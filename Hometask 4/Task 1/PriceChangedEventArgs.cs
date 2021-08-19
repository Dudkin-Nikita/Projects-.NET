using System;


namespace Task_1
{
    public class ElementChangedEventArgs<T>
    {
        public T Old { get; }
        public T New { get; }
        public int Index { get; }

        public ElementChangedEventArgs(int i, T old, T @new) => (Index, Old, New) = (i, old, @new);
    }
}
