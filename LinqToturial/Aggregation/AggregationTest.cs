using LinqToturial.MockData;
using LinqToturial.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToturial.Aggregation
{
    public class AggregationTest
    {
        public static void UseAggregate()
        {
            string numbersInString = SampleCollections.Numbers.Aggregate<string, string>("Result : ", (str1, str2) => $"{str1},{str2}");
            Console.WriteLine(numbersInString);

            string studentNames = SampleCollections.Students.Select(s => s.FirstName)
                                                            .ToList()
                                                            .Aggregate<string, string>("Student Names : ", (str1, str2) => $"{str1},{str2}");

            Console.WriteLine(studentNames);

            Int64 bigNumber = SampleCollections.Digits.Aggregate((d1, d2) => d1 * 10 + d2);
            Console.WriteLine(bigNumber.ToString());
        }
        public static void UseAverage()
        {
            double scoreAverage = SampleCollections.Marks.Average(m => m.Score);
            Console.WriteLine($"Average of score is : {scoreAverage}");

            var groupMarkByStudentId = SampleCollections.Marks.GroupBy(m => m.StudentId).ToList();

            var averagePerStudentId = groupMarkByStudentId.Select(r => new
            {
                studentid = r.Key,
                average = r.Average(a => a.Score)
            });
            SampleCollections.WriteCollection(averagePerStudentId);

        }
        public static void UseCount()
        {
            int markCount = SampleCollections.Marks.Count;
            int acceptedMarkCount = SampleCollections.Marks.Count(m => m.Score >= 12);
            int rejectedMarkCount = SampleCollections.Marks.Count(m => m.Score < 12);

            var result = SampleCollections.Students.GroupJoin(SampleCollections.Marks,
                                                           s => s.Id,
                                                           m => m.StudentId,
                                                           (s, m) => new
                                                           {
                                                               fullName = $"{s.FirstName} {s.LastName}",
                                                               acceptedCount = m.Count(s => s.Score >= 12),
                                                               rejectedCount = m.Count(s => s.Score < 12)
                                                           }).ToList();

            SampleCollections.WriteCollection(result);

        }
        public static void UseMinMax()
        {
            int minimumScore = SampleCollections.Marks.Min(s => s.Score);
            int maximumScore = SampleCollections.Marks.Min(s => s.Score);
            Console.WriteLine($"Minimum Score : {minimumScore} Maximum Score is : {maximumScore}");

            int minimumAcceptedScore = SampleCollections.Marks.Where(s => s.Score >= 12)
                                                              .Select(s => s.Score)
                                                              .Min();
            Console.WriteLine($"Minimum accepted score : {minimumAcceptedScore}");

            int maximumAcceptedScore = SampleCollections.Marks.Where(s => s.Score >= 12)
                                                              .Select(s => s.Score)
                                                              .Max();
            Console.WriteLine($"Maximum accepted score : {maximumAcceptedScore}");

        }
    }
}

