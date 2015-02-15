namespace KnapsackProblem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
       //01. Write a program based on dynamic programming to solve the "Knapsack Problem": you are given N products, 
       //     each has weight Wi and costs Ci and a knapsack of capacity M and you want to put inside a subset of the 
       //     products with highest cost and weight ≤ M. The numbers N, M, Wi and Ci are integers in the range [1..500]. 
       //
       //     Example: M=10 kg, N=6, products:
       //      beer – weight=3, cost=2
       //      vodka – weight=8, cost=12
       //      cheese – weight=4, cost=5
       //      nuts – weight=1, cost=4
       //      ham – weight=2, cost=3
       //      whiskey – weight=8, cost=13
       //
       //       Optimal solution:
       //           nuts + whiskey
       //           weight = 9
       //           cost = 17


        static void Main()
        {
            Product[] store = new Product[] {
                new Product("beer",2,3),
                new Product("vodka ",12,8),
                new Product("cheese",5,4),
                new Product("nuts",4,1),
                new Product("ham",3,2),
                new Product("whiskey",13,8)
            };
 
            int maxWeight = 10;
            string separator = "-------------------------------------------";
            List<int> allSums = new List<int>();
            List<int> allWeight = new List<int>();
            List<List<Product>> allSets = new List<List<Product>>();
            allSums.Add(0);
            allWeight.Add(0);
            allSets.Add(new List<Product>());
 
            for (int i = 0; i < store.Length; i++)
            {
                List<int> tempSum = new List<int>();
                List<int> tempWeight = new List<int>();
                List<List<Product>> tempSets = new List<List<Product>>();
                for (int j = 0; j < allSums.Count; j++)
                {
                    if (allWeight[j] + store[i].Weight <= maxWeight)
                    {
                        tempSum.Add(allSums[j] + store[i].Price);
                        tempWeight.Add(allWeight[j] + store[i].Weight);
                        List<Product> newSet = new List<Product>();
                        if (allSets[j].Count > 0)
                        {
                            foreach (var item in allSets[j])
                            {
                                newSet.Add(item);
                            }
                        }
                        newSet.Add(store[i]);
                        tempSets.Add(newSet);
                    }
                 }
 
                for (int k = 0; k < tempSum.Count; k++)
                {
                    allSums.Add(tempSum[k]);
                    allWeight.Add(tempWeight[k]);
                    allSets.Add(tempSets[k]);
                }
 
            }
 
            int maxSum = int.MinValue;
            int index = 0;
 
            for (int i = 0; i < allSums.Count; i++)
            {
                if (allSums[i] > maxSum)
                {
                    maxSum = allSums[i];
                    index = i;
                }
            }
            foreach (var item in allSets[index])
            {
                Console.WriteLine("Product name: {0}\nPrice: {1}\nWeight: {2}\n{3}",item.Name, item.Price, item.Weight, separator);
            }
 
            Console.WriteLine("Best weight {0} of total {1}, best price {2}", allWeight[index], maxWeight, allSums[index]);
        }
    }
}
