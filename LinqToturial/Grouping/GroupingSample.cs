using LinqToturial.MockData;
using LinqToturial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToturial.Grouping
{
    public class GroupingSample
    {
        /// <summary>
        /// This method is Deferred Execution
        /// </summary>
        public static void UseGroupBy()
        {


            IEnumerable<Mark> marks = SampleCollections.Marks;
            IEnumerable<IGrouping<int, Mark>> groupedMarksByStudentId = marks.GroupBy(c => c.StudentId);
            Console.WriteLine("----------Group Marks by studentId---------");
            SampleCollections.WriteIGrouping(groupedMarksByStudentId);



            IEnumerable<IGrouping<int, Mark>> groupedMarksByCourseId = marks.GroupBy(c => c.CourseId);
            Console.WriteLine("----------Group Marks by studentId---------");
            SampleCollections.WriteIGrouping(groupedMarksByCourseId);
        }
        /// <summary>
        /// This method is immediate Execution
        /// </summary>
        public static void UseLookup()
        {
            IEnumerable<Course> courses = SampleCollections.Courses;
            var groupCoursebyTeacher = courses.ToLookup(c => c.TeacherName);
            Console.WriteLine("----------Group Course by teacherName---------");
            SampleCollections.WriteIGrouping(groupCoursebyTeacher);

            var groupCoursebyTitle = courses.ToLookup(c => c.Title);
            Console.WriteLine("----------Group Course by title---------");
            SampleCollections.WriteIGrouping(groupCoursebyTitle);

        }
    }
}
