using System.Linq.Expressions;

namespace SpecificationPattern
{
    public abstract class Specification<T>
    {
        public static Specification<T> All()
        {
            return new AllSpec<T>();
        }
        public abstract Expression<Func<T, bool>> MyExpression();
        public bool IsSpecifiedBy(T input)
        {
            var predict = MyExpression().Compile();
            return predict(input);
        }

        public Specification<T> And(Specification<T> right)
        {
            return new AndSpec<T>(this, right);
        }
        public Specification<T> Or(Specification<T> right)
        {
            return new ORSpec<T>(this, right);
        }
        public Specification<T> Not()
        {
            return new NotSpec<T>(this);
        }
    }
}