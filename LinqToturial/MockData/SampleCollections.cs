using System;
using System.Collections.Generic;
using System.Linq;
using LinqToturial.Models;

namespace LinqToturial.MockData
{
    public class SampleCollections
    {
        public static List<object> Persons = new List<object>()
        {
            new Student(){Id = 1,FirstName = "Milad",LastName = "Mohammadi",NationalCode = "1234567890"},
            new Student(){Id = 2,FirstName = "ali",LastName = "ezati",NationalCode = "222222222"},
            new Teacher(){Id = 13,FirstName = "reza",LastName = "abdi"},
            new Teacher(){Id = 4,FirstName = "akbar",LastName = "abdi"},
            new Student(){Id = 55,FirstName = "mani",LastName = "milani",NationalCode = "45967824587678"},
        };
        public static List<Student> Students = new List<Student>()
        {
            new Student(){Id = 1,FirstName = "Milad",LastName = "Mohammadi",NationalCode = "1234567890",Age = 20},
            new Student(){Id = 2,FirstName = "ali",LastName = "ezati",NationalCode = "222222222",Age = 19},
            new Student(){Id = 13,FirstName = "reza",LastName = "abdi",NationalCode = "999999999",Age = 15},
            new Student(){Id = 4,FirstName = "akbar",LastName = "abdi",NationalCode = "333333",Age = 32},
            new Student(){Id = 55,FirstName = "mani",LastName = "milani",NationalCode = "45967824587678",Age = 14},
            new Student(){Id = 6,FirstName = "reza",LastName = "rezaei",NationalCode = "124527866738",Age = 12},
            new Student(){Id = 72,FirstName = "naghi",LastName = "mamooli",NationalCode = "1245863787",Age = 9},
            new Student(){Id = 81,FirstName = "mehran",LastName = "ghafoorian",NationalCode = "5555558888999",Age = 21},
        };
        public static Student[] StudentsArray =
        {
            new Student(){Id = 1,FirstName = "Milad",LastName = "Mohammadi",NationalCode = "1234567890",Age = 20},
            new Student(){Id = 2,FirstName = "ali",LastName = "ezati",NationalCode = "222222222",Age = 19},
            new Student(){Id = 13,FirstName = "reza",LastName = "abdi",NationalCode = "999999999",Age = 15},
            new Student(){Id = 4,FirstName = "akbar",LastName = "abdi",NationalCode = "333333",Age = 32},
            new Student(){Id = 55,FirstName = "mani",LastName = "milani",NationalCode = "45967824587678",Age = 14},
            new Student(){Id = 6,FirstName = "reza",LastName = "rezaei",NationalCode = "124527866738",Age = 12},
            new Student(){Id = 72,FirstName = "naghi",LastName = "mamooli",NationalCode = "1245863787",Age = 9},
            new Student(){Id = 81,FirstName = "mehran",LastName = "ghafoorian",NationalCode = "5555558888999",Age = 21},
        };
        public static List<Course> Courses = new List<Course>()
        {
            new Course(){Id=1002,TeacherName = "Haghighat",Title = "Distributed Systems"},
            new Course(){Id=2501,TeacherName = "Dehghan",Title = "MultiMedia Systems"},
            new Course(){Id=2368,TeacherName = "Haghighat",Title = "Operation Systems"},
            new Course(){Id=1003,TeacherName = "Meibodi",Title = "Distributed Systems"},
            new Course(){Id=2369,TeacherName = "Meibodi",Title = "Operation Systems"},
            new Course(){Id=1005,TeacherName = "Kalantari",Title = "MultiMedia Systems"},
            new Course(){Id=1006,TeacherName = "Dehghan",Title = "Network Systems"},
        };
        public static List<Mark> Marks = new List<Mark>()
        {
            new Mark(){MarkId = 1,CourseId = 2368,StudentId = 1,Score = 14},
            new Mark(){MarkId = 2,CourseId = 1002,StudentId = 2,Score = 12},
            new Mark(){MarkId = 3,CourseId = 2501,StudentId = 2,Score = 20},
            new Mark(){MarkId = 4,CourseId = 1003,StudentId = 13,Score = 11},
            new Mark(){MarkId = 5,CourseId = 2368,StudentId = 13,Score = 2},
            new Mark(){MarkId = 6,CourseId = 2501,StudentId = 13,Score = 16},
            new Mark(){MarkId = 7,CourseId = 2368,StudentId = 55,Score = 17},
            new Mark(){MarkId = 8,CourseId = 1002,StudentId = 55,Score = 18},
            new Mark(){MarkId = 9,CourseId = 2501,StudentId = 4,Score = 19},
            new Mark(){MarkId = 10,CourseId = 1002,StudentId = 72,Score = 12},
            new Mark(){MarkId = 11,CourseId = 2368,StudentId = 72,Score = 11},
            new Mark(){MarkId = 12,CourseId = 2501,StudentId = 6,Score = 20},
            new Mark(){MarkId = 13,CourseId = 1003,StudentId = 81,Score = 14},
        };
        public static List<Teacher> Teachers = new List<Teacher>()
        {
            new Teacher()
            {
                Id = 1,FirstName = "reza",LastName = "Haghighat",
                Educations = new List<Education>()
                {
                    new Education(){Title = "bachelor"},
                    new Education(){Title = "Master"},
                    new Education(){Title = "doctor"},
                }

            },
            new Teacher(){Id = 2,FirstName = "akbar",LastName = "Dehghan",
                Educations = new List<Education>()
                {
                    new Education(){Title = "bachelor"},
                    new Education(){Title = "Master"},
                    new Education(){Title = "doctor"},
                    new Education(){Title = "postdoc"},
                }},
        };
        public static List<Car> Cars = new List<Car>()
        {
            new Car()
            {
                Name = "Perid",Motor = new Motor()
                {
                    MotorType = MotorType.Gas,
                    Company = Company.Saipa,
                    MotorName = "saipa101"
                }
            },
            new Car()
            {
                Name = "Samand",Motor = new Motor()
                {
                    MotorType = MotorType.Hybrid,
                    Company = Company.IranKhodro,
                    MotorName = "EF7"
                }
            },
            new Car()
            {
                Name = "Dena",Motor = new Motor()
                {
                    MotorType = MotorType.Hybrid,
                    Company = Company.IranKhodro,
                    MotorName = "EF7"
                }
            },
            new Car()
            {
                Name = "L90",Motor = new Motor()
                {
                    MotorType = MotorType.Petrol,
                    Company = Company.ParsKhodro,
                    MotorName = "D100"
                }
            },
            new Car()
            {
                Name = "L90",Motor = new Motor()
                {
                    MotorType = MotorType.Gas,
                    Company = Company.ParsKhodro,
                    MotorName = "D100"
                }
            }
        };
        public static List<string> Numbers = new List<string>() { "One", "Two", "Three", "Four", "Five" };
        public static List<string> Numbers2 = new List<string>() { "One", "Two", "three", "Four", "Five" };

