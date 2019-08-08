namespace CodingChallenge
{
    public class LinkedList<T>
    {
        public Node<T> Head { get; private set; }

        public LinkedList(Node<T> head = null)
        {
            Head = head;
        }

        public void InsertFirst(T item)
        {
            Head = new Node<T>(item, Head);
        }

        public void InsertLast(T item)
        {
            var newNode = new Node<T>(item);
            if (Head == null)
            {
                Head = newNode;

                return;
            }

            var lastNode = GetLast();

            lastNode.Next = newNode;
        }

        public void InsertAt(T item, int n)
        {
            if (n == 0 && Head == null)
            {
                Head = new Node<T>(item);

                return;
            }

            var previous = GetAt(n -1) ?? GetLast();

            var newNode = new Node<T>(item, previous.Next);
            previous.Next = newNode;
        }

        public int Size()
        {
            var counter = 0;
            var node = Head;
            while (node != null)
            {
                counter++;
                node = node.Next;
            }

            return counter;
        }

        public Node<T> GetFirst()
        {
            return Head;
        }

        public Node<T> GetLast()
        {
            if ((Head == null))
            {
                return null;
            }

            var node = Head;
            while (node.Next != null)
            {
                node = node.Next;
            }

            return node;
        }

        public Node<T> GetAt(int n)
        {
            var counter = 0;
            var node = Head;
            while (node != null)
            {
                if (counter == n)
                {
                    return node;
                }

                counter++;
                node = node.Next;
            }

            return null;
        }

        public void Clear()
        {
            Head = null;
        }

        public void RemoveFirst()
        {
            if (Head == null) return;

            Head = Head.Next;
        }

        public void RemoveLast()
        {
            if (Head == null) return;
            if (Head.Next == null)
            {
                Head = null;

                return;
            }

            var previous = Head;
            var node = Head.Next;

            while (node.Next != null)
            {
                previous = previous.Next;
                node = node.Next;
            }

            previous.Next = null;
        }

        public void RemoveAt(int n)
        {
            if (n == 0)
            {
                Head = Head?.Next;
            }

            var previous = GetAt(n - 1);

            if (previous?.Next == null)
            {
                return;
            }

            previous.Next = previous.Next.Next;
        }
    }
}
