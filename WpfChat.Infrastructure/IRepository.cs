using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace WpfChat.Infrastructure
{
    public interface IRepository<T>
    {
        T GetById(int id);
        IEnumerable<T> GetByCustomLambda(Expression<Func<T, bool>> expression);
    }
}
