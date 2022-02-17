namespace CompositePattern
{
    public interface INode
    {
        string Name { get; set; }
    }
    public class LeafMenu : INode
    {
        private string url;
        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = $"{name}--{value}";
            }
        }
        public string Url
        {
            get
            {
                return url;
            }
            set
            {
                url = $"{Name}({value})";
            }
        }
    }
    public class GroupMenu : INode
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value; 
            }
        }
        public List<INode> Nodes
        {
            get
            {
                return Nodes;
            }

            set
            {
                foreach (var node in value)
                {
                    node.Name = $"{Name}--{node.Name}";
                    Console.WriteLine(node.Name);
                }
            }
        }
    }

}
