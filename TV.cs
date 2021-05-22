public class TV : Product
    {
        public TV(string name, double price) : base(name, price)
        {
        }
        public override void buying()
        {
            Console.WriteLine("Thnaks for buying TV");
        }
    }