namespace ConsoleApp1
{
    public class Bird
    {
        private protected int eggs;
        private protected int chicks;
        private protected Bird(int eggs, int chicks)
        {
            this.eggs = eggs;
            this.chicks = chicks;

            Console.WriteLine(flight);
            Console.WriteLine(layEggs);
            Console.WriteLine(hatchEggs);
        }

        internal virtual string flight
        {
            get
            {
                return "Fly...";
            }
        }
        internal virtual void sing()
        {
            Console.WriteLine("The bird is singing");

        }
        internal virtual string layEggs
        {

            set
            {
                eggs = Convert.ToInt32(value);
            }
            get
            {
                return $"The bird layed {eggs} eggs";
            }
        }
        internal virtual string hatchEggs
        {

            set
            {
                eggs = Convert.ToInt32(value);
            }
            get
            {
                return $"The bird hatced {chicks} chicks";
            }
        }
    }
    class Zozyla : Bird
    {
        public Zozyla(int eggs, int chicks) : base(eggs, chicks)
        {
        }

        internal sealed override void sing()
        {
            Console.WriteLine("Kyky...kyky...kyky");
        }
    }

    class Kyrka : Bird
    {
        public Kyrka(int eggs, int chicks) : base(eggs, chicks)
        {
        }

        internal override void sing()
        {
            Console.WriteLine("Kykareky...Kykareky");
        }

    }

    class Kvochka : Kyrka
    {
        public Kvochka(int eggs, int chicks) : base(eggs, chicks)
        {
        }

    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Kvochka kvochka = new Kvochka(5,18);
            kvochka.sing();
        }
    }
}