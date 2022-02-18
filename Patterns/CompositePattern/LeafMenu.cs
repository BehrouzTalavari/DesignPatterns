namespace CompositePattern
{
    public class LeafMenu : INode
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public bool Show { get; set; }
        public void Print(string indent)
        {
            if (Show)
            {
                Console.WriteLine($"{indent}Name: {Name} url: {Url}");
            }
        }
    }

}
