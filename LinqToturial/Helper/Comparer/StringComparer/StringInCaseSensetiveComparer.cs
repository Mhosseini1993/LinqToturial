namespace LinqToturial.Helper.Comparer.StringComparer
{
    public class StringInCaseSensetiveComparer : IEqualityComparer<string>
    {
        public bool Equals(string? x, string? y)
        {
            return x.Trim().ToLower() == y.Trim().ToLower();
        }

        public int GetHashCode(string obj)
        {
            return obj.GetHashCode();
        }
    }

}
