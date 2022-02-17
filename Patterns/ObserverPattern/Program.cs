namespace StatePattern
{
    public interface IState
    {
        bool ChangeState();

    }
    public class OnState : IState
    {
        public bool ChangeState()
        {
            Console.WriteLine("Turned it Off");
            return false;
        }
    }
    public class OffState : IState
    {
        public bool ChangeState()
        {
            Console.WriteLine("Turned it On");
            return true;
        }
    }

    public class TV
    {
        private bool isOn;
        private IState state;
        public bool IsOn { 
            get 
            {
                return isOn; 
            } 
            set 
            { 
                isOn = value;
                state = isOn ? new OnState() : new OffState();
            } 
        }
        public TV()
        {
            state = new OffState();
        }
        public void OnOffBtnPush()
        {
            IsOn = state.ChangeState();
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            var tv = new TV();
            tv.OnOffBtnPush();
            tv.OnOffBtnPush();
            tv.OnOffBtnPush();
            tv.OnOffBtnPush();
            Console.ReadKey();
        }
    }
}