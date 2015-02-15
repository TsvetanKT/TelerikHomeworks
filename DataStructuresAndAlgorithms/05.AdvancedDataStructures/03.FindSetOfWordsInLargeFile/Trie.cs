namespace FindSetOfWordsInLargeFile
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Trie
    {
        int words;
        int prefixes;
        Trie[] edges;

        public Trie()
        {
            this.edges = new Trie[26];
            this.Words = 0;
            this.Prefixes = 0;
        }

        public Trie AddWord(Trie node, string word)
        {
            return this.AddWord(node, word, 0);
        }

        public void AddOccuranceIfExists(Trie node, string word)
        {
            AddOccuranceIfExists(node, word, 0);
        }

        public int CountWords(Trie node, string word)
        {
            return this.CountWords(node, word, 0);
        }

        public int CountPrefix(Trie node, string word)
        {
            return this.CountPrefix(node, word, 0);
        }

        public int Words
        {
            get
            {
                return this.words;
            }
            set
            {
                this.words = value;
            }
        }

        public int Prefixes
        {
            get
            {
                return this.prefixes;
            }
            set
            {
                this.prefixes = value;
            }
        }

        private void AddOccuranceIfExists(Trie node, string word, int indexInWord)
        {
            if (word.Length == indexInWord)
            {
                node.Words += 1;
            }
            else
            {
                int nextCharIndex = word[indexInWord] - 'a';
                indexInWord++;
                node.Prefixes += 1;

                if (node.edges[nextCharIndex] == null)
                {
                    return;
                }
                else
                {
                    AddOccuranceIfExists(node.edges[nextCharIndex], word, indexInWord);
                }
            }
        }

        private Trie AddWord(Trie node, string word, int indexInWord)
        {
            if (word.Length != indexInWord)
            {
                node.Prefixes += 1;
                int index = word[indexInWord] - 'a';
                indexInWord++;

                if (node.edges[index] == null)
                {
                    node.edges[index] = new Trie();
                }

                node.edges[index] = AddWord(node.edges[index], word, indexInWord);
            }

            return node;
        }

        private int CountWords(Trie node, string word, int indexInWord)
        {
            if (word.Length == indexInWord)
            {
                return node.words;
            }
            else
            {
                int nextCharIndex = word[indexInWord] - 'a';
                indexInWord++;

                if (node.edges[nextCharIndex] == null)
                {
                    return 0;
                }

                else
                {
                    return CountWords(node.edges[nextCharIndex], word, indexInWord);
                }
            }
        }

        private int CountPrefix(Trie node, string word, int indexInWord)
        {
            if (word.Length == indexInWord)
            {
                return node.prefixes;
            }
            else
            {
                int nextCharIndex = word[indexInWord] - 'a';
                indexInWord++;

                if (node.edges[nextCharIndex] == null)
                {
                    return 0;
                }
                else
                {
                    return CountPrefix(node.edges[nextCharIndex], word, indexInWord);
                }
            }
        }
    }
}
