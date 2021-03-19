namespace inheritance1_csharp.Entities
{
    public class BussinessAccount : Acoount
    {
        public double Limit { get; set; }

        public BussinessAccount()
        {
        }

        public BussinessAccount(int number, string holder, double balance, double limit) 
            : base(number, holder, balance)
        {
            Limit = limit;
        }

        public void loan(double amount)
        {
            Balance += amount;

        }
    }
}