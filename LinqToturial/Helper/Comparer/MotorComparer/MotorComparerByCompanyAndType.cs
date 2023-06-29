using LinqToturial.Models;

namespace LinqToturial.Helper.Comparer.MotorComparer
{
    public class MotorComparerByCompanyAndType : IEqualityComparer<Motor>
    {
        public bool Equals(Motor? x, Motor? y)
        {
            return x.MotorType == y.MotorType;
        }

        public int GetHashCode(Motor obj)
        {
            return obj.Company.GetHashCode();
        }
    }

}
