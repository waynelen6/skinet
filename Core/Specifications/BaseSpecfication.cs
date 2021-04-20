using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.Specification;

namespace Core.Specifications
{
    public class BaseSpecfication<T> : ISpecification<T>
    {
        public BaseSpecfication()
        {
        }

        public BaseSpecfication(Expression<Func<T, bool>> criteria)
        {
            Criteria = criteria;
        }

        public Expression<Func<T, bool>> Criteria {get; }

        public List<Expression<Func<T, object>>> Includes {get; } = 
            new List<Expression<Func<T,Object>>>();

        protected void AddInclude(Expression<Func<T, Object>> includeExpression)
        {
            Includes.Add(includeExpression);
        }
    }
}