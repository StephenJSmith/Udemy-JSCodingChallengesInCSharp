using System;

namespace CodingChallenge
{
    public class FizzBuzz
    {
        public void Execute(int input)
        {
            for (int i = 1; i <= input; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    Output("fizzbuzz");
                } else if (i % 3 == 0)
                {
                    Output("fizz");
                } else if (i % 5 == 0)
                {
                    Output("buzz");
                }
                else
                {
                    Output(i.ToString());
                }
            }
        }

        private void Output(string output)
        {
            Console.WriteLine(output);
        }
    }
}
