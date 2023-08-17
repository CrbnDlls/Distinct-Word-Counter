using Distinct_Word_Counter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distinct_Word_Counter
{
    internal class WordCounter : IWordCounter
    {
        SortedDictionary<int, SortedSet<string>> wordGroups;
        public IDictionary<int, SortedSet<string>> GetDistinctWords(string text)
        {
            wordGroups = new SortedDictionary<int, SortedSet<string>>();

            string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

            foreach (string word in words.Distinct())
            {
                AddWordToDictionary(word);
            }

            return wordGroups;
        }

        private void AddWordToDictionary(string word)
        {
            SortedSet<string> set;
            try
            {
                set = wordGroups[word.Count()];
                set.Add(word);
            }
            catch (KeyNotFoundException)
            {
                set = new SortedSet<string>() { word };
                wordGroups.Add(word.Count(), set);
            }
        }
    }
}
