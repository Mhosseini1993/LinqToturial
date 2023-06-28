using System;

namespace LinqToturial.Models
{
    public class Mark:IComparable<Mark>
    {
        public int MarkId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public int Score { get; set; }
        public int CompareTo(Mark other)
        {
            return Score - other.Score;
        }
        public override string ToString()
        {
            return $"{MarkId}, studentId: {StudentId}, courseId: {CourseId}, score: {Score}";
        }
    }
}