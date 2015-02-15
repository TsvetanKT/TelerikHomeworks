namespace ExtensionETCHomework
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using System.Linq;
    public static class Extensions
    {
        public static int longest = 0;
        // Exercise 01
        public static StringBuilder SubString(this StringBuilder srt, int index, int length)
        {
            StringBuilder answer = new StringBuilder();

            if (index + length >= srt.Length)
            {
                throw new ArgumentOutOfRangeException();
            }

            for (int i = index; i < index + length; i++)
            {
                answer.Append(srt[i]);
            }
            return answer;
        }

        // Exercise 02
        public static T Sum<T>(this IEnumerable<T> arr)
        {
            dynamic sum = 0;
            foreach (var c in arr)
            {
                sum += (dynamic)c;
            }
            return sum;
        }

        public static T Product<T>(this IEnumerable<T> arr)
        {
            dynamic product = 1;
            foreach (var c in arr)
            {
                product *= (dynamic)c;
                if (product == 0)
                    break;
            }
            return product;
        }

        public static T Min<T>(this IEnumerable<T> arr)
        {
            dynamic min = long.MaxValue;
            foreach (var c in arr)
            {
                if (c < min)
                    min = c;
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> arr)
        {
            dynamic max = long.MinValue;
            foreach (var c in arr)
            {
                if (c > max)
                    max = c;
            }
            return max;
        }

        public static T Average<T>(this IEnumerable<T> arr)
        {
            dynamic average = 0, counter = 0;
            foreach (var c in arr)
            {
                average += c;
                counter++;
            }
            if (counter == 0)
                throw new ArgumentException("The passed collection is empty.");
            return average / counter;
            
        }
        
        // For exercise 03
        public static void Print (IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
            }
        }

        // For exercise 06
        public static void Printing<T>  (IEnumerable<T> members)
        {
            foreach (var member in members)
            {
                Console.Write(member+ " ");
            }
        }

        // For exercise 10
        public static List<Student> FromGroup(this IEnumerable<Student> students, int group )
        {
            var temp = new List<Student>();
            foreach (var student in students)
            {
                if (student.GroupNumber==group ) 
                {
                    temp.Add(student);
                }
            }
            return temp.OrderBy(s => s.FirstName).ToList();
        }

        // For exercise 14
         public static List<Student> ExtractWithTwo2s(this IEnumerable<Student> students )
        {
            var temp = new List<Student>();
             foreach (var student in students)
             {
                 if (student.Marks[0] == 2 && student.Marks[1] == 2 && student.Marks.Count==2)
                 {
                     temp.Add(student);
                 }
             }
             return temp;
        }

         // For exercise 17
         public static bool GetLongeestString (string st)
         {
             if (st.Length > longest)
             {
                 longest = st.Length;
                 return true;
             }
             return false;
         }
    }
}
