namespace LinqToturial.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalCode { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"{Id}, firstname:{FirstName}, lastname:{LastName}, nationalCode:{NationalCode}, age:{Age}";
        }
    }
}