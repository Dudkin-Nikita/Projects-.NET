public static class StackExtension
{
    public static IStack<T> Reverse<T>(this IStack<T> stack) where T : struct
    {
        var reversed = new Stack<T>();

        if (stack == null)
        {
            return reversed;
        }

        // это чтобы потом восстановить исходный стек
        var aux = new Stack<T>();
        while (!stack.IsEmpty())
        {
            var item = stack.Pop();
            reversed.Push(item);
            aux.Push(item);
        }

        // восстанавливаем исходный стек
        while (!aux.IsEmpty())
        {
            stack.Push(aux.Pop());
        }

        return reversed;
    }
}