using LinqToturial.MockData;
using LinqToturial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToturial.Partitioning
{
    public class PartitioningSample
    {
        public static void UseSkip()
        {
            IEnumerable<string> simpleSkipResult = SampleCollections.Numbers.Skip(2);
            Console.WriteLine("-------------Simple Skip Result ----------");
            SampleCollections.WriteCollection(simpleSkipResult);

            IEnumerable<string> skipMoreThanListSizeResult = SampleCollections.Numbers.Skip(200);
            Console.WriteLine("-------------Simple More than list size Result ----------");
            SampleCollections.WriteCollection(skipMoreThanListSizeResult);

            IEnumerable<string> skipLastResult = SampleCollections.Numbers.SkipLast(2);
            Console.WriteLine("-------------Skip Last Result ----------");
            SampleCollections.WriteCollection(skipLastResult);


            IEnumerable<Student> skipWhileResult = SampleCollections.Students.SkipWhile(s => s.Age > 20);
            Console.WriteLine("-------------Simple while Result ----------");
            SampleCollections.WriteCollection(skipWhileResult);

        }
        public static void UseTake()
        {
            IEnumerable<string> simpleTakeResult = SampleCollections.Numbers.Take(2);
            Console.WriteLine("-------------Simple Skip Result ----------");
            SampleCollections.WriteCollection(simpleTakeResult);

            IEnumerable<string> takeMoreThanListSizeResult = SampleCollections.Numbers.Take(200);
            Console.WriteLine("-------------Simple More than list size Result ----------");
            SampleCollections.WriteCollection(takeMoreThanListSizeResult);

            IEnumerable<string> takeLastResult = SampleCollections.Numbers.TakeLast(2);
            Console.WriteLine("-------------Skip Last Result ----------");
            SampleCollections.WriteCollection(takeLastResult);


            IEnumerable<Student> takeWhileResult = SampleCollections.Students.TakeWhile(s => s.Age > 20);
            Console.WriteLine("-------------Simple while Result ----------");
            SampleCollections.WriteCollection(takeWhileResult);

        }
    }
}
