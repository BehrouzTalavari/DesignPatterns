using System.Linq.Expressions;

namespace SpecificationPattern
{
    internal class AllSpec<T> : Specification<T>
    {
        public override Expression<Func<T, bool>> MyExpression()
        {
            return c => true;
        }
    }
}