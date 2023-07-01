using LinqToturial.MockData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToturial.LetAndInto
{
    public class LetAndIntoSample
    {
        public static void UseLet()
        {
            ///Increase readability
            List<string> result1 = (from s in SampleCollections.Students
                                    where s.FirstName.Trim().ToLower().StartsWith("m")
                                    select s.FirstName.Trim().ToLower()).ToList();

            List<string> result2 = (from s in SampleCollections.Students
                                    let lowerFirstName = s.FirstName.Trim().ToLower()
                                    where lowerFirstName.StartsWith("m")
                                    select lowerFirstName).ToList(); // is var x
        }
        public static void UseInto()
        {
            // apply first condition on collection then apply second condition base on first result.
            var result = (from s in SampleCollections.Students
                          where s.Age > 12 && s.Age < 20
                          select s //firts result
                          into tenagerStudents // like #Temp in SQL SERVER
                          where tenagerStudents.FirstName.StartsWith("m")
                          select tenagerStudents);
        }
    }
}
