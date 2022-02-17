using System;
namespace BuilderPattern
{
    public enum BreadType
    {
        Buget,
        Barbari,
        Hamberger
    }
    public enum MeatType
    {
        Chicken,
        Sussage,
        Beaf,
        Berger
    }
    public enum CheezType
    {
        Pizza,

    }

    public class Sandwitch
    {
        public MeatType meatType;
        public BreadType breadType;
        public CheezType cheezType;
        public List<string> veges;         
    }
    public class SandwitchBuilder
    {
        private readonly SandwitchIngrideients sandwitchIngrideients;

        public SandwitchBuilder(SandwitchIngrideients sandwitchIngrideients)
        {
            this.sandwitchIngrideients = sandwitchIngrideients;
            sandwitchIngrideients.SetBread();
            sandwitchIngrideients.SetMeat();
            sandwitchIngrideients.SetCheez();
            sandwitchIngrideients.SetVages();
        }
        public Sandwitch GetSandwitch()
        {
            return sandwitchIngrideients.sandwitch;
        }
    }
    public abstract class SandwitchIngrideients
    {
        public readonly Sandwitch sandwitch = new Sandwitch();
        public abstract void SetBread();
        public abstract void SetMeat();
        public abstract void SetCheez();
        public abstract void SetVages();
    }
    public class Hamberger : SandwitchIngrideients
    {
        public override void SetBread()
        {
            sandwitch.breadType = BreadType.Hamberger;

        }

        public override void SetCheez()
        {
            sandwitch.cheezType = CheezType.Pizza;
        }

        public override void SetMeat()
        {
            sandwitch.meatType = MeatType.Berger;
        }

        public override void SetVages()
        {
            sandwitch.veges = new List<string>() { "Lettuces", "Onion" };
        }
    }
    public class Bandari : SandwitchIngrideients
    {
        public override void SetBread()
        {
            sandwitch.breadType = BreadType.Buget;

        }

        public override void SetCheez()
        {
            sandwitch.cheezType = CheezType.Pizza;
        }

        public override void SetMeat()
        {
            sandwitch.meatType = MeatType.Sussage;
        }

        public override void SetVages()
        {
            sandwitch.veges = new List<string>() { "Onion" };
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            SandwitchBuilder sandwitchBuilder = new SandwitchBuilder(new Hamberger());
            var sandwitch = sandwitchBuilder.GetSandwitch();

        }
    }
}