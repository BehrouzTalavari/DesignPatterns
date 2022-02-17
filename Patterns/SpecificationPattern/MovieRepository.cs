namespace SpecificationPattern
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieContex movieContex;

        public MovieRepository(MovieContex movieContex)
        {
            this.movieContex = movieContex;
        }
        public List<Movie> Search(bool? HasDVD)
        {
            return movieContex.Movies.Where(x => !HasDVD.HasValue || (HasDVD.HasValue && x.CreateDate <= DateTime.Now.AddMonths(-6))).ToList();
        }

        public List<Movie> Search(Specification<Movie> specification)
        {
            return movieContex.Movies.Where(x => specification.IsSpecifiedBy(x)).ToList();
        }
    }
}