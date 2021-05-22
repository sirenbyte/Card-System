    //1- class
    public class Card
    {
        private string number;
        private bool valid;
        private string type;
        private int cvv;
        private string ym;
        private int pin;



        public Card(string number, bool valid, string type, int cvv, string ym, int pin)
        {
            this.number = number;
            this.valid = valid;
            this.type = type;
            this.cvv = cvv;
            this.ym = ym;
            this.pin = pin;
        }

        public virtual string Number
        {
            get
            {
                return number;
            }
            set
            {
                this.number = value;
            }
        }


        public virtual bool Valid
        {
            get
            {
                return valid;
            }
            set
            {
                this.valid = value;
            }
        }


        public virtual string Type
        {
            get
            {
                return type;
            }
            set
            {
                this.type = value;
            }
        }


        public virtual int Cvv
        {
            get
            {
                return cvv;
            }
            set
            {
                this.cvv = value;
            }
        }


        public virtual string Ym
        {
            get
            {
                return ym;
            }
            set
            {
                this.ym = value;
            }
        }


        public virtual int Pin
        {
            get
            {
                return pin;
            }
            set
            {
                this.pin = value;
            }
        }

    }