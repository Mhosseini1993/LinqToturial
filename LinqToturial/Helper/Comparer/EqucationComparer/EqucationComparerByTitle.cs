using LinqToturial.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToturial.Helper.Comparer.EqucationComparer
{
    public class EqucationComparerByTitle : IEqualityComparer<Education>
    {
        public bool Equals(Education? x, Education? y)
        {
            return x.Title == y.Title;
        }

        public int GetHashCode([DisallowNull] Education obj)
        {
            return obj.GetHashCode();
        }
    }
}
