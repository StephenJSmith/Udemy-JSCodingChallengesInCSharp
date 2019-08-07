namespace CodingChallenge
{
    public class Node<T>
    {
        private readonly T _data;
        private readonly Node<T> _next;

        public Node(T data, Node<T> next = null)
        {
            _data = data;
            _next = next;
        }
    }
}
