using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ISpecification<T>
    {
        Expression<Func<T,bool>>? Criteria { get; }
        public Expression<Func<T, object>>? OrderBy { get; }
        public Expression<Func<T, object>>? OrderByDesc { get;}
    }
}
