using System.Linq.Expressions;

namespace SpecificationPattern
{
    internal class AndSpec<T> : Specification<T>
    {
        private readonly Specification<T> left;
        private readonly Specification<T> right;

        public AndSpec(Specification<T> left, Specification<T> right)
        {
            this.left = left;
            this.right = right;
        }
        public override Expression<Func<T, bool>> MyExpression()
        {
            Expression<Func<T,bool>> leftExpression=left.MyExpression();
            Expression<Func<T,bool>> rightExpression=right.MyExpression();
            var param = leftExpression.Parameters[0];
            var paramExpr = Expression.Parameter(param.Type);
            BinaryExpression body=Expression.AndAlso(leftExpression.Body,rightExpression.Body);
            body = (BinaryExpression)new ParameterReplacer(paramExpr).Visit(body);
            var finalExpr = Expression.Lambda<Func<T, bool>>(body, paramExpr);
            return finalExpr;
        }
    }
}