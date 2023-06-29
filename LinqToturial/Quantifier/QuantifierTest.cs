using LinqToturial.Helper.Comparer.EqucationComparer;
using LinqToturial.MockData;
using LinqToturial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToturial.Quantifier
{
    public class QuantifierTest
    {

        public static void UseAll()
        {
            bool isAllOfStudentAccepted = SampleCollections.Marks.All(m => m.Score > 12);
            Console.WriteLine($"Are all Of student accepted?: {isAllOfStudentAccepted}");
        }
        public static void UseAny()
        {
            bool isExistRejectedStudent = SampleCollections.Marks.Any(m => m.Score < 12);
            Console.WriteLine($"Does exist rejected student?: {isExistRejectedStudent}");
        }
        public static void UseContains()
        {
            bool isExistTeacherWithDegreePostdoc = SampleCollections.Teachers.Any(t => t.Educations.Contains(new Education()
            {
                Title = "postdoc"
            }, new EqucationComparerByTitle()));
            Console.WriteLine($"Does exist teacher with degree Postdoc?: {isExistTeacherWithDegreePostdoc}");
        }
    }
}
