using System;
using System.Collections.Generic;
using System.Text;

namespace LinqToturial.Models
{
    public class Car
    {
        public string Name { get; set; }
        public Motor Motor { get; set; }
        public override string ToString()
        {
            return $"{Name}: {Motor.MotorName} {Motor.Company} {Motor.MotorType}";
        }
    }
}