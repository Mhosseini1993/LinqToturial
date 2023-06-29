using LinqToturial.Helper;
using LinqToturial.Helper.Comparer.MotorComparer;
using LinqToturial.MockData;
using LinqToturial.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToturial.Comparer
{
    public class ComparerTest
    {
        public static void UseEqualityComparer()
        {
            List<Car> cars = SampleCollections.Cars;

            var groupCarsByMotor1 = cars.GroupBy(c => c.Motor, new MotorComparerByCompanyAndType()).ToList();
            SampleCollections.WriteIGrouping(groupCarsByMotor1);

            var groupCarsByMotor2 = cars.GroupBy(c => c.Motor, new MotorComparerByType()).ToList();
            SampleCollections.WriteIGrouping(groupCarsByMotor1);

            var groupCarsByMotor3 = cars.GroupBy(c => c.Motor, new MotorComparerByTypeAndName()).ToList();
            SampleCollections.WriteIGrouping(groupCarsByMotor1);

        }
        public static void UseComparer()
        {
            List<Student> students = SampleCollections.Students;
            var result = students.OrderBy(s => s.FirstName, new StringComparerByLength()).ToList();
            SampleCollections.WriteCollection(result);
        }
    }

}
