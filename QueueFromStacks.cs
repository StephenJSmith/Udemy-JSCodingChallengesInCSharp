namespace CodingChallenge
{
    public class QueueFromStacks<T>
    {
        private readonly Stack<T> _stack1 = new Stack<T>();
        private Stack<T> _stack2 = new Stack<T>();

        public int Count => _stack1.Count;

        public void Add(T item)
        {
            _stack1.Push(item);
        }

        public T Remove()
        {
            PopulateStackTwo();
            var item = _stack2.Pop();
            RepopulateStackOne();

            return item;
        }

        public bool CanPeek()
        {
            return _stack1.CanPeek();
        }

        public T Peek()
        {
            PopulateStackTwo();
            var item = _stack2.Peek();
            RepopulateStackOne();
            
            return item;
        }

        private void PopulateStackTwo()
        {
            _stack2 = new Stack<T>();

            while (_stack1.CanPeek())
            {
                _stack2.Push(_stack1.Pop());
            }
        }

        private void RepopulateStackOne()
        {
            while (_stack2.CanPeek())
            {
                _stack1.Push(_stack2.Pop());
            }
        }
    }
}
