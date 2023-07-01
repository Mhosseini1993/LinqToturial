using LinqToturial.Helper.Comparer.MotorComparer;
using LinqToturial.Helper.Comparer.StringComparer;
using LinqToturial.MockData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToturial.SequenceEqual
{
    public class SequenceEqualSample
    {
        public static void Sample()
        {
            bool isEqualNumbers = SampleCollections.Numbers2.SequenceEqual<string>(SampleCollections.Numbers,new StringInCaseSensetiveComparer());
            Console.WriteLine($"Is Equal : {isEqualNumbers}");

            bool isEqualMotor = SampleCollections.MotorSet.SequenceEqual(SampleCollections.EqualMotorSet,new MotorComparerByCompanyAndType());
            Console.WriteLine($"Is Equal : {isEqualMotor}");
        }
    }
}
