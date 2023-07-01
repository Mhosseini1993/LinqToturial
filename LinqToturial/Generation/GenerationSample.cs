using LinqToturial.MockData;
using LinqToturial.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToturial.Generation
{
    public class GenerationSample
    {
        public static void UseDefaultIfEmpty()
        {
            var emptyList = new List<string>();

            var newList = emptyList.DefaultIfEmpty();
            Console.WriteLine($"Count: {newList.Count()}");
            Console.WriteLine($"first item: {newList.ElementAt(0)}");

            var newList2 = emptyList.DefaultIfEmpty("None");
            Console.WriteLine($"Count: {newList2.Count()}");
            Console.WriteLine($"first item: {newList2.ElementAt(0)}");

            var numbers = SampleCollections.Numbers.DefaultIfEmpty("zero");

            var defaultStudentList = SampleCollections.EmptyStudents.DefaultIfEmpty(new Student()
            {
                Id = 0
            });
            SampleCollections.WriteCollection(defaultStudentList);
        }
        public static void UseEmpty()
        {
            IEnumerable<Student> lstStudent = Enumerable.Empty<Student>();
        }
        public static void UseRange()
        {
            IEnumerable<int> numbers = Enumerable.Range(20, 15);
        }
        public static void UseRepeat()
        {
            IEnumerable<Student> lstStudnet = Enumerable.Repeat<Student>(new Student()
            {
                Id = 0,
                Age = 0,
                FirstName = string.Empty,
                LastName = string.Empty,
                NationalCode = string.Empty
            }, 10);
        }
    }
}
