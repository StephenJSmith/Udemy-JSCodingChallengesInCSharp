namespace CodingChallenge
{
    public class Weave<T>
    {
        public Queue<T> Execute(Queue<T> queue1, Queue<T> queue2)
        {
            var weaved = new Queue<T>();

            while (queue1.CanPeek() || queue2.CanPeek())
            {
                if (queue1.CanPeek())
                {
                    weaved.Add(queue1.Remove());
                }

                if (queue2.CanPeek())
                {
                    weaved.Add(queue2.Remove());
                }
            }

            return weaved;
        }
    }
}