        public static List<int> Digits = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
        public static List<Student> EmptyStudents = new List<Student>();
        public static List<Student> SingleItemStudents = new List<Student>()
        {
            new Student()
            {
                Id = 1,
                FirstName = "Milad",
                LastName = "Mohammadi",
                NationalCode = "1234567890",
                Age = 20
            },
        };
        public static List<Motor> MotorSet = new List<Motor>()
        {
            new Motor()
            {
                MotorType = MotorType.Gas,
                Company = Company.Saipa,
                MotorName = "saipa101"
            },
            new Motor()
            {
                MotorType = MotorType.Hybrid,
                Company = Company.IranKhodro,
                MotorName = "EF7"
            },
            new Motor()
            {
                MotorType = MotorType.Hybrid,
                Company = Company.IranKhodro,
                MotorName = "EF7"
            },
            new Motor()
            {
                MotorType = MotorType.Petrol,
                Company = Company.ParsKhodro,
                MotorName = "D100"
            },
            new Motor()
            {
                MotorType = MotorType.Gas,
                Company = Company.ParsKhodro,
                MotorName = "D100"
            }
        };
        public static List<Motor> MotorSet2 = new List<Motor>()
        {
            new Motor()
            {
                MotorType = MotorType.Gas,
                Company = Company.Saipa,
                MotorName = "saipa101"
            },
            new Motor()
            {
                MotorType = MotorType.Hybrid,
                Company = Company.IranKhodro,
                MotorName = "EF7"
            },
            new Motor()
            {
                MotorType = MotorType.Hybrid,
                Company = Company.IranKhodro,
                MotorName = "EF7"
            },
            new Motor()
            {
                MotorType = MotorType.Petrol,
                Company = Company.ParsKhodro,
                MotorName = "c120"
            },
            new Motor()
            {
                MotorType = MotorType.Gas,
                Company = Company.ParsKhodro,
                MotorName = "c150"
            }
        };
        public static List<Motor> EqualMotorSet = new List<Motor>()
        {
            new Motor()
            {
                MotorType = MotorType.Gas,
                Company = Company.Saipa,
                MotorName = "saipa101"
            },
            new Motor()
            {
                MotorType = MotorType.Hybrid,
                Company = Company.IranKhodro,
                MotorName = "EF7"
            },
            new Motor()
            {
                MotorType = MotorType.Hybrid,
                Company = Company.IranKhodro,
                MotorName = "EF7"
            },
            new Motor()
            {
                MotorType = MotorType.Petrol,
                Company = Company.ParsKhodro,
                MotorName = "D100"
            },
            new Motor()
            {
                MotorType = MotorType.Gas,
                Company = Company.ParsKhodro,
                MotorName = "D100"
            }
        };

        public static List<int> DigitsWithDuplicate = new List<int>() { 1, 2, 3, 4, 5, 7, 2, 4, 5, 1, 8, 11, 35, 16 };
     
        public static void WriteCollection<T>(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
