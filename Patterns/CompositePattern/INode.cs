namespace CompositePattern
{
    public interface INode
    {
        string Name { get; set; }
        bool Show { get; set; }
        void Print(string indent);
    }
}