using LinqToturial.Helper;
using LinqToturial.MockData;
using LinqToturial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LinqToturial.Filtering
{
    public class FilteringTest
    {
        public static void UseWhere()
        {
            IEnumerable<Student> students = SampleCollections.Students;

            var tenagerStudents = students.Where(s => s.Age>12 && s.Age<20).ToList();
            Console.WriteLine("***** TenagerStudents *****");
            SampleCollections.WriteCollection<Student>(tenagerStudents);

        }
        public static void UseWhereWithIndex()
        {
            List<int> digits = SampleCollections.DigitsWithDuplicate;

            var eventDigitsWithEvenIdex = digits.Where((d, index) => (d%2==0) && index%2==0).ToList();

            Console.WriteLine("*****Event Numbers *****");
            SampleCollections.WriteCollection(eventDigitsWithEvenIdex);
        }

        public static void UseOfType()
        {
            List<Teacher> teachers = SampleCollections.Persons.OfType<Teacher>().ToList();

            Console.WriteLine("*****Teachers*****");
            SampleCollections.WriteCollection<Teacher>(teachers);

            Console.WriteLine("*****Students*****");
            List<Student> students = SampleCollections.Persons.OfType<Student>().ToList();
            SampleCollections.WriteCollection<Student>(students);
        }
        public static void SearchWithLambada(RequestSearchStudentDto inputFilter)
        {
            IEnumerable<Student> students = SampleCollections.Students;

            if(!string.IsNullOrEmpty(inputFilter.firstName))
                students=students.Where(s=>s.FirstName.Contains(inputFilter.firstName));

            if (!string.IsNullOrEmpty(inputFilter.lastName))
                students=students.Where(s => s.LastName.Contains(inputFilter.lastName));

            if (!string.IsNullOrEmpty(inputFilter.nationalCode))
                students=students.Where(s => s.NationalCode.Contains(inputFilter.nationalCode));

            if(inputFilter.age>0)
                students=students.Where(s => s.Age==inputFilter.age);

            Console.WriteLine("***** Filtered Students With Lambada *****");
            SampleCollections.WriteCollection(students);
        }

        public static void SearchWithExpression(RequestSearchStudentDto inputFilter)
        {
            Expression<Func<Student, bool>> firstNameExp = null;
            Expression<Func<Student, bool>> lastNameExp = null;
            Expression<Func<Student, bool>> nationCodeExp = null;
            Expression<Func<Student, bool>> ageExp = null;

            IEnumerable<Student> students = SampleCollections.Students;

            if (!string.IsNullOrEmpty(inputFilter.firstName))
                firstNameExp=s => s.FirstName.Contains(inputFilter.firstName);

            if (!string.IsNullOrEmpty(inputFilter.lastName))
                lastNameExp=s => s.LastName.Contains(inputFilter.lastName);

            if (!string.IsNullOrEmpty(inputFilter.nationalCode))
                nationCodeExp = s => s.NationalCode.Contains(inputFilter.nationalCode);

            if (inputFilter.age>0)
                ageExp=s => s.Age==inputFilter.age;


            Expression<Func<Student, bool>> finalExpression = ExpressionHelper.GenerateExpression(new[]
            {
                firstNameExp,
                lastNameExp,
                nationCodeExp,
                ageExp
            });

            Console.WriteLine("***** Filtered Students With Expression *****");
            SampleCollections.WriteCollection<Student>(students.Where(finalExpression.Compile()));
        }
    }
}
