using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LinqToturial.Helper
{
    public class ExpressionHelper
    {
        private static Expression<Func<T, bool>> AndAlso<T>(Expression<Func<T, bool>> exp1,
                                                           Expression<Func<T, bool>> exp2)
        {
            var expParameter = Expression.Parameter(typeof(T), nameof(T));
            var expBody = Expression.AndAlso(exp1.Body, exp2.Body);
            expBody=(BinaryExpression)new Replacer(expParameter).Visit(expBody);
            return Expression.Lambda<Func<T, bool>>(expBody, expParameter);
        }
        public static Expression<Func<T, bool>> GenerateExpression<T>(params Expression<Func<T, bool>>[] lstExp)
        {
            Expression<Func<T, bool>> expResult = exp => true;
            foreach (var exp in lstExp)
            {
                if (exp is null)
                    continue;
                expResult=AndAlso<T>(exp, expResult);
            }
            return expResult;
        }

    }
    public class Replacer : ExpressionVisitor
    {
        private readonly ParameterExpression _parameter;

        public Replacer(ParameterExpression parameter)
        {
            this._parameter=parameter;
        }
        protected override Expression VisitParameter(ParameterExpression node)
        {
            return base.VisitParameter(_parameter);
        }
    }
}
