using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExtensions
{
    public static class Extension
    {
        public static string Repeat(this string str, int count)
        {
            var builder = new StringBuilder(str.Length * count);
            for (int i = 0; i < count; i++)
            {
                builder.Append(str);
            }
            return builder.ToString();
        }

        public static void Print<K, V>(this IDictionary<K, V> dict)
        {
            foreach (var pair in dict)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }

        public static string ReadFile(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("File not found in " + path);
            }

            string content = string.Empty;
            using (var reader = new StreamReader(path))
            {
                content = reader.ReadToEnd();
            }

            return content;
        }

        public static void CreateFile(string path, string text)
        {
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                using (var streamWriter = new StreamWriter(fileStream, Encoding.UTF8))
                {
                    streamWriter.WriteLine(text);
                }
            }
        }

        public static void Print(this IEnumerable collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }

        public static void Print<T>(this IEnumerable<T> collection)
        {
            (collection as IEnumerable).Print();
        }

        public static void Print(this string str)
        {
            Console.WriteLine(str);
        }

        public static void ForEach<T>(this IEnumerable<T> collection, Action<T> action)
        {
            foreach (var item in collection)
            {
                action(item);
            }
        }
    }
}
