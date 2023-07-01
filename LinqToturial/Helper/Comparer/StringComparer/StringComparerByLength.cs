using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToturial.Helper.Comparer.StringComparer
{
    public class StringComparerByLength : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            return x.Length - y.Length;
        }
    }

}
