public class Account : Operation
    {
        private Card card; //Composition
        private Person person; //Composition
        private double balance;
        private double bonus;


        public Account(Person person, Card card, double balance)
        {
            this.person = person;
            this.card = card;
            this.balance = balance;
        }

        public virtual double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                this.balance = value;
            }
        }


        public virtual double Bonus
        {
            get
            {
                return bonus;
            }
            set
            {
                this.bonus = value;
            }
        }


        public virtual Card Card
        {
            get
            {
                return card;
            }
            set
            {
                this.card = value;
            }
        }


        public virtual Person Person
        {
            get
            {
                return person;
            }
            set
            {
                this.person = value;
            }
        }



        public virtual void addBalance(double x)
        {
            this.balance += x;
        }

        public virtual void divBalance(double x)
        {
            this.balance -= x;
        }


        public virtual void buy(double x, Product product)
        {
            product.buying();
            this.balance -= x;
            this.bonus += x * 0.1;
        }

    }

    