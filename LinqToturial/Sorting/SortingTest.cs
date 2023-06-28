using LinqToturial.MockData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToturial.Sorting
{
    public class SortingTest
    {
        public static void UserOrderByAsc()
        {
            var students = SampleCollections.Students;
            var orderedByAgeAsc = students.OrderBy(s => s.Age)
                                          .ToList();
            Console.WriteLine("----------Sort student by age Asc---------");
            SampleCollections.WriteCollection(orderedByAgeAsc);
        }
        public static void UserOrderByDesc()
        {
            var students = SampleCollections.Students;
            var orderedByAgeDescending = students.OrderByDescending(s => s.Age)
                                                 .ToList();

            Console.WriteLine("----------Sort student by age Desc---------");
            SampleCollections.WriteCollection(orderedByAgeDescending);
        }
        public static void UserOrderByThenByAsc()
        {
            var students = SampleCollections.Students;
            var orderedByAgeAsc = students.OrderBy(s => s.Age)
                                          .ThenBy(s => s.FirstName)
                                          .ToList();
            Console.WriteLine("----------Sort student by age then firstname Asc---------");
            SampleCollections.WriteCollection(orderedByAgeAsc);
        }
        public static void UserOrderByThenByDesc()
        {
            var students = SampleCollections.Students;
            var orderedByAgeAsc = students.OrderByDescending(s => s.Age)
                                          .ThenByDescending(s => s.FirstName)
                                          .ToList();
            Console.WriteLine("----------Sort student by age then firstname Desc---------");
            SampleCollections.WriteCollection(orderedByAgeAsc);
        }
        public static void UseReverse()
        {
            var students = SampleCollections.Students;
            students.Reverse();
            Console.WriteLine("----------Reverse student list---------");
            SampleCollections.WriteCollection(students);
        }
    }
}
