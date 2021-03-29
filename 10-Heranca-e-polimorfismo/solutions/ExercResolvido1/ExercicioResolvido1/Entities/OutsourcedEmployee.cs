namespace ExercicioResolvido1.Entities
{
    public class OutsourcedEmployee : Employee
    {
        private double AdditionalCharge { get; set; }

        public OutsourcedEmployee()
        {
        }
        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) 
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }
        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }
}