using System.Collections.Generic;

namespace CodingChallenge
{
    public class Stack<T>
    {
        private readonly IList<T> _stack = new List<T>();

        public int Count => _stack.Count;

        public void Push(T item)
        {
            _stack.Add(item);
        }

        public T Pop()
        {
            var item = _stack[LastIndex()];

            _stack.RemoveAt(LastIndex());

            return item;
        }

        public bool CanPeek()
        {
            return _stack.Count > 0;
        }

        public T Peek()
        {
            return _stack[LastIndex()];
        }

        private int LastIndex()
        {
            var lastIndex = _stack.Count - 1;

            return lastIndex;

        }
    }
}
