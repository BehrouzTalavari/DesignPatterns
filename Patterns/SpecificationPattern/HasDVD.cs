using System.Linq.Expressions;

namespace SpecificationPattern
{
    public class HasDVD : Specification<Movie>
    {
        public override Expression<Func<Movie, bool>> MyExpression()
        {
            return x => x.CreateDate <= DateTime.Now.AddMonths(-6);
        }
    }
}