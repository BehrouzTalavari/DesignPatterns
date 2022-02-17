namespace SpecificationPattern
{
    public class Display
    {
        public void Show(List<Movie> movies)
        {
            var hasDVD = new HasDVD();
            var specChild = new IsForChild();
            var mySpec = hasDVD.And(specChild);
            foreach (var item in movies)
            {
                if (mySpec.IsSpecifiedBy(item))
                    Console.WriteLine($"{item.Name} Has DVD");
            }
        }
    }
}