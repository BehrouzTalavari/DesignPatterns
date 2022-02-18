
namespace MediatorPattern
{
    public interface ITower
    {
        List<AIRPlain> AIRPlainList { get; set; }
        void Register(AIRPlain aIRPlain);
        void UnRegister(AIRPlain aIRPlain);
        bool AllowChange();
    }
    public class MehrabadTower : ITower
    {
        public List<AIRPlain> AIRPlainList { get; set; } = new List<AIRPlain>();

        public bool AllowChange()
        {
            var result = false;
            foreach (var aIRPlain in AIRPlainList)
            {
                if (aIRPlain is AIRBus)
                {
                    var temp= aIRPlain as AIRBus;
                    //calculate result
                }
                if (aIRPlain is Foker)
                {
                    var temp= aIRPlain as Foker;
                    //calculate result
                } 
                if (aIRPlain is Topolof)
                {
                    var temp= aIRPlain as Topolof;
                    //calculate result
                }
            }
            return result;
        }

        public void Register(AIRPlain aIRPlain)
        {
            AIRPlainList.Add(aIRPlain);
        }

        public void UnRegister(AIRPlain aIRPlain)
        {
            AIRPlainList.Remove(aIRPlain);
        }
    }

    public abstract class AIRPlain:IDisposable
    {
        private readonly ITower tower;

        public string Name { get; set; }
        public int AcceptableDistance { get; set; }
        public void ChangeElevation()
        {
            if (tower.AllowChange())
            {

            }
        }

        public void Dispose()
        {
            tower.UnRegister(this);
        }

        public AIRPlain(ITower tower)
        {
            this.tower = tower;
            this.tower.Register(this);
        }


    }
    public class AIRBus : AIRPlain
    { 

        public AIRBus(ITower tower, string uniqeName) : base(tower)
        {
            Name = $"{nameof(AIRBus)} {uniqeName}";
            AcceptableDistance = 1000;
        }
    }
    public class BoingBus : AIRPlain
    {

        public BoingBus(ITower tower, string uniqeName) : base(tower)
        {
            Name = $"{nameof(BoingBus)} {uniqeName}";
            AcceptableDistance = 2000;
        }
    }
    public class Foker : AIRPlain
    {
        public Foker(ITower tower, string uniqeName) : base(tower)
        {
            Name = $"{nameof(Foker)} {uniqeName}";
            AcceptableDistance = 500;
        }

    }
    public class Topolof : AIRPlain
    {
        public Topolof(ITower tower,string uniqeName) : base(tower)
        {
            Name = $"{nameof(Topolof)} {uniqeName}";
            AcceptableDistance = 800;
        }

    }
    public class Program
    {
        public static void Main(string[] args)
        {
            ITower tehran=new MehrabadTower();
            AIRBus aIRBus = new AIRBus(tehran,"001");
            AIRBus aIRBus2 = new AIRBus(tehran, "002");
            AIRBus foker = new AIRBus(tehran, "001");

             
        }
    }
}