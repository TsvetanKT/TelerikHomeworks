namespace CountingWordsFromFile
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class CountingWordsFromFile
    {
        /*
          03.Write a program that counts how many times each word from given text file words.txt appears in it. 
            The character casing differences should be ignored. The result words should be ordered by their 
            number of occurrences in the text. Example:
         
         This is the TEXT. Text, text, text – THIS TEXT! Is this the text?

        is -> 2
        the -> 2
        this -> 3
        text -> 6
         
        */
        static void Main()
        {
            StreamReader myFile = new System.IO.StreamReader("..\\..\\Task03.txt");
            string myString = myFile.ReadToEnd();
            myFile.Close();

            Console.WriteLine("String from the file:\n");
            Console.WriteLine(myString);

            var wordsCount = new Dictionary<string, int>();
            var answer = CountWords(myString, wordsCount);

            Console.WriteLine("\nAnswer:\n");
            foreach (KeyValuePair<string, int> item in answer.OrderBy(key => key.Value))
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }

        private static Dictionary<string, int> CountWords(string text, Dictionary<string, int> wordsCount)
        {
            string[] words = text.Split(new char[] { ' ', ',', '.', '!', '?' },
                StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
            {
                int count = 1;
                if (wordsCount.ContainsKey(word.ToLower()))
                {
                    count = wordsCount[word.ToLower()] + 1;
                }
                wordsCount[word.ToLower()] = count;
            }

            return wordsCount;
        }
    }
}
