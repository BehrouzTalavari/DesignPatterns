namespace SpecificationPattern
{
    public interface IMovieRepository
    {
        List<Movie> Search(bool? HasDVD);
        List<Movie> Search(Specification<Movie> specification);
    }
}