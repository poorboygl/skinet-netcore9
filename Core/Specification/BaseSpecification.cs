using System;
using System.Linq.Expressions;
using Core.Interfaces;

namespace Core.Specification;

public class BaseSpecification<T>(Expression<Func<T, bool>> criteria) : ISpecification<T>
{
    public Expression<Func<T, bool>> Criteria => criteria;
}

//? Previous version
// public class BaseSpecification<T> : ISpecification<T>
// {
//     public readonly Expression<Func<T, bool>> criteria;
//     public BaseSpecification(Expression<Func<T, bool>> criteria)
//     {
//         this.criteria = criteria;
//     }

//     public Expression<Func<T, bool>>Criteria => criteria;

// }
