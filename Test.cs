using System;
using System.Collections.Generic;
public class Test
    {
        public static int idcounter = 1;
        public static List<Account> a = new List<Account>();
        public static List<Product> p = new List<Product>();
        public static void Main(string[] args)
        {

            Person p1 = new Person(idcounter, "a", "a", "a", "a", "a");
            Card c1 = new Card("123", true, "gold", 123, "12/20", 1234);
            Account a1 = new Account(p1, c1, 1800000);
            a.Add(a1);
            Product phone1 = new Phone("Iphone 12", 300000);
            Product tv1 = new TV("Samsung LED", 250000);
            p.Add(phone1);
            p.Add(tv1);
            menu();

        }
        public static void menu()
        {
            bool system = true;
            while (system)
            {
                Console.WriteLine("Hello! You can login or regitration");
                Console.WriteLine("Choose command:");
                Console.WriteLine("1)Enter with pin");
                Console.WriteLine("2)Registration");
                Console.WriteLine("3)Exit");
                Console.WriteLine("Enter command:");
                      
                int choose = int.Parse(Console.ReadLine());

                //Pin
                if (choose == 1)
                {
                    Console.WriteLine("Enter pin: ");
                    int code = int.Parse(Console.ReadLine());
                    Account bean = null;
                    foreach (Account i in a)
                    {
                        if (i.Card.Pin == code)
                        {
                            bean = i;
                        }
                    }
                    Console.WriteLine("Hello " + bean.Person.Fio);

                    while (bean != null)
                    {
                        Console.WriteLine("1)Display balance");
                        Console.WriteLine("2)Add balance");
                        Console.WriteLine("3)Vvid balance");
                        Console.WriteLine("4)Shop");
                        Console.WriteLine("5)Exit");
                        
                        
                        int l2 = int.Parse(Console.ReadLine());
                        if (l2 == 1)
                        {
                            Console.WriteLine("Balance: " + bean.Balance);
                            Console.WriteLine("Bonus: " + bean.Bonus);
                        }
                        if (l2 == 2)
                        {
                            Console.Write("Enter how much add money:");
                            bean.addBalance(double.Parse(Console.ReadLine()));
                        }
                        if (l2 == 3)
                        {
                            Console.Write("Enter how much vvid money:");
                            bean.divBalance(double.Parse(Console.ReadLine()));
                        }
                        if (l2 == 4)
                        {
                            Product product;
                            foreach (Product i in p)
                            {
                                Console.WriteLine(i.ToString());
                            }
                            int q = int.Parse(Console.ReadLine());
                            product = p[q];
                            bean.buy(product.Price, product);
                        }
                        if (l2 == 5)
                        {
                            bean = null;
                            menu();
                        }
                    }
                }

                //Registration
                else if (choose == 2)
                {
                    //Person config
                    Console.WriteLine("Name Surname:");
                    string nm = Console.ReadLine();
                  

                    Console.WriteLine("Enter iin:");
                    string iin = Console.ReadLine();
                    Console.WriteLine("Enter address:");
                    string add = Console.ReadLine();
                    Console.WriteLine("Name birth:");
                    string birth = Console.ReadLine();
                    
                    Console.WriteLine("If you fiz turn 1,legal turn 2");
                    int face = int.Parse(Console.ReadLine());
                    string f = "";
                    if (face == 1)
                    {
                        f += "fiz";
                    }
                    else if (face == 2)
                    {
                        f += "legal";
                    } //Card conf

                    Random rnd = new Random();
                    string num = string.Empty;

                    for(int i = 0; i < 16; i++)
                    {
                        num += rnd.Next(0,9).ToString();
                    }


                    Console.WriteLine("Choose type:1)gold,2)plastic");
                    int t = int.Parse(Console.ReadLine());
                    string type = "";
                    if (t == 1)
                    {
                        type += "gold";
                    }
                    if (t == 2)
                    {
                        type += "plastic";
                    }
                    int max = 50;
                    int min = 1;
                    Random rand = new Random();
                    int cvv = rand.Next((max - min) + 1) + min;
                    DateTime date = DateTime.Now;
                    string ym = "";
                    ym += date.Month.ToString() + "/" + (date.Year + 2).ToString();
                    Console.WriteLine("Set pin code:");
                    int pin = int.Parse(Console.ReadLine());
                    //Balance conf
                    Console.WriteLine("Add money: ");
                    double ball = double.Parse(Console.ReadLine());

                    a.Add(new Account(new Person(idcounter++, nm, iin, add, birth, f), new Card(num, true, type, cvv, ym, pin), ball));
                    Console.WriteLine("Succes login with pin code");
                    menu();
                }
                //Exit
                else if (choose == 3)
                {
                    system = false;
                }
                //For other number again message
                else
                {
                Console.WriteLine("Hello! You can login or regitration");
                Console.WriteLine("Choose command:");
                Console.WriteLine("1)Enter with pin");
                Console.WriteLine("2)Registration");
                Console.WriteLine("3)Exit");
                Console.WriteLine("Enter command:");
                
                    choose = int.Parse(Console.ReadLine());
                }
            }
        }
    }