namespace CompositePattern
{
    public class GroupMenu : INode
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public List<INode> Nodes { get; set; }

        public bool Show { get; set; }

        public void Print(string indent)
        {
            if (Show)
            {
                Console.WriteLine($"{indent}Name: {Name}");
                foreach (var item in Nodes)
                {
                    item.Print(indent + "-");
                }
            }
        }
    }
}