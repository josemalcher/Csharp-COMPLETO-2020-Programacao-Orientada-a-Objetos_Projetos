namespace inheritance1_csharp.Entities
{
    public class Acoount
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Acoount()
        {
        }

        public Acoount(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;

        }

        public void Deposit(double amount)
        {
            Balance += amount;

        }
    }
}