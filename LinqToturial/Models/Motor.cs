namespace LinqToturial.Models
{
    public class Motor
    {
        public string MotorName { get; set; }
        public Company Company { get; set; }
        public MotorType MotorType { get; set; }

        public override string ToString()
        {
            return $"{MotorName} {Company} {MotorType}";
        }

    }
}