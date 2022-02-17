namespace ProtoTypePattern
{
    public interface ICloneable<T> where T : class
    {
        T Clone();
    }
    public class InnerClass
    {
        public int Count { get; set; }
    }
    public class LargeObje : ICloneable<LargeObje>
    {
        public int Count { get; set; }
        public InnerClass InnerClass { get; set; } = new InnerClass();
        public LargeObje Clone()
        {
            return (LargeObje)MemberwiseClone();
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            LargeObje largeObje = new LargeObje();
            #region Shalow Copy
            var instance1 = largeObje.Clone();
            instance1.Count++;
            Console.WriteLine(instance1.Count);
            Console.WriteLine(instance1.InnerClass.Count++);
            var instance2 = largeObje.Clone();
            instance2.Count++;
            Console.WriteLine(instance2.Count);
            Console.WriteLine(instance2.InnerClass.Count++);
            var instance3 = largeObje.Clone();
            instance3.Count++;
            Console.WriteLine(instance3.Count);
            Console.WriteLine(instance3.InnerClass.Count++);
            var instance4 = largeObje.Clone();
            instance4.Count++;
            Console.WriteLine(instance4.Count);
            Console.WriteLine(instance4.InnerClass.Count++);
            #endregion
            Console.ReadKey();
        }
    }

}