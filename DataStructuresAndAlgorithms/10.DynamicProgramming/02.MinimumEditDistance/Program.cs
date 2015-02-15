namespace MinimumEditDistance
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        /*
        02.Write a program to calculate the "Minimum Edit Distance" (MED) between two words. MED(x, y)
        is the minimal sum of costs of edit operations used to transform x to y. Sample costs are given below:
                cost (replace a letter) = 1
                cost (delete a letter) = 0.9
                cost (insert a letter) = 0.8
            Example: 
                x = "developer", y = "enveloped" -> cost = 2.7 
                delete ‘d’:  "developer" -> "eveloper", cost = 0.9
                insert ‘n’:  "eveloper" -> "enveloper", cost = 0.8
                replace ‘r’ -> ‘d’:  "enveloper" -> "enveloped", cost = 1
         */

        public static void Main()
        {
            string[] arrFirst = { "developer", "developer", "eveloper", "enveloper" };
            string[] arrSecond = { "enveloped", "eveloper", "enveloper", "enveloped" };

            for (int i = 0; i < arrFirst.Length; i++)
            {
                Console.WriteLine("X = {0}\nY =  {1}\nconst = {2}\n", 
                    arrFirst[i], 
                    arrSecond[i], 
                    MED(arrFirst[i], arrSecond[i]));
            }

        }

        public static double MED(string firstWord, string secondWord)
        {
            double result = 0;

            string LCS = LongestCommonSubstring(firstWord, secondWord);
            if (LCS == String.Empty || LCS.Length == 0)
            {
                if (firstWord.Length == secondWord.Length)
                {
                    result = firstWord.Length;
                }
                else if (firstWord.Length > secondWord.Length)
                {
                    result = (firstWord.Length - secondWord.Length) * 0.9 +
                        secondWord.Length;
                }
                else
                {
                    result = (secondWord.Length - firstWord.Length) * 0.8 +
                        firstWord.Length;
                }
            }

            else
            {

                int indexOfLcsInFirstWord = firstWord.IndexOf(LCS);
                int indexOfLcsInSecondWord = secondWord.IndexOf(LCS);

                string firstWordPrefix = firstWord.Substring(0, indexOfLcsInFirstWord);
                string secondWordPrefix = secondWord.Substring(0, indexOfLcsInSecondWord);

                string firstWordSufix = firstWord.Substring(indexOfLcsInFirstWord + LCS.Length);
                string secondWordSufix = secondWord.Substring(indexOfLcsInSecondWord + LCS.Length);

                result = MED(firstWordPrefix, secondWordPrefix) + MED(firstWordSufix, secondWordSufix);
            }

            return result;
        }

        public static string LongestCommonSubstring(string firstWord, string secondWord)
        {
            if (String.IsNullOrEmpty(firstWord) || String.IsNullOrEmpty(secondWord))
                return string.Empty;

            int[,] num = new int[firstWord.Length, secondWord.Length];
            int maxlen = 0;
            int lastSubsBegin = 0;
            StringBuilder sequenceBuilder = new StringBuilder();

            for (int i = 0; i < firstWord.Length; i++)
            {
                for (int j = 0; j < secondWord.Length; j++)
                {
                    if (firstWord[i] != secondWord[j])
                        num[i, j] = 0;
                    else
                    {
                        if ((i == 0) || (j == 0))
                            num[i, j] = 1;
                        else
                            num[i, j] = 1 + num[i - 1, j - 1];

                        if (num[i, j] > maxlen)
                        {
                            maxlen = num[i, j];
                            int thisSubsBegin = i - num[i, j] + 1;
                            if (lastSubsBegin == thisSubsBegin)
                            {
                                sequenceBuilder.Append(firstWord[i]);
                            }
                            else
                            {
                                lastSubsBegin = thisSubsBegin;
                                sequenceBuilder.Length = 0; //clear it
                                sequenceBuilder.Append(firstWord.Substring(lastSubsBegin, (i + 1) - lastSubsBegin));
                            }
                        }
                    }
                }
            }
            return sequenceBuilder.ToString();
            //return sequence;
            //return maxlen;
        }
    }
}
