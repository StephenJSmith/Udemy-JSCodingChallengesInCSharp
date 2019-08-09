namespace CodingChallenge
{
    public class CircularList<T>
    {
        public bool Execute(LinkedList<T> list)
        {
            var node0 = list.GetFirst();
            if (node0 == null)
            {
                return false;
            }

            var node1 = list.GetFirst();

            while (node1.Next?.Next != null)
            {
                if (node1.Next.Next == node0)
                {
                    return true;
                }

                node0 = node0.Next;
                node1 = node1.Next.Next;
            }

            return false;
        }
    }
}
