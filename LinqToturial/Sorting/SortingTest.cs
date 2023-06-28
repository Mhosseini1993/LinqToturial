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

            
            
            Console.WriteLine("----------ThenByDescending---------");
            var orderbyNameThenByDescendingAge = students
                .OrderBy(c => c.FirstName)
                .ThenByDescending(c => c.Age).ToList();
            SampleCollections.WriteCollection(orderbyNameThenByDescendingAge);
        }
        public static void UserOrderByThenByAsc()
        {
            var students = SampleCollections.Students;
            var orderedByAgeAsc = students.OrderBy(s => s.Age)
                                          .ThenBy(s=>s.FirstName)
                                          .ToList();
            Console.WriteLine("----------Sort student by age Asc---------");
            SampleCollections.WriteCollection(orderedByAgeAsc);
        }
    }
}
