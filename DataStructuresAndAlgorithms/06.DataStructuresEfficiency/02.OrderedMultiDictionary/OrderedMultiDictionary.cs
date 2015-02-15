namespace OrderedMultiDictionary
{
    using System;
    using Wintellect.PowerCollections;

    //02.A large trade company has millions of articles, each described by barcode, vendor, 
    //  title and price. Implement a data structure to store them that allows fast retrieval 
    //  of all articles in given price range [x…y]. 
    //  Hint: use OrderedMultiDictionary<K,T> from Wintellect's Power Collections for .NET. 

    public class ElementsInRange
    {
        private const int MaxValue = 1000000;

        // Generating millions of articles may be slow
        private const int NumberOfArticles = 100000;

        public static void Main()
        {
            Console.WriteLine("Generating collection of articles...");

            OrderedMultiDictionary<double, Article> articles = new OrderedMultiDictionary<double, Article>(true);
            Random randomNumberGenerator = new Random();
            double randomNumber;

            for (int i = 0; i < NumberOfArticles; i++)
            {
                randomNumber = randomNumberGenerator.NextDouble() * MaxValue;
                Article article = new Article("barcode" + i, "vendor" + i, "article" + i, randomNumber);
                articles.Add(article.Price, article);
            }

            Console.WriteLine("Insert price range:");
            Console.Write("From = ");
            double startPrice = double.Parse(Console.ReadLine());
            Console.Write("To = ");
            double endPrice = double.Parse(Console.ReadLine());
            Console.WriteLine();

            var articlesInRange = articles.Range(startPrice, true, endPrice, true);
            if (articlesInRange.Count == 0)
            {
                Console.WriteLine("No matches found in price range {0} to {1}.", startPrice, endPrice);
            }

            foreach (var pair in articlesInRange)
            {
                Console.WriteLine("----------------------------------------------------");
                foreach (var article in pair.Value)
                {
                    Console.WriteLine("Price: {0}\n{1}", Math.Round(article.Price, 2), article);
                }
            }
        }
    }
}
