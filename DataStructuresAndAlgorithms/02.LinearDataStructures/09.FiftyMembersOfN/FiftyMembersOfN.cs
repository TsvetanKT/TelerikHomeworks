namespace FiftyMembersOfN
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class FiftyMembersOfN
    {
        /*09. We are given the following sequence:
            S1 = N;
         
            S2 = S1 + 1;
            S3 = 2*S1 + 1;
            S4 = S1 + 2;
         
            S5 = S2 + 1;
            S6 = 2*S2 + 1;
            S7 = S2 + 2;
            ...
        Using the Queue<T> class write a program to print its first 50 members for given N.
        Example: N=2 -> 2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, ...*/

        static void Main()
        {
            Console.Write("Input N: ");
            int n = int.Parse(Console.ReadLine());

            var answer = SequenceListGenerator(n, 50);

            Console.WriteLine("The answer is:");

            while (answer.Count > 0)
            {
                int number = answer.Dequeue();
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        static Queue<int> SequenceListGenerator(int n, int limit = 50)
        {
            Queue<int> sequence = new Queue<int>();
            Queue<int> first50Numbers = new Queue<int>();
            sequence.Enqueue(n);
            first50Numbers.Enqueue(n);
            int count = 1;
            while (first50Numbers.Count < limit)
            {
                int S1 = sequence.Dequeue();
                int S2 = S1 + 1;
                int S3 = 2 * S1 + 1;
                int S4 = S1 + 2;
                sequence.Enqueue(S2);
                sequence.Enqueue(S3);
                sequence.Enqueue(S4);
                first50Numbers.Enqueue(S2);
                first50Numbers.Enqueue(S3);
                first50Numbers.Enqueue(S4);
                count++;
            }
            return first50Numbers;
        }
    }
}
