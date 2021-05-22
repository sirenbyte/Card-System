public class Person
    {
        private int id;
        private string fio;
        private string iin;
        private string address;
        private string birth;
        private string entity;


        public Person(int id, string fio, string iin, string address, string birth, string entity)
        {
            this.id = id;
            this.fio = fio;
            this.iin = iin;
            this.address = address;
            this.birth = birth;
            this.entity = entity;
        }

        public virtual int Id
        {
            get
            {
                return id;
            }
            set
            {
                this.id = value;
            }
        }


        public virtual string Fio
        {
            get
            {
                return fio;
            }
            set
            {
                this.fio = value;
            }
        }


        public virtual string Iin
        {
            get
            {
                return iin;
            }
            set
            {
                this.iin = value;
            }
        }


        public virtual string Address
        {
            get
            {
                return address;
            }
            set
            {
                this.address = value;
            }
        }


        public virtual string Birth
        {
            get
            {
                return birth;
            }
            set
            {
                this.birth = value;
            }
        }


        public virtual string Entity
        {
            get
            {
                return entity;
            }
            set
            {
                this.entity = value;
            }
        }

    }
    public abstract class Product
    {
        private string name;
        private double price;

        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        protected internal Product()
        {
        }
        public abstract void buying();

        public virtual string Name
        {
            get
            {
                return name;
            }
            set
            {
                this.name = value;
            }
        }


        public virtual double Price
        {
            get
            {
                return price;
            }
            set
            {
                this.price = value;
            }
        }


        public override string ToString()
        {
            return "Product{" + "name='" + name + '\'' + ", price=" + price + '}';
        }
    }

    