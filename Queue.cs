using System;
using System.Collections.Generic;

namespace CodingChallenge
{
    public class Queue<T>
    {
        private readonly IList<T> _queue = new List<T>();

        public int Count => _queue.Count;

        public void Add(T item)
        {
            _queue.Add(item);
        }

        public T Remove()
        {
            var item = _queue[0];
            _queue.RemoveAt(0);

            return item;
        }

        public bool CanPeek()
        {
            return _queue.Count > 0;
        }

        public T Peek()
        {
            if (!CanPeek())
            {
                throw new ArgumentException("No values to peek");
            }

            return _queue[0];
        }
    }
}
