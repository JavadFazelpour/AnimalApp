namespace AnimalApp
{
    abstract class Animal
    {
        public abstract void MakeNois();
    }
    class Hippo : Animal,ISwimmer
    {
        public override void MakeNois()
        {
            Console.WriteLine("Grunt.");
        }
        public void Swim()
        {
            Console.WriteLine("Splash! I'm going for a swim!");
        }
    }
    abstract class Canine:Animal
    {
        public bool BelongsToPack { get; protected set; } = false;
    }
    class Wolf : Canine,IPackHunter
    {
        public Wolf(bool belongsToPack)
        {
            BelongsToPack = belongsToPack;
        }
        public override void MakeNois()
        {
            if(BelongsToPack) Console.WriteLine("I'm in a pack.");
            Console.WriteLine("Aroooooooooo!");
        }
        public void HuntInPack()
        {
            if(BelongsToPack) Console.WriteLine("I'm going hunting with my pack!");
            else Console.WriteLine("I'm not in a pack.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            ISwimmer swimmer = new Hippo();
            Wolf wolf = swimmer as Wolf;
            if (wolf==null) Console.WriteLine("wolf is null");
            else Console.WriteLine("wolf is casted");
            */
            /*
             * Animal[] animals = {new Wolf(false),
                                new Hippo(),
                                new Wolf(true),
                                new Wolf(false),
                                new Hippo()
            };
            foreach (Animal animal in animals)
            {
                animal.MakeNois();
                
                if (animal is ISwimmer  swimmer) swimmer.Swim();
                if (animal is IPackHunter hunter) hunter.HuntInPack();
                
                Console.WriteLine("---------------------");
            }

            */
        }
    }
}
