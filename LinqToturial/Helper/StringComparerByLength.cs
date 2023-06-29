using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToturial.Helper
{
    public class StringComparerByLength : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            return x.Length - y.Length;
        }
    }
}
