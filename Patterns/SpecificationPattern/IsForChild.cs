using System.Linq.Expressions;

namespace SpecificationPattern
{
    public class IsForChild : Specification<Movie>
    {
        public override Expression<Func<Movie, bool>> MyExpression()
        {
            return c => c.AvailableAge == AvailableAge.Children || c.AvailableAge==AvailableAge.Kides;
        }
    }
}