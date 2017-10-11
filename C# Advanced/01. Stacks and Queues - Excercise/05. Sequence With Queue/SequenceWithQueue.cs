using System;
using System.Collections.Generic;

namespace _05.Sequence_With_Queue
{
    public class SequenceWithQueue
    {
        public static void Main()
        {
            var input = long.Parse(Console.ReadLine());

            var queue = new Queue<long>();
            queue.Enqueue(input);

            for (long i = input; i < 50 + input; i++)
            {
                var firstElement = queue.Peek();
                var secondElement = firstElement + 1;
                var thirdElement = 2 * firstElement + 1;
                var fourthElement = firstElement + 2;

                queue.Enqueue(secondElement);
                queue.Enqueue(thirdElement);
                queue.Enqueue(fourthElement);

                Console.Write(queue.Dequeue() + " ");
            }
        }
    }
}
