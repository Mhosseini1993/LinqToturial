using System.Collections.Generic;

namespace LinqToturial.Models
{
    public class Teacher 
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Education> Educations { get; set; }
        public override string ToString()
        {
            return $"{Id}, {FirstName}, {LastName}";
        }
    }
}