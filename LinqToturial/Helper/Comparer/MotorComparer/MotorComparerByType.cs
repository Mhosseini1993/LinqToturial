using LinqToturial.Models;
using System.Diagnostics.CodeAnalysis;

namespace LinqToturial.Helper.Comparer.MotorComparer
{
    public class MotorComparerByType : IEqualityComparer<Motor>
    {
        public bool Equals(Motor? x, Motor? y)
        {
            return true;
        }

        public int GetHashCode([DisallowNull] Motor obj)
        {
            return obj.MotorType.GetHashCode();
        }
    }

}
