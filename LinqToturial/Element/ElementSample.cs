using LinqToturial.MockData;
using LinqToturial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToturial.Element
{
    public class ElementSample
    {
        public static void UseElementAt()
        {
            var element = SampleCollections.Marks.ElementAt(5);
            Console.WriteLine(element);
            //this throw an exception out of index
            //var element2 = SampleCollections.Marks.ElementAt(100);
            var element3 = SampleCollections.Marks.ElementAtOrDefault(100);
            Console.WriteLine(element);
        }
        public static void UseFirst()
        {
            var firstMark = SampleCollections.Marks.First();
            var student = SampleCollections.Students.First(c => c.Age < 12);
            
            //Exception this throw an exception because there is no student with age <5 
            //var student2 = SampleCollections.Students.First(c => c.Age < 5);

            var student3 = SampleCollections.Students.FirstOrDefault(c => c.Age < 5);
            
            //Exception this throw an exception because list is empty
            //var student4 = SampleCollections.EmptyStudents.First();

            var student5 = SampleCollections.EmptyStudents.FirstOrDefault();

        }
        public static void UseLast()
        {
            var lastMark = SampleCollections.Marks.Last();
            var student = SampleCollections.Students.Last(c => c.Age > 12);

            //Exception this throw an exception because there is no student with age <5 
            //var student2 = SampleCollections.Students.Last(c => c.Age < 5);

            var student3 = SampleCollections.Students.LastOrDefault(c => c.Age < 5);

            //Exception this throw an exception because list is empty
            //var student4 = SampleCollections.EmptyStudents.Last();

            var student5 = SampleCollections.EmptyStudents.LastOrDefault();

        }
        public static void UseSingle()
        {
            var singleStudent = SampleCollections.SingleItemStudents.Single();
            
            //thow an exception because list has more than one item
            //var singleStudent2 = SampleCollections.Students.Single();

            //thow an exception because list is empty
            //var singleStudent3 = SampleCollections.EmptyStudents.Single();

            var singleStudent4 = SampleCollections.Students.Single(c => c.Age == 21);

            //thow an exception because list has more than one item with this condition
            var singleStudent5 = SampleCollections.Students.Single(c => c.Age > 15);

            var singleStudent6 = SampleCollections.EmptyStudents.SingleOrDefault();
            var singleStudent7 = SampleCollections.Students.SingleOrDefault(c => c.Age == 1000);
        }
    }
}
