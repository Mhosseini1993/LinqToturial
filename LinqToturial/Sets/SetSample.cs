using LinqToturial.Helper.Comparer.MotorComparer;
using LinqToturial.MockData;
using LinqToturial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToturial.Sets
{
    public class SetSample
    {
        public static void UseDistinct()
        {
            IEnumerable<int> uniqeDigits = SampleCollections.DigitsWithDuplicate.Distinct();
            Console.WriteLine("--------------- Distinct Digits --------------");
            SampleCollections.WriteCollection(uniqeDigits);

            IEnumerable<Motor> uniqeMotors = SampleCollections.MotorSet2.Distinct(new MotorComparerByType());
            Console.WriteLine("--------------- Distinct Motor --------------");
            SampleCollections.WriteCollection(uniqeMotors);
        }
        public static void UseExcept()
        {
            IEnumerable<int> digitExcepResult = SampleCollections.DigitsWithDuplicate.Except(SampleCollections.Digits);
            Console.WriteLine("--------------- DigitsWithDuplicate except Digits --------------");
            SampleCollections.WriteCollection(digitExcepResult);

            IEnumerable<Motor> motorExceptResult = SampleCollections.MotorSet2.Except(SampleCollections.MotorSet,new MotorComparerByTypeAndName());
            Console.WriteLine("--------------- MotorSet2 except MotorSet --------------");
            SampleCollections.WriteCollection(motorExceptResult);
        }
        public static void UseIntersect()
        {
            IEnumerable<int> digitIntersectResult = SampleCollections.DigitsWithDuplicate.Intersect(SampleCollections.Digits);
            Console.WriteLine("--------------- DigitsWithDuplicate Intersect with Digits --------------");
            SampleCollections.WriteCollection(digitIntersectResult);

            IEnumerable<Motor> motorIntersectResult = SampleCollections.MotorSet2.Intersect(SampleCollections.MotorSet, new MotorComparerByType());
            Console.WriteLine("--------------- MotorSet2 Intersect MotorSet --------------");
            SampleCollections.WriteCollection(motorIntersectResult);
        }
        public static void UseUnion()
        {
            IEnumerable<int> digitUnionResult = SampleCollections.DigitsWithDuplicate.Union(SampleCollections.Digits);
            Console.WriteLine("--------------- DigitsWithDuplicate Union with Digits --------------");
            SampleCollections.WriteCollection(digitUnionResult);

            IEnumerable<Motor> motorUnionResult = SampleCollections.MotorSet2.Union(SampleCollections.MotorSet, new MotorComparerByCompanyAndType());
            Console.WriteLine("--------------- MotorSet2 Union MotorSet --------------");
            SampleCollections.WriteCollection(motorUnionResult);
        }
    }
}
