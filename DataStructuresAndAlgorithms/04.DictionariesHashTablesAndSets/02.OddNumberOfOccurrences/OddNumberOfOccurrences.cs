namespace OddNumberOfOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class OddNumberOfOccurrences
    {
        /* 02.Write a program that extracts from a given sequence of strings all elements that present in it odd number of times. Example:
                {C#, SQL, PHP, PHP, SQL, SQL } -> {C#, SQL}
        */ 

        static void Main()
        {
            var testArray = new string[] { "C#", "SQL", "PHP", "PHP", "SQL", "SQL" };
            IDictionary<string, int> wordCount = new Dictionary<string, int>();
            var answer = ExtractOddOccurredStrings(testArray, wordCount);

            Console.WriteLine("Elements that present in it odd number of times:");
            Console.WriteLine(String.Join(", ", answer));
        }

        private static List<string> ExtractOddOccurredStrings(IEnumerable<string> strings, IDictionary<string, int> wordsCount)
        {

            foreach (string word in strings)
            {
                int count = 1;
                if (wordsCount.ContainsKey(word))
                {
                    count = wordsCount[word] + 1;
                }
                wordsCount[word] = count;
            }

            var answer = new List<string>();

            foreach (var item in wordsCount)
            {
                if (item.Value % 2 > 0)
                {
                    answer.Add(item.Key);
                }
            }

            return answer;
        }
    }
}
