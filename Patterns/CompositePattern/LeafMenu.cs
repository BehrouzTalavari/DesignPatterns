namespace CompositePattern
{
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
                name = value;
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

}
