namespace CodingChallenge
{
    public class FromLast<T>
    {
        public Node<T> Execute(LinkedList<T> list, int n)
        {
            var node0 = list.GetFirst();
            if (node0 == null)
            {
                return null;
            }

            var node1 = InitialiseNode1(list, n);
            if (node1 == null)
            {
                return null;
            }

            while (node1.Next != null)
            {
                node0 = node0.Next;
                node1 = node1.Next;
            }

            return node0;
        }

        private Node<T> InitialiseNode1(LinkedList<T> list, int n)
        {
            var node1 = list.GetFirst();

            var counter = n;
            while (counter >= 1)
            {
                if (node1.Next == null)
                {
                    return null;
                }

                node1 = node1.Next;
                counter--;
            }

            return node1;
        }
    }
}
