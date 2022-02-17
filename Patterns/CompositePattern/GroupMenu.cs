namespace CompositePattern
{
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
