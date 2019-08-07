using System.Globalization;

namespace CodingChallenge
{
    public class LinkedList<T>
    {
        private Node<T> _data;

        public void InsertFirst(T item)
        {
            _data = new Node<T>(item);
        }

    }
}
