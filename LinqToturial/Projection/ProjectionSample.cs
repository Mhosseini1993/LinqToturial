using LinqToturial.MockData;
using LinqToturial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToturial.Projection
{
    public class ProjectionSample
    {
        public static void UseSelect()
        {
            IEnumerable<Student> students = SampleCollections.Students;

            List<string> lstStudentFullNames = students.OrderBy(s => s.Age)
                                                       .ThenBy(s => s.FirstName)
                                                       .ThenBy(s => s.LastName)
                                                       .Select(s => $"{s.FirstName} {s.LastName}")
                                                       .ToList();

            SampleCollections.WriteCollection<string>(lstStudentFullNames);
        }
        public static void UseSelectMany()
        {
            IEnumerable<Teacher> teachers = SampleCollections.Teachers;

            var res = teachers.SelectMany(t => t.Educations
                                                .Where(e => e.Title.Contains("postdoc"))
                                                .Select(r=>new
            {
                FullName= t.FirstName,
                r.Title
            })).ToList();

            SampleCollections.WriteCollection(res);
        }
    }
}
