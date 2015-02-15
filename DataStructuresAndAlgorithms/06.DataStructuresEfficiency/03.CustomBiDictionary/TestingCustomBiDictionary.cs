namespace CustomBiDictionary
{
    using System;

    public class TestingBiDictionary
    {
        //03. Implement a class BiDictionary<K1,K2,T> that allows adding triples 
        //  {key1, key2, value} and fast search by key1, key2 or by both key1 and key2. 
        //  Note: multiple values can be stored for given key.

        public static void Main()
        {
            BiDictionary<string, int, string> biDictionary = new BiDictionary<string, int, string>(true);
            biDictionary.Add("elem", 1, "elemelem");
            biDictionary.AddByKey1("sec", "secsec");
            biDictionary.AddByKey1("sec", "sec");
            biDictionary.AddByKey2(1, "sec");
            biDictionary.Add("none", 2, "nothing");

            var itemsWithOneSpecificKey = String.Join(", ", biDictionary.FindByKey2(1));
            Console.WriteLine("Items with key 1: " + itemsWithOneSpecificKey);

            var itemsWithTwoKeys = String.Join(", ", biDictionary.FindByKeys("sec", 1));
            Console.WriteLine("Items with keys 'sec' and 1: " + itemsWithTwoKeys);
        }
    }
}