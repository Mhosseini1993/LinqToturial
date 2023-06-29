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
            Console.WriteLine($"isAllOfStudentAccepted : {isAllOfStudentAccepted}");
        }
        public static void UseAny()
        {
            bool isExistRejectedStudent = SampleCollections.Marks.Any(m => m.Score < 12);
            Console.WriteLine($"isExistRejectedStudent: {isExistRejectedStudent}");
        }
        public static void UseContains()
        {
            bool isExistTeacherWithDegreePostdoc = SampleCollections.Teachers.Any(t => t.Educations.Contains(new Education()
            {
                Title = "postdoc"
            },new EqucationComparerByTitle()));
        }
    }
}
