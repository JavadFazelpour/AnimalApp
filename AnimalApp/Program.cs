namespace AnimalApp
{
    abstract class Animal
    {
        public abstract void MakeNois();
    }
    class Hippo : Animal
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
    class Wolf : Canine
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
            Animal[] animals = {new Wolf(false),
                                new Hippo(),
                                new Wolf(true),
                                new Wolf(false),
                                new Hippo()
            };
            foreach (Animal animal in animals)
            {
                animal.MakeNois();
                
                if (animal is Hippo hippo) hippo.Swim();
                if (animal is Wolf wolf) wolf.HuntInPack();
                
                Console.WriteLine("---------------------");
            }
        }
    }
}
