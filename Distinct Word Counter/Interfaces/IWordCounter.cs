using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distinct_Word_Counter.Interfaces
{
    public interface IWordCounter
    {
        IDictionary<int, SortedSet<string>> GetDistinctWords(string text);
    }
}
