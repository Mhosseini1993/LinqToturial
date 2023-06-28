using LinqToturial.MockData;
using LinqToturial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToturial.Joining
{
    public class JoiningTest
    {
        public static void UseJoin()
        {
            IEnumerable<Student> students = SampleCollections.Students;
            IEnumerable<Mark> marks = SampleCollections.Marks;

            var studentInfoWithHisScore = students.Join(marks,
                c => c.Id,
                c => c.StudentId,
                (s, m) => new
                {
                    FullName = $"{s.FirstName} {s.LastName}",
                    CourseId = m.CourseId,
                    Score = m.Score
                }).OrderBy(s=>s.FullName);
            Console.WriteLine("----------------Student score-----------------------");
            SampleCollections.WriteCollection(studentInfoWithHisScore);


            IEnumerable<Course> courses = SampleCollections.Courses;
            var result = courses.Join(studentInfoWithHisScore,
                c => c.Id,
                c => c.CourseId,
                (c, o) => new
                {
                    Fullname = o.FullName,
                    CourseName = c.Title,
                    Score = o.Score,
                    TeacherName = c.TeacherName
                }).OrderBy(s=>s.Fullname);
            Console.WriteLine("----------------Student score in details-----------------------");
            SampleCollections.WriteCollection(result);
        }
        public static void UseGroupJoin()
        {
            IEnumerable<Student> students = SampleCollections.Students;
            IEnumerable<Mark> marks = SampleCollections.Marks;

            var result = students.GroupJoin(marks,
                                       s => s.Id,
                                       m => m.StudentId,
                                       (s, m) => new
                                       {
                                           fullName = $"{s.FirstName} {s.LastName}",
                                           markInfo = m
                                       }).ToList();

            foreach (var student in result)
            {
                Console.WriteLine(student.fullName);
                foreach (var mark in student.markInfo)
                {
                    Console.WriteLine(mark);
                }
            }

            
        }
    }
}
