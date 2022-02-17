namespace SpecificationPattern
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public AvailableAge AvailableAge { get; set; }
    }
}