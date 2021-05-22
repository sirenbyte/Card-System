public class Phone : Product
    {
        public Phone(string name, double price) : base(name, price)
        {
        }
        public override void buying()
        {
            Console.WriteLine("Thnaks for buying phone");
        }

    }