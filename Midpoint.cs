namespace CodingChallenge
{
    public class Midpoint<T>
    {
        public Node<T> Execute(LinkedList<T> list)
        {
            var node0 = list.GetFirst();
            if (node0 == null)
            {
                return null;
            }

            var node1 = list.GetFirst();

            while (node1.Next?.Next != null)
            {
                node0 = node0.Next;
                node1 = node1.Next.Next;
            }

            return node0;
        }
    }
}
