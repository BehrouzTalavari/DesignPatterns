using System.Linq.Expressions;

namespace SpecificationPattern
{
    internal class NotSpec<T> : Specification<T>
    {
        private readonly Specification<T> left; 

        public NotSpec(Specification<T> left)
        {
            this.left = left; 
        }
        public override Expression<Func<T, bool>> MyExpression()
        {
            Expression<Func<T,bool>> leftExpression=left.MyExpression(); 
            var param = leftExpression.Parameters[0];
            var paramExpr = Expression.Parameter(param.Type);
            UnaryExpression body =Expression.Not(leftExpression.Body);
            body = (UnaryExpression)new ParameterReplacer(paramExpr).Visit(body);
            var finalExpr = Expression.Lambda<Func<T, bool>>(body, paramExpr);
            return finalExpr;
        }
    }
}