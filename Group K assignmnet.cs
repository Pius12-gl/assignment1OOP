namespace OOP_II
{

    using static System.Console;
    public class Program
    {

        static void Main(string[] args)
        {


            RMDepartment mys = new RMDepartment();
            Stone st1 = new Stone("Travertine", 12.45, "Red", 190);
            Stone st2 = new Stone("Basalt", 34.56, "Green", 150);
            Stone st3 = new Stone("Graphite", 89.45, "Yellow", 340);
            Stone st4 = new Stone("Marble", 20.43, "Blue", 560);
            Stone st5 = new Stone("Diamond", 97.26, "White", 680);
            Stone st6 = new Stone("Onyx", 10.13, "Black", 100);
            Stone st7 = new Stone("Soapstone", 50.10, "Pink", 50);
            Stone st8 = new Stone("Marble", 60.39, "Green", 440);
            mys.addStone(st1);
            mys.addStone(st2);
            mys.addStone(st3);
            mys.addStone(st4);
            mys.addStone(st5);
            mys.addStone(st6);
            mys.addStone(st7);
            mys.addStone(st8);
            WriteLine("**************************Black Diamond Stones************************************");
            WriteLine("                                                              ");
            WriteLine("                                                              ");
            WriteLine($"Name of metal:{st1.GetName()} Price:${st1.GetPrice} Color:{st1.GetColour} Weight:{st1.GetWeight}");
            WriteLine("");
            WriteLine($"Name of metal:{st2.GetName()} Price:${st2.GetPrice} Color:{st2.GetColour} Weight:{st2.GetWeight}");
            WriteLine("");
            WriteLine($"Name of metal:{st3.GetName()} Price:${st3.GetPrice} Color:{st3.GetColour} Weight:{st3.GetWeight}");
            WriteLine("")
            WriteLine($"Name of metal:{st4.GetName()} Price:${st4.GetPrice} Color:{st4.GetColour} Weight:{st4.GetWeight}");
            WriteLine($"Name of metal:{st5.GetName()} Price:${st5.GetPrice} Color:{st5.GetColour} Weight:{st5.GetWeight}");
            WriteLine($"Name of metal:{st6.GetName()} Price:${st6.GetPrice} Color:{st6.GetColour} Weight:{st6.GetWeight}");
            WriteLine($"Name of metal:{st7.GetName()} Price:${st7.GetPrice} Color:{st7.GetColour} Weight:{st7.GetWeight}");
            WriteLine($"Name of metal:{st8.GetName()} Price:${st8.GetPrice} Color:{st8.GetColour} Weight:{st8.GetWeight}");





            //Methods
            WriteLine($"{mys.MostExpensiveStone()}");
            WriteLine($"{mys.WeightAbove180Kg()}");


        }
    }
    public class Stone
    {
        private string name;
        private double price;
        private string colour;
        private double weight;

        public Stone(string n, double p, string c, double w)
        {
            name = n;
            price = p;
            colour = c;
            weight = w;
        }
        public string GetName()
        {
            return name;
        }
        public double GetPrice()
        {
            return price;
        }
        public double GetColour()
        {
            return price;
        }
        public double GetWeight()
        {
            return weight;
        }
    }

    public class RMDepartment
    {
        private Stone[] myStone;
        int amount;
        public RMDepartment()
        {
            myStone = new Stone[5];
            amount = 0;
        }

        public void addStone(Stone s)
        {
            myStone[amount] = s;
            ++amount;
        }



        public string MostExpensiveStone()
        {
            double max = myStone[0].GetPrice();
            string name = myStone[0].GetName();
            for (int i = 1; i < amount; i++)
            {
                if (myStone[i].GetPrice() > max)
                {
                    max = myStone[i].GetPrice();
                    name = myStone[i].GetName();
                }
            }
            return name + " and price is $" + max;
        }


        public int WeightAbove180Kg()
        {
            int count = 0;
            for (int i = 0; i < amount; i++)
            {
                if (myStone[i].GetWeight() > 12)
                {
                    ++count;
                }
            }
            return count;
        }



    }
    class Veichle
    {
        private string type;
        private int plateNumber;
        private string colour;
        private string driverID;

        public Veichle(string t, int pN, string c, string dD)
        {
            type = t;
            plateNumber = pN;
            colour = c;
            driverID = dD;
        }
        new public string GetType()
        {
            return type;
        }
        public int GetPlateNumber()
        {
            return plateNumber;
        }
        public string GetColour()
        {
            return type;
        }
        public string GetdriverID()
        {
            return driverID;
        }


    }
    class Truck: Veichle
    {
        new public string GetType()
        {
            return type;
        }
        public int GetPlateNumber()
        {
            return plateNumber;
        }
        public string GetColour()
        {
            return type;
        }
        public string GetdriverID()
        {
            return driverID;
        }
    }
    class MiniVan : Veichle
    {
        new public string GetType()
        {
            return type;
        }
        public int GetPlateNumber()
        {
            return plateNumber;
        }
        public string GetColour()
        {
            return type;
        }
        public string GetdriverID()
        {
            return driverID;
        }
    }




}
